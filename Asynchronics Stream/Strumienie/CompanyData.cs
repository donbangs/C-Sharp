using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strumienie
{
    class CompanyData
    {
        string Symbol { get; set; }
        string CompanyName { get; set; }
        string Exchange { get; set; }
        string Industry { get; set; }
        string Website { get; set; }
        string Description { get; set; }
        string CEO { get; set; }
        string IssueType { get; set; }
        string Sector { get; set; }

        public override string ToString()
        {
            return $"{Symbol} {CompanyName} {Website}";
        }
        public async IAsyncEnumerable<CompanyData> GetLine(CancellationToken token = default)
        {
            using var stream = new StreamReader(File.OpenRead(@"C:\Users\HP\source\repos\Strumienie\Strumienie\CompanyData.csv"));

            await stream.ReadLineAsync();

            string line;

            while ((line = await stream.ReadLineAsync()) != null)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }

                var segments = line.Split(',');
                for (var i = 0; i < segments.Length; i++) segments[i] = segments[i].Trim('\'', '"');
                
                    var price = new CompanyData
                    {
                        Symbol = segments[0],
                        CompanyName = segments[1],
                        Exchange = segments[2],
                        Industry = segments[3],
                        Website = segments[4],
                        Description = segments[5],
                        CEO = segments[6],
                        IssueType = segments[7],
                        Sector = segments[8],
                    };
                

                yield return price;
            }
        }
    }
}

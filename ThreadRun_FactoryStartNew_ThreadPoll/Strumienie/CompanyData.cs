using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strumienie
{
   public class CompanyData
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


        public static Task<IEnumerable<CompanyData>> PollThread()
        {
            var source = new TaskCompletionSource<IEnumerable<CompanyData>>();
            ThreadPool.QueueUserWorkItem(_ => {
                var line = File.ReadAllLines(@"CompanyData.csv");
                var l = line
                .Skip(1)
                .Select(l => CompanyData.LineToData(l));
                 source.SetResult(l);
            });
            return source.Task;
        }
        public static CompanyData LineToData(String line)
        {
            var segments = line.Split(',');
            for (var i = 0; i < segments.Length; i++) segments[i] = segments[i].Trim('\'', '"');
            return  new CompanyData
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

        }
    }
}

   M S B A M L   `   `   `  ����C  ?Animacje, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AnimacjeAnimacje  5   	       Animacje.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Animacje     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      5      �� 5      5      �� 5      5       � RowDefinitions 5   
   �� 5      5      �� 5      5      �� 5      5      .+�5!   
   �� -   5        $��Button1��5!      $��Kliknij��6!   6L   �� 5"   
   -   5        $��Button2��5"   .   $��2��6   $��1��6   $��Render��6>   6h   �� 5#   
   -   5        $��Button3��5#      $��2��6   $��Layout��6.   6X   �� 5%   
   -   5        $��Image1��5%      $��1��6   $
��Fill=�6.   6@   �� 5'   
   $��3��6   $��10q�6%   .+�5(      �� -   5        $��MyRectangle��5)       �� Stretch$
 Fill=�5*      $	��122��5+      $
��auto��5,      
����  � � Triggers 5.      :� 50       :� RoutedEvent$ Rectangle.Loaded��6#   .[�51      �� .��52      �� .��53   "   �� 	 �� To$	 RedX�61    �� TargetProperty$. ((Rectangle.Fill).(SolidColorBrush.Color)�55   %    g� AutoReverse . 	 g� RepeatBehavior$	 Forever��57   &   
 g� Duration$
 0:0:2D�58   &   59      5:      5;      5=      5>      �� 5?   
   -   5        $��myStackPanel��5?      $��1��6)   $��1��69   .+�5@      �� -   5        $��myButton��5@   "   $	��136��6   $��1��62   $��1��6B   6O   5A      5D      5E      
   M S B A M L   `   `   `  ����J  FHoursCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HoursCalculatorHoursCalculator  5   	        HoursCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:HoursCalculator     5   	     � Title$  Weekly Hours Calculator��5   	   $	��835��6)   $
��1080��66    � 
ResizeMode$ NoResize=�5	   	    � Icon$ ./Images/icon.jpg��5
   	   .��5      � $��0,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      $��72 �6   �� 5      $	��761 �6   �� 5      .+�5   
   �� $��Monday:��6   $
��Left=�6"   $��122,111,0,0q�6=   $	��Top=�6R   $��14(�6j   $
��Bold"�6x   $��1��6�   �� 5   
   $��Tuesday:��6   $
��Left=�6#   $��122,142,0,0q�6>   $	��Top=�6S   $��14(�6k   $
��Bold"�6y   $��1��6�   �� 5   
   $��
Wednesday:��6   $
��Left=�6%   $��
99,173,0,0q�6@   $	��Top=�6T   $��14(�6l   $
��Bold"�6z   $��1��6�   �� 5   
   $��	Thursday:��6   $
��Left=�6$   $��117,204,0,0q�6?   $	��Top=�6T   $��14(�6l   $
��Bold"�6z   $��1��6�   �� 5   
   $��Friday:��6   $
��Left=�6"   $��133,235,0,0q�6=   $	��Top=�6R   $��14(�6j   $
��Bold"�6x   $��1��6�   �� 5   
   -   5        $
��txt1��5   �   $
��Left=�6   $��23��6-   $��196,114,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $	��8.0��6�   $��14(�6�   $��1��6�   �� 5   
   -   5        $��	txtStart1��5   �   $
��Left=�6   $��23��6-   $��333,114,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5   
   -   5        $��
txtFinish1��5   �   $
��Left=�6   $��23��6-   $��472,114,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5   
   -   5        $
��txt2��5   �   $
��Left=�6   $��23��6-   $��196,146,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $	��8.0��6�   $��14(�6�   $��1��6�   �� 5   
   -   5        $��	txtStart2��5   �   $
��Left=�6   $��23��6-   $��333,146,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5   
   -   5        $��
txtFinish2��5   �   $
��Left=�6   $��23��6-   $��472,146,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5!   
   -   5        $
��txt3��5!   �   $
��Left=�6   $��23��6-   $��196,177,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $	��8.0��6�   $��14(�6�   $��1��6�   �� 5"   
   -   5        $��	txtStart3��5"   �   $
��Left=�6   $��23��6-   $��333,177,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5#   
   -	   5        $��
txtFinish3��5#   �   $
��Left=�6   $��23��6-   $��472,177,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5&   
   -
   5        $
��txt4��5&   �   $
��Left=�6   $��23��6-   $��196,208,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $	��8.0��6�   $��14(�6�   $��1��6�   �� 5'   
   -   5        $��	txtStart4��5'   �   $
��Left=�6   $��23��6-   $��333,208,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5(   
   -   5        $��
txtFinish4��5(   �   $
��Left=�6   $��23��6-   $��472,208,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5+   
   -   5        $
��txt5��5+   �   $
��Left=�6   $��23��6-   $��196,239,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $	��8.0��6�   $��14(�6�   $��1��6�   �� 5,   
   -   5        $��	txtStart5��5,   �   $
��Left=�6   $��23��6-   $��333,239,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5-   
   -   5        $��
txtFinish5��5-   �   $
��Left=�6   $��23��6-   $��472,239,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��120��6z   $��14(�6�   $��1��6�   6�   �� 5/   
   $��Total Hours:��6   $
��Left=�6'   $��649,111,0,0q�6B   $	��Top=�6W   $��14(�6o   $
��Bold"�6}   $��1��6�   �� 50   
   -   5        $
��lbl1��50   h   $��0 hrs��6   $
��Left=�6    $��744,111,0,0q�6;   $	��Top=�6P   $��14(�6t   $��1��6�   $��2��6�   �� 51   
   $��Remaining Hours:��6   $
��Left=�6+   $��611,142,0,0q�6F   $	��Top=�6[   $��14(�6s   $
��Bold"�6�   $��1��6�   �� 52   
   -   5        $
��lbl2��52   h   $��0 hrs��6   $
��Left=�6    $��744,142,0,0q�6;   $	��Top=�6P   $��14(�6t   $��1��6�   $��2��6�   �� 53   
   -   5        $��	Calculate��53      $
��Left=�6%   $��618,240,0,0q�6@   $	��Top=�6U   $	��164��6m   $��22��6y   $��14(�6�   
���   �
�������$��1��6�   $��2��6�   �� 54   
   -   5        $
��img1��54   ^   $��Right=�6   $	��508��6,   $	��Top=�69   $
��1080��6Q   $��UniformToFill=�6j   $��
-6,295,0,0q�6�   $��3��6�   �� 55   
   -   5        $��163,698,13,62q�55   (   
������ $��0q�6X   
������ $��2��6�   $��45��6�   $��55��6�   .��56      �� .��57      �� -   5        $
��img2��57   K   $��Right=�6   $��31��64   $��51��6@   $��UniformToFill=�6W   $��./Images/refresh.png��6o   58      59      �� 5:   
   -   5        $
��img3��5:   ]   $��Right=�6   $��80��6,   $	��Top=�68   $
��1072��6P   $��UniformToFill=�6i   $��3��6�   $��0,-1,2,0q�6�   �� 5;   
   $��Weekly Hours Calculator��6   $
��Left=�62   $��
736,22,0,0q�6M   $	��Top=�6a    J� RenderTransformOrigin$ 1.842,-0.692&�6y   $��20(�5<      $
��Bold"�6   $��2��60   
�����w�$��1��6`   �� 5=   
   $��Hours��6   $��1��6    $
��Left=�60   $��
196,79,0,0q�6K   $	��Top=�6_   $��14(�6w   $
��Bold"�6�   �� 5>   
   $��
Start (AM)��6   $��1��6%   $
��Left=�65   $��
333,79,0,0q�6P   $	��Top=�6d   $��14(�6|   $
��Bold"�6�   �� 5?   
   $��Finish (PM)��6   $��1��6&   $
��Left=�66   $��
472,79,0,0q�6Q   $	��Top=�6e   $��14(�6}   $
��Bold"�6�   �� 5@   
   -   5        $
��Save��5@      $
��Left=�6    $��618,209,0,0q�6;   $	��Top=�6P   $	��164��6h   $��22��6t   $��14(�6�   
���   �
�������$��1��6�   $��2��6�   �� 5A   
   -   5        $��	Reset All��5A      $
��Left=�6%   $��618,177,0,0q�6@   $	��Top=�6U   $	��164��6m   $��22��6y   $��14(�6�   
���   �
�������$��1��6�   $��2��6�   �� 5B   
   $
��Left=�6   $��48��6+   $��157,748,0,0q�67   $	��Top=�6L   $��74��6d   $��./Images/work.png��6o   $��UniformToFill=�6�   $ -0.223,0.573&�6�   $��2��6�   5C      5D      
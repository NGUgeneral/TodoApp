   M S B A M L   `   `   `  ����T  POsaulenkoEgor_Diceus_Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:OsaulenkoEgor_Diceus_TestOsaulenkoEgor_Diceus_Test  5   	   *    $OsaulenkoEgor_Diceus_Test.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:OsaulenkoEgor_Diceus_Test     5   	   -   5          �Name$  Window��5	   	    � Title$ TODO: ��5   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ Normal=�5   	    � Icon$ /img/icon.png��5   	      	BlueBrush#��[  5   	   $��0q�5   	   $
��1024��5   	   $	��768��5   	   
������ $.��(/Assets/Fonts/OpenSans/#OpenSans Regular)�5   	   .��5      �   
WhiteBrush#��[ 6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��20* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $��* �6   .+�5"   
   ]� -   5        $��
dckpnlRoot��5#      #��[  5"      $��0��5$      $��3��5%      $��0��5&      ��.  $y�Visible=�5)      .+�5*      �� -   5        	 ��Name$	 CloseButton��5*      |�.  $��Right=�5,      $��30��5-        windowIconButtonStyle#��[ 5.      .��50      �� $��/img/close.png��6   52      �� 53      -   5        $	 MaximizeButton��53      |�.  $��Right=�55      $��30��56      #��[ 57      .��59      �� $��/img/maximize.png��6   5;      �� 5<      -   5        $	 	MinButton��5<      |�.  $��Right=�5>      $��Center=�5?      #��[ 5@      $��30��5A      .��5C      �� $��/img/minimize.png��6   5E      5F      � 5G   
   #��[ 6   $��Stretch=�5H      $��1��5I      $��1��5J       5K      �� 5L      $��* �6#   �� 5M      $
��Auto �6#   .+�5O      �� -   5        $��	lblHeader��5O      $��0��5P      $��Manage your tasks��5Q      $
��Left=�5R      $��Center=�5S        GrayDarkBrush#��[ 5T      $��0,20,0,0q�5U      $��24(�5V      �� 5W      -   5        $��
btnAddTask��5W        IconButtonStyle#��[ 5X      $��1��5Z      $��75��5[      $��0,20,0,0q�5\      $��5q�5]      .��5^      �� ��5_      �� 5`      
 �� 
TargetType"
 ��6    .�5a      ��  �� Property � �� �� Value$ /Img/plus.png��5b   %    �� Triggers 5c      �� 5d   "    �� Binding 6.   ��  �� RelativeSource �� *Self+ �� Path$ IsMouseOver� �� Value True5e   .   .a�5f   &   ��  � ��$ /Img/plusHighlight.png��5g   -   5h   #   5j      5m      5n      5o      � 5p   
   -   5         �Name$ controlHolder��5p      $��Stretch=�5q      $��Stretch=�5r      $��1��5s      $��2��5t      � 5u   
   -	   5        $ 	preloader��5u      $��Stretch=�5v      $��Stretch=�5w      $��1��5x      $��2��5y        BlackFadedBrush#��[ 5z      $y�Hidden=�5{      5|      5}      
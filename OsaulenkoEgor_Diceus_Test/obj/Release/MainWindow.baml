   M S B A M L   `   `   `  ���� T  POsaulenkoEgor_Diceus_Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:OsaulenkoEgor_Diceus_TestOsaulenkoEgor_Diceus_Test  *    $OsaulenkoEgor_Diceus_Test.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:OsaulenkoEgor_Diceus_Test     -     �Name$  Window�� � Title$ TODO: �� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowState$ Normal=� � Icon$ /img/icon.png��   	BlueBrush#��[  $��0q�$
��1024��$	��768��
������ $.��(/Assets/Fonts/OpenSans/#OpenSans Regular)�.���   
WhiteBrush#��[  � ColumnDefinitions �� $��* ��� $	��20* ��� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* �.+�]� -   $��
dckpnlRoot��#��[  $��0��$��3��$��0����.  $y�Visible=�.+��� -   	 ��Name$	 CloseButton��|�.  $��Right=�$��30��  windowIconButtonStyle#��[ .���� $��/img/close.png���� -   $	 MaximizeButton��|�.  $��Right=�$��30��#��[ .���� $��/img/maximize.png���� -   $	 	MinButton��|�.  $��Right=�$��Center=�#��[ $��30��.���� $��/img/minimize.png��� #��[ $��Stretch=�$��1��$��1�� �� $��* ��� $
��Auto �.+��� -   $��	lblHeader��$��0��$��Manage your tasks��$
��Left=�$��Center=�  GrayDarkBrush#��[ $��0,20,0,0q�$��24(��� -   $��
btnAddTask��  IconButtonStyle#��[ $��1��$��75��$��0,20,0,0q�$��5q�.���� ���� 
 �� 
TargetType"
 ��.���  �� Property � �� �� Value$ /Img/plus.png�� �� Triggers ��  �� Binding ��  �� RelativeSource �� *Self+ �� Path$ IsMouseOver� �� Value True.a���  � ��$ /Img/plusHighlight.png��� -    �Name$ controlHolder��$��Stretch=�$��Stretch=�$��1��$��2��� -	   $ 	preloader��$��Stretch=�$��Stretch=�$��1��$��2��  BlackFadedBrush#��[ $y�Hidden=�
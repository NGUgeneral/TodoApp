   M S B A M L   `   `   `  ���� T  POsaulenkoEgor_Diceus_Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:OsaulenkoEgor_Diceus_Test.ViewsOsaulenkoEgor_Diceus_Test.Views  4    .OsaulenkoEgor_Diceus_Test.Views.InsertTodoView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:OsaulenkoEgor_Diceus_Test.Views     -   $��
ucEditTodo��$��Stretch=�$��Stretch=�   
WhiteBrush#��[  .���   � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $
��Auto �$	��100��$	��400���� $
��Auto �.+�� $��0������  �� Path$ ActualHeight� �� ElementName$ Nombre��.+��� -   $��tbTitle��  InboxGrayHigh#��[ $��0,0,0,1q�$��10q����� $ 
ucEditTodo��$ ActualWidth��� -   $��tbTitleWatermark��$��	Title ...��  TextBlockWatermark#��[ � $��2��.+��� -   $��	tbMessage��#��[ $
��Auto�� �� TextWrapping$
 Wrap=�$��Stretch=�$��Stretch=�$��0q�$	��Top=�$��10q����� $ 
ucEditTodo��$ ActualWidth��� -   $��tbMessageWatermark��$	��Top=�$��	10,10,0,0q�$$��Enter the task description ...��#��[ (  "System.Windows.Controls.DatePicker  -   $��	dpExecute��  
DatePicker#��[ $��1��$��0,0,0,1q�$��10,0,0,0q�$��14(�|�.  ���� $ 
ucEditTodo��$ ActualWidth��� -   $��lblSave��$��3��  MenuLink#��[ $
��Save��$��Right=�$��36(�
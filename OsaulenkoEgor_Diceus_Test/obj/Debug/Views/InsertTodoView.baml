   M S B A M L   `   `   `  ����T  POsaulenkoEgor_Diceus_Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:OsaulenkoEgor_Diceus_Test.ViewsOsaulenkoEgor_Diceus_Test.Views  5      4    .OsaulenkoEgor_Diceus_Test.Views.InsertTodoView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:OsaulenkoEgor_Diceus_Test.Views     5      -   5        $��
ucEditTodo��5
      $��Stretch=�5      $��Stretch=�5         
WhiteBrush#��[  5	      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $	��100��5      $	��400��5      �� 5      $
��Auto �6   .+�5   
   � $��0��5      ��5      ��  �� Path$ ActualHeight� �� ElementName$ Nombre��.+�5      �� -   5        $��tbTitle��5        InboxGrayHigh#��[ 5      $��0,0,0,1q�5      $��10q�5      ��5      �� $ 
ucEditTodo��$ ActualWidth�5      �� 5      -   5        $��tbTitleWatermark��5      $��	Title ...��5        TextBlockWatermark#��[ 5      5       � 5!   
   $��2��6   .+�5"      �� -   5        $��	tbMessage��5"      #��[ 5#      $
��Auto��5%       �� TextWrapping$
 Wrap=�5&      $��Stretch=�5'      $��Stretch=�5(      $��0q�5)      $	��Top=�5*      $��10q�5+      ��5$      �� $ 
ucEditTodo��$ ActualWidth�5-      �� 5.      -   5        $��tbMessageWatermark��5.      $	��Top=�5/      $��	10,10,0,0q�50      $$��Enter the task description ...��51      #��[ 52      53      (  "System.Windows.Controls.DatePicker  54   
   -   5        $��	dpExecute��54        
DatePicker#��[ 55      $��1��56      $��0,0,0,1q�58      $��10,0,0,0q�59      $��14(�5:      |�.  ��57      �� $ 
ucEditTodo��$ ActualWidth�5;      �� 5<   
   $��3��6    �� Orientation$ 
Horizontal=�5=      $��Right=�5>      .+�5?      �� -   5        $��	lblCancel��5?        MenuLink#��[ 5A      $��Cancel��5B      $��0,0,20,0q�5C      $��36(�5D      �� 5E      -   5        $��lblSave��5E      #��[ 5G      $
��Save��5H      $��36(�5I      5J      5K      5L      
   M S B A M L   `   `   `  ���� T  POsaulenkoEgor_Diceus_Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:OsaulenkoEgor_Diceus_Test.Assets OsaulenkoEgor_Diceus_Test.Assets  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   BlueHighlight  	BlueLight  Blue  BlueDark 	 White 	 Black  	GrayLight  GrayMenu  Gray 	 GrayDark 
 Red  RedHighlight  RedDark  BlueHighlightBrush  �� Color  BlueLightBrush  	BlueBrush  BlueDarkBrush  BlueLightFadedBrush �� Opacity  BlueFadedBrush  BlueDarkFadedBrush  
WhiteBrush  WhiteFadedBrush  
BlackBrush  BlackShadowBrush  BlackFadedBrush  GrayLightBrush  GrayMenuBrush  	GrayBrush  GrayDarkBrush  GrayFadedBrush  GrayDarkFadedBrush  RedHighlightBrush   RedBrush ! RedDarkBrush " RedFadedBrush # ScrollButton $ ScrollBG % ScrollThumb & LabelDataGridHeader �� 
TargetType �� Property �� Value ' TextBlockPlainGray ( TextBlockWatermark ) MenuLink �� Triggers �� Binding �� RelativeSource �� Path	 �� Value * IconButtonStyle
 �� 
TargetType ��Name J� SnapsToDevicePixels �� Padding �� CornerRadius J� Effect3   -System.Windows.Media.Effects.DropShadowEffect    ShadowDepth    Opacity    
BlurRadius T� X T� Y �� Triggers P� Property P� Value �� 
TargetName N� EnterActions g� Duration	 W� To �� 
TargetName �� TargetProperty N� ExitActions + windowIconButtonStyle , DataGrid&   System.Windows.Controls.DataGrid - DataGridRow . DataGridHeader �� 	Resources*  $System.Windows.Controls.DataGridCell)  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader / 	InboxBlue  ��Name 0 	InboxGray! �� BasedOn 1 InboxGrayHigh 2 InboxGrayRich 3 
DatePicker(  "System.Windows.Controls.DatePicker 4 DatePickerCalendarStyle" �Name# � ColumnDefinitions$ ��Name% ��Name& �� ElementName:  4System.Windows.Controls.Primitives.DatePickerTextBox'  Name( � 	Resources 5 Key'  !System.Windows.VisualStateManager)   VisualStateGroups%  System.Windows.VisualStateGroup*   Transitions%	  System.Windows.VisualTransition+ 	  GeneratedDuration	, 	  To-   States 
  System.Windows.VisualState. 
  
Storyboard	/ �� To0 J� Opacity1 ��Name2 J� IsHitTestVisible 6 WatermarkBrush3 �� RadiusY4 �� RadiusX5 �Name6 � AllowsTransparency7 � 	StaysOpen8 � PlacementTarget�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     8local.clr-namespace:OsaulenkoEgor_Diceus_Test.Assets  %$  &	        &	      &	 "     &	 3     &	 D     &	 U     &	 f     &	 w     &	 �     &		 �     &	
 �     &	 �     &	 �     &	 �     7   &	 �     7  &	 �     7  &	 �     7  &	     7  &	     7  &	 -    7  &	 A    7  &	 K    7  &	 _    7  &	 i    7  &	 }    7  &	 �    7  &	 �    7  &	 �    7  &	 �    7 	 &	 �    7  &	 �    7 	 &	 �    7  &	  �    7 
 &	! �    7  &	" �    7 
 &	#     7  &	$     7  &	% '    7  &	& 1    7  &	' �    7  &	(     7  &	) �    7  7  &	* �    &	+ 	    7  &	, b    &	- �    7  7  &	. �    7  &	/ w    7  7  &	0 �    7 / 7  &	1 -    7 0 7  &	2 �    7  7  &	3 �    7  7  7 * 7  7 6 ��#5CD8FF����#2380FF����#005095����#0C3E68����#ffffff����#000000����#DADADA����#F0F0F0����#929497����#525354����#FF2340����#EC2031����#BE2230���� 8    �� 8    �� 8    �� 8    �� 8    $	 0.2Q��� 8    $	 0.4Q��� 8    $	 0.4Q��� 8    �� 8    $	 0.4Q��� 8    �� 8    $	 0.1Q��� 8    $	 0.4Q��� 8    �� 8    �� 8    �� 8    �� 8    $	 0.4Q��� 8    $	 0.4Q��� 8    �� 8    �� 8    �� 8    $	 0.4Q��� 8    �� 8    �� 8    �� " ��.���  � ��$ Center=���  � ��8   ��  � ��$
 Left=���  � ��$ 16(���  � ��$ 	10,0,10,0q��� " ��.���  � ��8   ��  � ��$ 16(���  � ��$ Center=���  � ��$
 Left=��� " ��.���  � ��8   ��  � ��$ Center=���  � ��$
 Left=���  � ��$ 14(���  � ��$ 10,0,0,0q���  �@J�IsHitTestVisible .  �� " ��.���  � ��$ Bottom=���  � ��$ 16(���  � ��$ 20,0,0,0q���  � ��$
 Left=���  � ��$	 Top=���  � ��8    ��  ��  �� *Self+$ IsMouseOver�	 True.a���  � ��8  �� " ��.���  � ��
 ���� ��  � ��
 ���� ��  � ��$ Center=���  � �� �� "
 ��.R��� $ border��#��z��#��z�� . #��z��#��z��$��0q�$ 0q�$ 0,0,0,0��._��� $ innerBorder�� . $��1q�$ 2q�$ 0,0,0,0��._��� # z #��z��#��z����. #��z��    
shadow��$ 0Q�$	 0.7Q�$ 0Q�z�T� translation��$ 0Q�$ 0Q� P�  �@J�IsKeyboardFocused . . ��� $ innerBorder�� � ��
 ���� ��  � ��
 ���� P�  �@J�IsMouseOver . . ���  � ��
 ���� P�  � {� .  . ���  �@J�Opacity$	 0.5Q�P�  � �� .  �� .���� .��W� $ 0:0:0D�$ 0X�$ shadow��$$ (DropShadowEffect.ShadowDepth)�W� $ 0:0:0D�$ 0X�$ translation��$ (TranslateTransform.X)�W� $ 0:0:0D�$ 0X�$ translation��$ (TranslateTransform.Y)� �� .���� .��W� $ 0:0:0D�$ 0X�$ shadow��$$ (DropShadowEffect.ShadowDepth)�W� $ 0:0:0D�$ 0X�$ translation��$ (TranslateTransform.X)�W� $ 0:0:0D�$ 0X�$ translation��$ (TranslateTransform.Y)��� " ��.���  � ��
 ���� ��  � ��
 ���� ��  � ��$ Center=���  � �� �� "
 ��.R��� $ border��#��z��#��z�� . #��z��#��z��$��1q�$ 0q�$ 0,0,0,0��._��� $ innerBorder�� . $��1q�$ 2q�$ 0,0,0,0��._��� # z #��z��#��z����. #��z��    
shadow��$ 0Q�$	 0.7Q�$ 0Q�z�T� translation��$ 0Q�$ 0Q� P�  �@J�IsKeyboardFocused . . ��� $ innerBorder�� � ��
 ���� ��  � ��
 ���� P�  �@J�IsMouseOver . . ��� 8    � ��P�  � {� .  . ���  �@J�Opacity$	 0.5Q�P�  � �� .  �� .���� .��W� $ 0:0:0D�$ 0X�$ shadow��$$ (DropShadowEffect.ShadowDepth)�W� $ 0:0:0D�$ 0X�$ translation��$ (TranslateTransform.X)�W� $ 0:0:0D�$ 0X�$ translation��$ (TranslateTransform.Y)� �� .���� .��W� $ 0:0:0D�$ 0X�$ shadow��$$ (DropShadowEffect.ShadowDepth)�W� $ 0:0:0D�$ 0X�$ translation��$ (TranslateTransform.X)�W� $ 0:0:0D�$ 0X�$ translation��$ (TranslateTransform.Y)��� "  .���  � ��
 ���� ��  �@ SelectionMode$ Single=���  � ��$ 0q���  �@ GridLinesVisibility$
 None=���  �@ CanUserAddRows .  ��  �@ CanUserReorderColumns .  ��  �@ AutoGenerateColumns .  ��  �@ CanUserDeleteRows .  ��  �@ CanUserResizeRows .  ��  �@ CanUserResizeColumns .  ��  �@ RowHeaderWidth$ 0Q���  �@ RowStyle# � - ��  �@ ColumnHeaderStyle# � .  ���� '        "  .���  � ��$ 0q���  �@�FocusVisualStyle Z� �� "  .���  � ��8   ��  � ��$ 0,0,0,1q� ���� 8   (��       * SystemColors.HighlightBrushKey+)�� $  Transparent��(��       *1/SystemColors.InactiveSelectionHighlightBrushKey+)�� $  Transparent��(��       *53SystemColors.InactiveSelectionHighlightTextBrushKey+)�� "  .���  � ��
 ���� ��  � ��$	 Top=���  � ��$ 
0,10,10,10q���  � ��$ 0q���  � ��$
 Left=���  � ��8   ��  � ��$ 14(��� " ��.���  � ��8   ��  � ��$ 2q���  �@�FocusVisualStyle Z� ��  � ��$
 Left=���  � ��$	 Top=���  � ��8  ��  � ��$ Center=���  � ��$
 Left=���  � ��$ 5,0,0,0q���  � ��$ 14(���  � ��$	 150����  � ��$ 25����  �@��TextWrapping$ NoWrap=���  � �� �� "
 ��.R��� $ Bd��#��z��#��z��#��z��$ 0��._��� $  PART_ContentHost�� P�  � {� .  . ��� # � ��$ Bd�� � ��P�  � ��$
 Auto��. ���  � ��$	 100��P�  � ��$
 Auto��. ���  � ��$ 20���� " ��8!   .���  � ��8  ��  � ��$ 1q���  �@�FocusVisualStyle Z� �� " ��8!   .���  � ��$ 35����  � ��
 ����  ��  ��  �� *Self+$ 	IsFocused�	 True.a���  � ��8  �� " ��.���  � ��8   ��  � ��$ 2q���  �@�FocusVisualStyle Z� ��  � ��$
 Left=���  � ��$	 Top=���  � ��8  ��  � ��$ Center=���  � ��$
 Left=���  � ��$ 5,0,0,0q���  � ��$ 14(���  � ��$	 150����  � ��$ 25����  � �� �� "
 ��.R��� $ Bd��#��z��#��z��#��z��$ 0��._��� $  PART_ContentHost�� P�  � {� .  . ��� # � ��$ Bd�� � ��P�  � ��$
 Auto��. ���  � ��$	 100��P�  � ��$
 Auto��. ���  � ��$ 20���� "  .���  � ��8   ��  � |� . ��  � ��$	 Top=���  � ��$	 Top=���  � ��$
 Left=���  �@ IsTodayHighlighted . ��  �@ SelectedDateFormat$ Short=���  � ��$ 0q���  � ��$ 0q���  � ��8  ��  � ��$ 2q���  � ��$ Stretch=���  � ��
 ���� ��  �@ CalendarStyle# � 4 ��  � �� �� "
  .R��� #��z��#��z��# z��#��z��$ 0��._�� $" 	PART_Root��#��z��#��z��#��z��# �� $��* ��� $
��Auto �.+��� $$ PART_Button��$��1��#��z��|�. $��Right=�#��z��$��Center=�$��0q�$��0q����� " ��8!  .���  � ��
 ���� .���� $% btnIcon��$��35��$	��Top=�$��0,5,10,5q����� " ��.���  � ��$ /img/calendar.png�� ��  �� $& PART_Button��$ IsMouseOver�	 True.a���  � ��$  /img/calendarHighlight.png��  $' PART_TextBox��$��0��#��z��#|�z|�$��Stretch=�$��Stretch=�#��z��$��Center=�$
��Left=�#��z��.��.������ "  .���  � ��# � ����  � ��# � ����  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� "
  .R�� ( ���� WatermarkBrush5 8   )   CommonStates��* 	  $+ 0D�	  $+ 0:0:0.1D�$, 	MouseOver��.- 
  
Normal��
  	MouseOver��.. �� .���� $ 0D�$/ TransparentX�$2 ,(Border.BorderBrush).(SolidColorBrush.Color)�$ ContentElement���� $ 0D�$/ TransparentX�$2 ,(Border.BorderBrush).(SolidColorBrush.Color)�$ watermark_decorator��  WatermarkStates��* 	  $+ 0D�.- 
  Unwatermarked��
  Watermarked��.. �� .��W� $ 0D�$ 0X�$ Opacity�$ ContentElement��W� $ 0D�$ 1X�$ Opacity�$ PART_Watermark��  FocusStates��* 	  $+ 0D�.- 
  	Unfocused��
  Focused��.. �� .��W� $ 0D�$ 1X�$ Opacity�$ FocusVisual��.+��� $ Border��#��z��#��z��#��z��$ 1��$0 1Q�# z��._�� $" WatermarkContent��#��z��#��z��.+��� $ ContentElement�����	#FFFFFFFF$��0q��� $ watermark_decorator�����	#FFFFFFFF$��0q�._��� $1 PART_Watermark��|�.  2 .  $0 0Q�#��z������ .R��� $��Execute date ... ��8�� �� $  PART_ContentHost��#��z��$��0q�#��z���� $ FocusVisual�����	#FF45D6FA$ 1��2 .  $0 0Q�.��.��� $" PART_DisabledVisual��$��2��$��0��2 .  $0 0Q�$��0��# �� $��* ��� $
��Auto �.+��� $��0�����	#A5FFFFFF$3 1��$��0��$4 1���� $��1�����	#A5FFFFFF$��18��$��3,0,3,0q�$3 1��$��0��$4 1��$��19��� $5 
PART_Popup��6 . $��Bottom=�7 .  8 �� $& PART_TextBox��
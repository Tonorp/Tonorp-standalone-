   M S B A M L   `   `   `  ����N  JTonorpStandAloneWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TonorpStandAloneWPF.PagesTonorpStandAloneWPF.Pages  5      P LTonorpStandAlone.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullhHclr-namespace:TonorpStandAlone.Core.Logic;assembly=TonorpStandAlone.CoreTonorpStandAlone.Core.Logic 5      -    'TonorpStandAloneWPF.Pages.NewEnrollment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:TonorpStandAloneWPF.Pages     5      ZlogicHclr-namespace:TonorpStandAlone.Core.Logic;assembly=TonorpStandAlone.Core     5      $	��600��5	      $
��1200��6     N� Title$  NewEnrollment��5
      .��5      �    SoftOffWhiteBrush#��[  6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   � $��0��6   $	��600��6     LightGrayWhiteBrush#��[ 5      .+�5      �� $(��"/Images/TonorpLogoAndTextUnder.png��6   $
��None=�5       J� Opacity$	 0.3Q�5      � 5      .+�5      �� #��[ 6   .+�5       ��   
HeaderText#��[ 6    $��CURRENT USER��5!        �� Padding$
 0 20q�5"         LatoBold#��[ 5#       A� 5&      $	��150��6   $	��150��6+   $
��0 20q�5'      ��5(      �� 5)       �� ImageSource$ /Images/LoggedInUser.png��6)   5+      �� 5.      $��	EZEKWUNEM��6    #��[ 5/         FontSizeRegular#��[ 50         FunnyBlueBrush#��[ 51       �� 54      $��Ejike��6    #��[ 55       #��[ 56       �� 59      $��UNN-009-0341��6    #��[ 5:       #��[ 5;       �� 5>      $'��!Applied Biology and Biotechnology��6    #��[ 5?       #��[ 5@       $
��0 20q�5A       �� 5D      $��	200 Level��6    #��[ 5E       #��[ 5F       5H      5J      5K      � 5N   
   $
��Auto��6   $��1��5O      $
��Auto��5P      $��
50 30 50 0q�5Q       � RowDefinitions 5R      �� 5S      $��40 �6    �� 5T      $
��Auto �6    �� 5U      $��* �6    .+�5Y      � $��0��6   .+�5\      �� -   5         ��Name$ EnrLabel��5\      $��Center=�5]      $?��9Enrollment started, Pls place your finger on the scanner!��5^      $��15(�5_        LatoRegular#��[ 5`      
������ #��[ 5b      $��Center=�5c      $
 20 5q�5d      �� 5g      -   5          IconButtonCornered#��[ 5g      $��Right=�5h      
������ $��2q�5j      $��0 5 30 0q�5k       � Cursor$
 Hand��5m      .��5o      �� $"��/Images/ChangeFingerIcon.png��6   $��30��5p      $��30��5q      $��Center=�5r      $��Center=�5s      5t      5u      � 5x      $��1��6    5y      �� 5z      $��2* �6'   �� 5{      $��* �6'   .+�5      � -   5        $��	WrapPanel��5       � Orientation$ 
Horizontal=�6-   $��0��5�      $��30 0 0 0q�5�      $	��420��5�      .+�5�      �� -   5        $��FingerThumbnail��5�   #   ��5�      �� 5�      .R�5�   "   � 5�      ��5�      �� 5�      .R�5�   "   �� -   5        $��10q�5�   )     SquareButton#��[ 5�   )   $	��120��5�   )   $	��150��65   $
 Hand��5�   )   
	 � Tag	 5�   )   �� *Id+.��5�   &   � .+�5�   *   �� $	��150��5�   0   ��5�   0   �� *	ImgPath+	 5�   0   �� *Id+�� 5�   *   #��[ 5�   ,   $��Bottom=�5�   ,   $��0 0 0 5q�5�   ,   ��5�   4   �� *Name+5�   ,   5�   '   5�   #   5�      5�      5�      �� 5�      $��1��6   $��-100 10 10 10q�6)   
 �� CornerRadius$
 5��5�      $	��200��5�      $	��325��6%    	 VeryLightGrayBrush#��[	 5�      $��1q�5�       
 LightGrayBrush#��[
 5�      ._�5�      � .+�5�      �� -   5        $��ThumbnailLarge��5�       $��/Images/HandAndDevice.png��5�       $	��150��5�       5�       5�      5�      5�      � 5�      $��2��6   .+�5�      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5�      $��
0 -70 83 0q�5�      .+�5�      �� $
 5��6   $	��100��5�      $��50��5�      $��1q�5�      #��[
 5�      ._�5�      �� -   5        $��LblPercentage��5�   $   $��0%��5�   $   $��Center=�5�   $   $��Center=�5�   $     ForegroundMainBrush#��[ 5�   $   #��[ 5�   $     FontSizeLarge#��[ 5�   $   5�      �� 5�      -   5        $��10 0 0 0q�5�        SearchButton#��[ 5�      $	��100��5�      $��50��6)   $
 Hand��5�      .��5�      �� $
��DONE��6$   #��[ 5�   $     LightGreenBrush#��[ 5�   $   5�      5�      5�      5�      5�      5�      
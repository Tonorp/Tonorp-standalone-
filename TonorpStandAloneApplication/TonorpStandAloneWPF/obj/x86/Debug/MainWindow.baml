   M S B A M L   `   `   `  ����N  JTonorpStandAloneWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TonorpStandAloneWPF.ValueConverter"TonorpStandAloneWPF.ValueConverter  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   P LTonorpStandAlone.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullhHclr-namespace:TonorpStandAlone.Core.Logic;assembly=TonorpStandAlone.CoreTonorpStandAlone.Core.Logic 5   	   $    TonorpStandAloneWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   KvalueConverter0clr-namespace:TonorpStandAloneWPF.ValueConverter     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	   ZlogicHclr-namespace:TonorpStandAlone.Core.Logic;assembly=TonorpStandAlone.Core     5   	   -   5          �Name$  	AppWindow��5   	    � Icon$# /Images/TonorpIconWhiteBg.png��5
   	    � WindowStyle$
 none=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   $	��550��5   	   $
��1020��6      WindowDefault#��[  5   	    � 
ResizeMode 5   	   �� *
ResizeMode+ � 	Resources 5       S� 
ObjectType0  *TonorpStandAlone.Core.Logic.ThumbnailImage S� 
MethodName  EnrlThumbnail	 S� MethodParameters��%r   &	       S� 5   
   "  6   $ GetThumbnailImage��5      	 5      ��5      1��6"   5      5      '  !System.Windows.Shell.WindowChrome
   WindowChrome
 5        5   
      GlassFrameThickness$ 0q�5"         CornerRadius$ 0��5#         ResizeBorderThickness 5       �� *ResizeBorderThickness+   CaptionHeight 5!      �� *TitleHeight+5#      .��5&      ��   SoftOffWhiteBrush#��[ 6   ._�5'   
   �  � RowDefinitions 5(      �� 5)      $��* �6    �� 5*      $
��Auto �6    ��5-      �� 5.       �� ImageSource$( "/Images/TonorpLogoAndTextUnder.png��6    j� Stretch$
 None=�6N    �� Opacity$	 0.5Q�6]   .+�51       � -   5          �Name$ 	MainFrame��51      $��0��52      
������ }�.   � NavigationUIVisibility$ Hidden=�55      ��51   '   �� *CurrentPage+ �� 	Converter F   @TonorpStandAloneWPF.ValueConverter.ApplicationPageValueConverter  55      �� 56      
���   �$��0��57      $��2��58       J� Opacity$	 0.6Q�59      y�5:      �� *IsWindowOverlayVisible+  BooleanToVisibilty# [ �� 5=      $��1��6   $��0 1 0 0q�5>        VeryLightGrayBrush#��[ 5?      ._�5@      � 
������  � ColumnDefinitions 5B      �� 5D      $
��Auto �6+   �� 5F      $��* �6+   �� 5H      $
��Auto �6+   .+�5L      �� $��0��6!    �� Orientation$ 
Horizontal=�5N      y�5M      �� *IsNetworkVisible+# [ .+�5Q      A� $��20��6"   $��20��5R      $��50 20 10 20q�5S      $
��Left=�5T      ��5U      �� 5V   "   -   5        NtwAvailableColor��5V   2   5X      �� 5[      -   5        $��NtwAvailableText��5[   $   $��Center=�5\        FontSizeSmall#��[ 5]        LatoRegular#��[ 5^        ForegroundMainBrush#��[ 5_      $��0 3 0 0q�5`   $   5a      �� 5d      $#��© Copyright, Tonorp ltd 2018��6   $
��Auto��5e      $��0��6'   $��3��5f      $��Center=�5g      $��0q�5h        
TextButton#��[ 5i      #��[ 5j       � Cursor$
 Hand��5k      �� 5n      $��Tenece Nig. ltd��6   $
��Auto��5p      $��2��6'   $��Right=�5q      $��0 0 50 0q�5r      #��[ 5s      #��[ 5t      $
 Hand��5u      y�5o      �� *IsClientLinkVisible+# [ 5u      5v      5w      5x      5y      5{      
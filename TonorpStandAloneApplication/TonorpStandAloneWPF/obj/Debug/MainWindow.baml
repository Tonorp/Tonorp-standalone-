   M S B A M L   `   `   `  ����N  JTonorpStandAloneWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TonorpStandAloneWPF.ValueConverter"TonorpStandAloneWPF.ValueConverter  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   P LTonorpStandAlone.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullhHclr-namespace:TonorpStandAlone.Core.Logic;assembly=TonorpStandAlone.CoreTonorpStandAlone.Core.Logic 5   	   $    TonorpStandAloneWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   KvalueConverter0clr-namespace:TonorpStandAloneWPF.ValueConverter     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	   ZlogicHclr-namespace:TonorpStandAlone.Core.Logic;assembly=TonorpStandAlone.Core     5   	   -   5          �Name$  	AppWindow��5   	    � Icon$# /Images/TonorpIconWhiteBg.png��5
   	    � WindowStyle$
 none=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   $	��550��5   	   $
��1020��6      WindowDefault#��[  5   	    � WindowState$ 	Maximized=�5   	    � 
ResizeMode 5   	   �� *
ResizeMode+'  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�5      	   CornerRadius$	 0��5      
   ResizeBorderThickness
 5      �� *ResizeBorderThickness+   CaptionHeight 5      �� *TitleHeight+5      .��5      ��   SoftOffWhiteBrush#��[ 6   ._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5       $
��Auto �6    ��5#      �� 5$       �� ImageSource$( "/Images/TonorpLogoAndTextUnder.png��6    j� Stretch$
 None=�6N    �� Opacity$	 0.5Q�6]   .+�5'       � -   5          �Name$ 	MainFrame��5'      $��0��5(      
������ }�.   � NavigationUIVisibility$ Hidden=�5+      ��5'   '   �� *CurrentPage+ �� 	Converter F   @TonorpStandAloneWPF.ValueConverter.ApplicationPageValueConverter  5+      �� 5,      
���   �$��0��5-      $��2��5.       J� Opacity$	 0.6Q�5/      y�50      �� *IsWindowOverlayVisible+  BooleanToVisibilty# [ �� 53      $��1��6   $��0 1 0 0q�54        VeryLightGrayBrush#��[ 55      ._�56      � 
������  � ColumnDefinitions 58      �� 5:      $
��Auto �6+   �� 5<      $��* �6+   �� 5>      $
��Auto �6+   .+�5B      �� $��0��6!    �� Orientation$ 
Horizontal=�5D      y�5C      �� *IsNetworkVisible+# [ .+�5G      A� $��20��6"   $��20��5H      $��50 20 10 20q�5I      $
��Left=�5J      ��5K      �� 5L   "   -   5        NtwAvailableColor��5L   2   5N      �� 5Q      -   5        $��NtwAvailableText��5Q   $   $��Center=�5R        FontSizeSmall#��[ 5S        LatoRegular#��[ 5T        ForegroundMainBrush#��[ 5U      $��0 3 0 0q�5V   $   5W      �� 5Z      $#��© Copyright, Tonorp ltd 2018��6   $
��Auto��5[      $��0��6'   $��3��5\      $��Center=�5]      $��0q�5^        
TextButton#��[ 5_      #��[ 5`       � Cursor$
 Hand��5a      �� 5d      $��Tenece Nig. ltd��6   $
��Auto��5f      $��2��6'   $��Right=�5g      $��0 0 50 0q�5h      #��[ 5i      #��[ 5j      $
 Hand��5k      y�5e      �� *IsClientLinkVisible+# [ 5k      5l      5m      5n      5o      5q      
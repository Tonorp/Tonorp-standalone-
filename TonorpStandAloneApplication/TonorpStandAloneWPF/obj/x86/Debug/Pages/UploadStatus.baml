   M S B A M L   `   `   `  ����N  JTonorpStandAloneWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TonorpStandAloneWPF.PagesTonorpStandAloneWPF.Pages  5      ,    &TonorpStandAloneWPF.Pages.UploadStatus   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:TonorpStandAloneWPF.Pages     5      $	��550��5      $
��1200��6   .��5      �    SoftOffWhiteBrush#��[  6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      � $��0��6   $��2��5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5       .+�5#      �� 
 � Tag$ Search Record��6   $��	0 30 0 15q�5$      $��30��5%      $	��350��5&      $��1q�5'      $��Center=�5(        FontSizeSmall#��[ 5)      �� 5,        SearchButton#��[ 6   $��40��5-      $��40��6%   $��3q�5.      $��
7 0 0 -15 q�5/       � Cursor$
 Hand��50      .��51      �� $��/Images/SearchIcon.png��6    $
��Fill=�6@   52      53      54      �� 56      $��1��6   $ 
Horizontal=�57      .+�5:      �� $��DELETE FILE��6   $��30��5;      $	��120��5<      $��Right=�5=        DeleteFileBtn#��[ 5>      $��0 20 0 0q�5?      $
 Hand��5@      �� 5C      $��	SYNC FILE��6   $��30��5D      $	��120��5E      $��Right=�5F        SyncFileBtn#��[ 5G      $��
20 20 50 0q�5H      $
 Hand��5I      5J      5K      � 5N   
   $��1��6   $
��50 0q�5O      .+�5R      �   5S      �� 5T      $
��Auto �6$   �� 5U      $��* �6$   .+�5Y      �� $��0��6   $	��0 1q�5Z        VeryLightGrayBrush#��[ 5[      ._�5]      � 
������� 5^      �� 5_      $��50 �6/   �� 5`      $	��300 �6/   �� 5a      $	��200 �6/   �� 5b      $	��200 �6/   �� 5c      $	��110 �6/   �� 5d      $	��110 �6/   �� 5e      $��* �6/   .+�5i      �� $��0��6$   $	��S/N��64   $��10q�5j       $
��Left=�5k         
HeaderText#��[ 5l         LatoBold#��[ 5m       �� 5p      $��1��6$   $��	FILE NAME��64   $��10q�5q       $
��Left=�5r       #��[ 5s       #��[ 5t       �� 5w      $��2��6$   $��DATE CREATED��64   $��10q�5x       $
��Left=�5y       #��[ 5z       #��[ 5{       �� 5~      $��3��6$   $��TIME CREATED��64   $��10q�5       $
��Left=�5�       #��[ 5�       #��[ 5�       �� 5�      $��4��6$   $��RECORDS��64   $��10q�5�       $
��Left=�5�       #��[ 5�       #��[ 5�       �� 5�      $��5��6$   $��UPLOADED��64   $��10q�5�       $
��Left=�5�       #��[ 5�       #��[ 5�       �� 5�      $��6��6$   $��	REMAINING��64   $��10q�5�       $
��Left=�5�       #��[ 5�       #��[ 5�       5�      5�      �� 5�      -   5         ��Name$ LvItems��5�   '   $��1��6   
������ $��0q�5�      ��5�      �� 5�      .R�5�      �  5�   "   �� 5�   &   $��50 �67   �� 5�   &   $	��300 �67   �� 5�   &   $	��200 �67   �� 5�   &   $	��200 �67   �� 5�   &   $	��110 �67   �� 5�   &   $	��110 �67   �� 5�   &   $��* �67   .+�5�   "   �� $��0��6,   #��[ 5�   ,   $
��Left=�5�   ,   $��10q�5�   ,   ��5�   ,   �� *SerialNumber+5�   ,   �� 5�   "   $��1��6,   #��[ 5�   ,   $
��Left=�5�   ,   $��10q�5�   ,   ��5�   ,   �� *
FileName+5�   ,   �� 5�   "   $��2��6,   #��[ 5�   ,   $
��Left=�5�   ,   $��10q�5�   ,   ��5�   ,   �� *DateCreated+5�   ,   �� 5�   "   $��3��6,   #��[ 5�   ,   $
��Left=�5�   ,   $��10q�5�   ,   ��5�   ,   �� *TimeCreated+5�   ,   �� 5�   "   $��4��6,   #��[ 5�   ,   $
��Left=�5�   ,   $��10q�5�   ,   ��5�   ,   �� *
NoOfRecord+5�   ,   �� 5�   "   $��5��6,   #��[ 5�   ,   $
��Left=�5�   ,   $��10q�5�   ,   ��5�   ,   �� *
NoUploaded+5�   ,   �� 5�   "   $��6��6,   #��[ 5�   ,   $
��Left=�5�   ,   $��10q�5�   ,   ��5�   ,   �� *NoRemaining+5�   ,   5�      5�      5�      5�      5�      5�      5�      
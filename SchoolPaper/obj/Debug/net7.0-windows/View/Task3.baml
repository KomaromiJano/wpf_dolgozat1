   M S B A M L   `   `   `  ����F  BSchoolPaper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchoolPaper.ViewSchoolPaper.View  5          SchoolPaper.View.Task3   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:SchoolPaper.View     5      .��5	      �� 
�������._�5
   
   �   � RowDefinitions  5      �� 5      $��75 �6    �� 5      �� 5      $	��120 �6     � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      $	��100 �6#   �� 5      $��* �6#   .+�5      �� $��Users��6   $��26(�5       �� Padding$
 0,19q�5      $
��0,10q�5      
���   �$��3��5      $��Center=�5      $��Stretch=�5       �� TextAlignment$ Center=�5      �� 5!      -   5         ��Name$ lbUsers��5!      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6'   $��25,0,0,0q�6L   $��1��6^   $��20(�6k   ��5"      �� 5#      .R�5$      �� 
������ $��5q�6:   ._�5%      ��  �� Orientation$ 
Horizontal=�6)   .+�5&   "   �� $��5q�6B   $
��Bold"�6M   ��6,   �� *Name+6M   �� 5'   "   $��5q�6A   ��6,   �� *Age+6A   �� 5(   "   $��5q�6I   ��6,   �� *Nationality+6I   �� 5)   "   $��5q�6H   ��6,   �� *
Profession+6H   �� 5*   "   $��5q�6G   ��6,   �� *	Interests+6G   5+      5,      5-      5/      �� 50      $��1��6   $��1��6&   $	��Top=�66   $��10 0 0 0q�6N   .+�51      �� $��Name: ��6   $
 0,10q�6*   $��6q�69   $��Center=�6D   �� 52      $��Age: ��6   $
 0,10q�6)   $��6q�68   $��Center=�6C   �� 53      $��Nationality: ��6   $
 0,10q�61   $��6q�6@   $��Center=�6K   �� 54      $��Profession: ��6   $
 0,10q�60   $��6q�6?   $��Center=�6J   �� 55      $��Interests: ��6   $
 0,10q�6/   $��6q�6>   $��Center=�6I   56      �� 58      -   5         ��Name$ spInput��58      $��1��6*   $��2��67   $��0 0 25 0q�6G   .+�59      �� $��Stretch=�60   $
��0 10q�6N   $��5q�6]   ��6   �� *Name+6]   �� 5:      $��Stretch=�6/   $
��0 10q�6M   $��5q�6\   ��6   �� *Age+6\   �� 5;      $��Stretch=�67   $
��0 10q�6U   $��5q�6d   ��6   �� *Nationality+6d   �� 5<      $��Stretch=�66   $
��0 10q�6T   $��5q�6c   ��6   �� *
Profession+6c   �� 5=      $��Stretch=�66   $
��0 10q�6T   $��5q�6c   ��6   �� *
Insterests+6c   5>      �� 5@      $��2��6   $��3��6'   $ 
Horizontal=�6;   $��Center=�5A      .+�5B      �� -   5         ��Name$	 Add��5B      $	��Add��69   $	��150��6G   $��20(�6S   $��20q�6a   
��� � �6n   �� 5C      -   5        $ Update��5C      $��Update��6>   $	��150��6O   $��20(�6[   $��20q�6i   
��� ���6u   �� 5D      -   5        $ Delete��5D      $��Delete��6>   $	��150��6O   $��20(�6[   $��20q�6i   
���**��6u   5E      5G      5H      5I      
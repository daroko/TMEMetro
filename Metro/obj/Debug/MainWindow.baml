   M S B A M L   `   `   `  ����@  <Metro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MetroMetro  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   'clr-namespace:Metro.Core
Metro.Core  5   	   3clr-namespace:Metro.PropertiesMetro.Properties  5   	       Metro.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Metro     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   )convclr-namespace:Metro.Core     5   	   ;Controls,http://metro.mahapps.com/winfx/xaml/controls  5	   	   =	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5
   	   &pclr-namespace:Metro.Properties  5   	   -   5        (  "MahApps.Metro.Controls.MetroWindow    ShowIconOnTitleBar  .  � WindowStartupLocation$ CenterScreen=�5   	      ShowTitleBar .  � Title$ TMEMetro��5   	   $	��750��5   	   $	��400��6   ��5   	   ��   Metro.Properties.Settings   Default �� Source# Z  �� Path$ Height� �� Mode$ TwoWay=���5   	   �� # Z $ Width�$ TwoWay=� � 	Resources 5      	 �� MergedDictionaries
 �� Source#   Metro.Core.StringIntConverter   StringIntConverter&    Metro.Core.EnumToStringConverter  EnumToStringConverter   BooleanToVisibilityConverter�� 5   
   	 5      �� 5      $ 
 Dictionaries\BaseSkin.xaml?�6%   %W   &	        &	      &	 &       5      6&     5      6)   �� 5      6+   5       .��5$      �  � RowDefinitions 5%   
   �� 5&      $
��Auto �6   �� 5'      $��* �6   �� 5(      $
��Auto �6   .+�5,   
   o� $��0��6   $��5q�5-      $
��Left=�5.      $��Stretch=�5/      .@�50      m� $��Szablony��6     AppThemeMenuItemStyle#��[ 51      ��52      �� *	AppThemes+$ OneWay=�m� 53      $��
Kolor okna��6     AccentColorMenuItemStyle#��[ 54      ��55      �� *AccentColors+$ OneWay=�56      � 59      $��1��6    5:      �� 5;      $
��Auto �6    �� 5<      $
��Auto �6    �� 5=      $
��Auto �6    �� 5>      $
��Auto �6    �� 5?      $
��Auto �6    �� 5@      $��* �6    .+�5C      �� $��0��6   ._�5D      �� -   5         ��Name$ label��5D   G     MahApps.Styles.Label#��[ 6   $-��'Numery z przedziału 1000000 do 9999999��6V   $
��Left=�6�   $��10q�6�   $	��Top=�6�   $	��411��6�   5E      �� 5F      $��1��6   ._�5G      � .+�5H      ��  �� Orientation$ 
Horizontal=�6!   .+�5I      �� -   5        $ 
infolabel2��5I   P   #��[ 6"   $$��Pozostało wolnych elementów:��6d   $
��Left=�6�   $��10,1,0,0q�6�   $	��Top=�6�   $	��180��6�   �� 5J      -   5        $ 
infolabel3��5J   P   #��[ 6"   $
��Left=�6�   $��1q�6�   $	��Top=�6�   $��80��6�   ��6d   �� *RemainedNumbers+$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5K      -   5        $ 
infolabel4��5K   P   #��[ 6"   $&�� Co stanowi zajętość tabeli w:��6d   $
��Left=�6�   $��1q�6�   $	��Top=�6�   $	��162��6�   �� 5L      -   5        $ 
infolabel5��5L   P   #��[ 6"    �� ContentStringFormat$ {0:0.####}%��6�   $
��Left=�6�   $��1q�6�   $	��Top=�6  $��80��6  ��6d   �� *RemainedPercent+$ OneWay=�$ PropertyChanged=�6  5M      5N      5O      �� 5Q      $��2��6   ._�5R      � .+�5S      �� $ 
Horizontal=�6!   .+�5T      �� -   5        $ label1��5T   P   #��[ 6"   $$��Ilość liczb do wygenerowania��6`   $
��Left=�6�   $��10q�6�   $	��Top=�6�   $	��165��6�   �� 5U      -   5         ��Name$ 
IloscLiczb��5U   R     MahApps.Styles.TextBox#��[ 6"   $
��Left=�61  $��23��6L  $��10q�6X   �� TextWrapping$
 Wrap=�6d  $	��Top=�6y  $	��120��6�  {�6f   �� *ProgressBlock+$ OneWay=�$ PropertyChanged=���6�   �� *Ilosc+$ TwoWay=�$ PropertyChanged=� �� 	Converter# [  6�  �� 5V      -	   5         ��Name$ button��5V   �     MahApps.Styles.Button#��[ 6"   $��Generuj��6�   $
��Left=�6�   $��10q�6	  $	��Top=�6  $��75��6-  ��6Q   �� *GenerateNumber+{�6u   �� *ProgressBlock+$ OneWay=�$ PropertyChanged=�6-  �� 5W      -
   5        $ 	czaslabel��5W   P   #��[ 6"   $ ��Czas wykonania w sekundach��6c   $
��Left=�6�   $��10q�6�   $	��Top=�6�   $	��165��6�   �� 5X      -   5        $
 czas��5X   R   #��[ 6"   {�.  $
��Left=�6�   $��23��6�   $��10q�6�   $
 Wrap=�6�   $	��Top=�6  $	��120��6   ��6r   �� *timeelapsed+$ OneWay=�$ PropertyChanged=�6   5Y      5Z      5[      �� 5]      $��3��6   ._�5^      � .+�5_      �� $ 
Horizontal=�6!   .+�5`      �� -   5        $ 
infolabel7��5`   P   #��[ 6"   $��
Ustawienia��6d   $
��Left=�6y   $��10,0,0,0q�6�   $	��Top=�6�   $	��165��6�   5a      5b      5c      �� 5e      $��4��6   ._�5f      � .+�5g      �� $ 
Horizontal=�6!   .+�5h      �� -   5        $ 
infolabel8��5h   P   #��[ 6"   $!��Wyczyść tabele z numerami��6d   $
��Left=�6�   $��10,0,0,0q�6�   $	��Top=�6�   $	��165��6�   �� 5i      -   5        $ buttonWyczysc��5i   �   #��[ 6"   $��	Wyczyść��6�   $
��Left=�6�   $��10,0,0,0q�6  $	��Top=�6$  $��75��6<  ��6Q   �� *ClearTableNumber+{�6w   �� *ProgressBlock+$ OneWay=�$ PropertyChanged=�6<  5j      5k      5l      �� 5m      $��5��6   $��0,10,0,0q�6"   ._�5n      � .+�5o      �� $ 
Horizontal=�6!   .+�5p      �� -   5        $ infolabel90��5p   P   #��[ 6"   $��Wypełnij tabele w 99%��6e   $
��Left=�6�   $��10,0,0,0q�6�   $	��Top=�6�   $	��165��6�   �� 5q      -   5        $ buttonzapełnij��5q   �   #��[ 6"   $��	Wypełnij��6�   $
��Left=�6�   $��10,0,0,0q�6  $	��Top=�6'  $��75��6?  ��6Q   �� *Generate99procent+{�6x   �� *ProgressBlock+$ OneWay=�$ PropertyChanged=�6?  5r      5s      5t      5y      �� 5}   
   $��2��6   .@�5~      �� .��6   TME.Test.App6*   �� 5       & "MahApps.Styles.Separator.StatusBar#��[ 6   �� 5�      .��5�      �� -   5        $ 
infolabel6��5�   H   #��[ 6   $
��Left=�6�   $��1q�6�   $	��Top=�6�   $��80��6  ��6\   �� *State+$ OneWay=�$ PropertyChanged=�# [ 6  5�      � 5�      .+�5�      � -   5         �Name$ pbStatus��5�   1    � IsIndeterminate .   � Maximum$	 100Q�5�   0    � Minimum$ 0Q�5�   0   $	��321��5�   0   $y�Visible=�5�   0   $��25��5�   0   $	��Top=�6<    � Value 5�   0   �� *Iloscp+$ OneWay=�$ PropertyChanged=�5�   <   �� 5�      $��Center=�6a   $��Center=�6~   ��6   ��  �� ElementName$ pbStatus��$ Value� �� StringFormat$ {0:0}%��6~   5�      5�      5�      5�      
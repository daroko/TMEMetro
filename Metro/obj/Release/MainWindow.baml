   M S B A M L   `   `   `  ���� @  <Metro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MetroMetro  T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 'clr-namespace:Metro.Core
Metro.Core  3clr-namespace:Metro.PropertiesMetro.Properties      Metro.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Metro     Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     )convclr-namespace:Metro.Core     ;Controls,http://metro.mahapps.com/winfx/xaml/controls  =	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  &pclr-namespace:Metro.Properties  -   (  "MahApps.Metro.Controls.MetroWindow    ShowIconOnTitleBar  .  � WindowStartupLocation$ CenterScreen=�   ShowTitleBar .  � Title$ TMEMetro��$	��750��$	��400������   Metro.Properties.Settings   Default �� Source# Z  �� Path$ Height� �� Mode$ TwoWay=����� # Z $ Width�$ TwoWay=� � 	Resources 	 �� MergedDictionaries
 �� Source#   Metro.Core.StringIntConverter   StringIntConverter&    Metro.Core.EnumToStringConverter  EnumToStringConverter   BooleanToVisibilityConverter�� 	 �� $ 
 Dictionaries\BaseSkin.xaml?�%-   &	        &	      &	 
         �� .���  � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+�o� $��0��$��5q�$
��Left=�$��Stretch=�.@�m� $��Szablony��  AppThemeMenuItemStyle#��[ ���� *	AppThemes+$ OneWay=�m� $��
Kolor okna��  AccentColorMenuItemStyle#��[ ���� *AccentColors+$ OneWay=�� $��1�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* �.+��� $��0��._��� -    ��Name$ label��  MahApps.Styles.Label#��[ $-��'Numery z przedziału 1000000 do 9999999��$
��Left=�$��10q�$	��Top=�$	��411���� $��1��._�� .+���  �� Orientation$ 
Horizontal=�.+��� -   $ 
infolabel2��#��[ $$��Pozostało wolnych elementów:��$
��Left=�$��10,1,0,0q�$	��Top=�$	��180���� -   $ 
infolabel3��#��[ $
��Left=�$��1q�$	��Top=�$��80������ *RemainedNumbers+$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -   $ 
infolabel4��#��[ $&�� Co stanowi zajętość tabeli w:��$
��Left=�$��1q�$	��Top=�$	��162���� -   $ 
infolabel5��#��[  �� ContentStringFormat$ {0:0.####}%��$
��Left=�$��1q�$	��Top=�$��80������ *RemainedPercent+$ OneWay=�$ PropertyChanged=��� $��2��._�� .+��� $ 
Horizontal=�.+��� -   $ label1��#��[ $$��Ilość liczb do wygenerowania��$
��Left=�$��10q�$	��Top=�$	��165���� -    ��Name$ 
IloscLiczb��  MahApps.Styles.TextBox#��[ $
��Left=�$��23��$��10q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��{��� *ProgressBlock+$ OneWay=�$ PropertyChanged=����� *Ilosc+$ TwoWay=�$ PropertyChanged=� �� 	Converter# [  �� -	    ��Name$ button��  MahApps.Styles.Button#��[ $��Generuj��$
��Left=�$��10q�$	��Top=�$��75������ *GenerateNumber+{��� *ProgressBlock+$ OneWay=�$ PropertyChanged=��� -
   $ 	czaslabel��#��[ $ ��Czas wykonania w sekundach��$
��Left=�$��10q�$	��Top=�$	��165���� -   $
 czas��#��[ {�.  $
��Left=�$��23��$��10q�$
 Wrap=�$	��Top=�$	��120������ *timeelapsed+$ OneWay=�$ PropertyChanged=��� $��3��._�� .+��� $ 
Horizontal=�.+��� -   $ 
infolabel7��#��[ $��
Ustawienia��$
��Left=�$��10,0,0,0q�$	��Top=�$	��165���� $��4��._�� .+��� $ 
Horizontal=�.+��� -   $ 
infolabel8��#��[ $!��Wyczyść tabele z numerami��$
��Left=�$��10,0,0,0q�$	��Top=�$	��165���� -   $ buttonWyczysc��#��[ $��	Wyczyść��$
��Left=�$��10,0,0,0q�$	��Top=�$��75������ *ClearTableNumber+{��� *ProgressBlock+$ OneWay=�$ PropertyChanged=��� $��5��$��0,10,0,0q�._�� .+��� $ 
Horizontal=�.+��� -   $ infolabel90��#��[ $��Wypełnij tabele w 99%��$
��Left=�$��10,0,0,0q�$	��Top=�$	��165���� -   $ buttonzapełnij��#��[ $��	Wypełnij��$
��Left=�$��10,0,0,0q�$	��Top=�$��75������ *Generate99procent+{��� *ProgressBlock+$ OneWay=�$ PropertyChanged=��� $��2��.@��� .��TME.Test.App��  & "MahApps.Styles.Separator.StatusBar#��[ �� .���� -   $ 
infolabel6��#��[ $
��Left=�$��1q�$	��Top=�$��80������ *State+$ OneWay=�$ PropertyChanged=�# [ � .+�� -    �Name$ pbStatus�� � IsIndeterminate .   � Maximum$	 100Q� � Minimum$ 0Q�$	��321��$y�Visible=�$��25��$	��Top=� � Value �� *Iloscp+$ OneWay=�$ PropertyChanged=��� $��Center=�$��Center=�����  �� ElementName$ pbStatus��$ Value� �� StringFormat$ {0:0}%��
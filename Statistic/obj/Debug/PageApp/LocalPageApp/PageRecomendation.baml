   M S B A M L   `   `   `  ����D  @Statistic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Statistic.PageApp.LocalPageAppStatistic.PageApp.LocalPageApp  5      6    0Statistic.PageApp.LocalPageApp.PageRecomendation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Statistic.PageApp.LocalPageApp     5      c _MaterialDesignThemes.MahApps, Version=3.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� Title$  PageRecomendation��5
       � 	Resources 5       �� 
TargetType %  !MaterialDesignFloatingHintTextBox �� BasedOn.  (MaterialDesignThemes.Wpf.ColorZoneAssist �� Property �� Value # MaterialDesignFilledPasswordBox  MaterialDesignLabel   MaterialDesignFlatDarkButton  MaterialDesignListView  MaterialDesignMenu  MaterialDesignMenuItem��%�  '��       7   'G� �     7  '�� �    7  '�� �    7  '�� �    7  '��     'o� ?    7  'm� \    7  �� 5   
   " ��6   8   .�5      ��  �@ Mode$ Standard=�6D   �� 5       � �� �	#FF234B6E6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ 5q�6'   5      �� 5   
   " G�6   8   .�5      ��  �@ Mode$ Standard=�6D   �� 5       � �� �	#FF234B6E6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6   8   .�5      ��  �@ Mode$ Standard=�6D   �� 5       � �� �	#FF234B6E6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ 16(�6)   �� 5        � ��$ 5q�6'   5!      �� 5"   
   " ��6   8   .�5#      ��  �@ Mode$ Standard=�6D   �� 5$       � �� �	#FF234B6E6+   �� 5%       � ��
 ���� 6+   �� 5&       � ��$ 16(�6)   �� 5'       � ��$ 5q�6'   5(      �� 5)   
   " ��6   8   .�5*      ��  �@ Mode$ Standard=�6D   �� 5+       � �� �	#FF234B6E6+   �� 5,       � �� �	#FF234B6E6,   �� 5-       � ��$ 5q�60   �� 5.       � ��
 ���� 6+   �� 5/       � ��$ 16(�6)   �� 50       � ��$ 5q�6'   51      �� 52   
   " ��6   .�53      ��  �@ Mode$ Standard=�6D   �� 54       � �� �	#FF234B6E6+   �� 55       � �� �	#FF234B6E6,   �� 56       � ��$ 5q�60   �� 57       � ��
 ���� 6+   �� 58       � ��$ 16(�6)   �� 59       � ��$ 5q�6'   5:      �� 5;   
   " o�6   8   .�5<      ��  �@ Mode$ Standard=�6D   �� 5=       � �� �	#FF234B6E6+   �� 5>       � �� �	#FF234B6E6,   �� 5?       � ��$ 1q�60   �� 5@       � ��
 ���� 6+   �� 5A       � ��$ 16(�6)   5B      �� 5C   
   " m�6   8   .�5D      ��  �@ Mode$ Standard=�6D   �� 5E       � �� �	#FF234B6E6+   �� 5F       � �� �	#FF234B6E6,   �� 5G       � ��$ 1q�60   �� 5H       � ��
 ���� 6+   �� 5I       � ��$ 16(�6)   5J      5K      .��5L      �  � ColumnDefinitions 5M   
   �� 5N      �� 5O      .+�5Q   
   �� .��5R      �� .+�5S      �� $-��'местные рекомендации��6    � ToolTip$7 1повседневные рекомендации��63   �� 5T      -   5         ��Name$ ListRec��5T      ��5U      �� 5V      .R�5W      �� $	��250��6%   .+�5X      �� 
���  ��$
��Wrap=�6S   ��6(   �� *Title+6S   �� 5Y      $
��Wrap=�6>   ��6(   �� *Info+6>   5Z      5[      5]      5^      5_      �� 5`   
   $��1��6   .��5a   
   �� -   5        	 ��Name$	 StackBig��5a      .+�5b      �� $+��%особые рекомендации��6   $S MРекомендации требующие денежных вложений��62   �� 5c      -   5        $ ListSpecRec��5c      ��5d      �� 5e      .R�5f      �� $	��250��6)   .+�5g      �� 
���  ��$
��Wrap=�6S   ��6(   �� *Title+6S   �� 5h      $
��Wrap=�6\   ��6)   �� *diskription+
 �� StringFormat$	
 {0}��6\   �� 5i      $
��Wrap=�6]   ��6(   �� *Price+$
 от {0:n0} Руб��6]   5j      5k      5m      5n      5o      5p      5q      
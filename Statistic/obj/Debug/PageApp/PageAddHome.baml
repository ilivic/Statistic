   M S B A M L   `   `   `  ����D  @Statistic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Statistic.PageAppStatistic.PageApp  5      #    Statistic.PageApp.PageAddHome   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Statistic.PageApp     5      c _MaterialDesignThemes.MahApps, Version=3.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� Title$  PageAddHome��5
       � 	Resources 5       �� 
TargetType %  !MaterialDesignFloatingHintTextBox �� BasedOn.  (MaterialDesignThemes.Wpf.ColorZoneAssist �� Property �� Value # MaterialDesignFilledPasswordBox  MaterialDesignLabel   MaterialDesignFlatDarkButton  MaterialDesignListView��%�  '��       7   'G� �     7  '�� �    7  '�� �    7  '�� �    7  '��     �� 5   
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
 ���� 6+   �� 58       � ��$ 16(�6)   �� 59       � ��$ 5q�6'   5:      5;      .��5<      �  � ColumnDefinitions 5=   
   �� 5>      �� 5?      $��8* �6   �� 5@       � RowDefinitions 5B   
   �� 5C      �� 5D      $��8* �6   �� 5E      .+�5G   
   �� $��1��6   $��1��6"   .+�5H      �� -   5         ��Name$ TxtTitle��5H      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Название��6(   �� 5I      -   5        $ 	TxtAdress��5I      $	 
Адрес��6)   �� 5J      -   5        
 ��Name$
 	CmbPeriod��5J      ��5K      �� 5L      .R�5M      �� ��6    �� *Title+5N      5P      �� 5Q       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5R      �� -   5        $��отмена��5R      
�������
�������6O   �� 5S      -   5        $��Добавить дом��5S      60   5T      5U      5V      5W      
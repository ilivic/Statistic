   M S B A M L   `   `   `  ����D  @Statistic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Statistic.PageAppStatistic.PageApp  5      !    Statistic.PageApp.PageLogin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Statistic.PageApp     5      c _MaterialDesignThemes.MahApps, Version=3.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� Title$  	PageLogin��5
       � 	Resources 5       �� 
TargetType %  !MaterialDesignFloatingHintTextBox �� BasedOn.  (MaterialDesignThemes.Wpf.ColorZoneAssist �� Property �� Value # MaterialDesignFilledPasswordBox  MaterialDesignLabel   MaterialDesignFlatDarkButton��%�  '��       7   'G� �     7  '�� �    7  '�� �    7  �� 5   
   " ��6   8   .�5      ��  �@ Mode$ Standard=�6D   �� 5       � �� �	#FF234B6E6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ 5q�6'   5      �� 5   
   " G�6   8   .�5      ��  �@ Mode$ Standard=�6D   �� 5       � �� �	#FF234B6E6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6   8   .�5      ��  �@ Mode$ Standard=�6D   �� 5       � �� �	#FF234B6E6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ 16(�6)   �� 5        � ��$ 5q�6'   5!      �� 5"   
   " ��6   8   .�5#      ��  �@ Mode$ Standard=�6D   �� 5$       � �� �	#FF234B6E6+   �� 5%       � ��
 ���� 6+   �� 5&       � ��$ 16(�6)   �� 5'       � ��$ 40q�6'   5(      5)      .��5*      �  � ColumnDefinitions 5+   
   �� 5,      �� 5-      $��4* �6   �� 5.       � RowDefinitions 50   
   �� 51      �� 52      $��4* �6   �� 53      .+�55   
   �� $��1��6   $��1��6"   .+�56      �� -   5         ��Name$ TxtLogin��56      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 
Логин��6(   G� 57      -   5        
 G�Name$
 TxtPassword��57      $	 Пароль��6/   �� 58       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�59      �� -   5        $��Регистрация��59      
��� � �
��� � �6V   �� 5:      -   5        $��Вход��5:      6(   5;      5<      5=      5>      
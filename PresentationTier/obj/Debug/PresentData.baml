   M S B A M L   `   `   `  ����K  GPresentationTier, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PresentationTierPresentationTier  5   	   "    PresentationTier.PresentData   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PresentationTier     5   	   .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid_showInfo��5      $��2��5      $��3��6   $��3��6,   $��10q�5      ��5   .   �� 5      �� 5    
   -   5         ��Name$ textBox_Test��5       $*��$Updated on date: MM/dd/yyyy HH:mm:ss��5!      $��2��5"      $��2��6      NormalTextBlock#��[  5#      �� 5%   
   -   5         ��Name$ button_Modify��5%      $��Modify��6(   $��3��5&      $��2��6     NormalButtons#��[ 5'      5(      �� 5*   
   -   5        $ button_Delete��5*      $��Delete��6(   $��4��5+      $��2��6   #��[ 5,      5-      5.      5/      
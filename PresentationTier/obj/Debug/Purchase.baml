   M S B A M L   `   `   `  ����K  GPresentationTier, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PresentationTierPresentationTier  5   	       PresentationTier.Purchase   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PresentationTier     5   	     N� Title$  Purchase��5   	   ��6   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$ ActualWidth���5      ��  �� *FindAncestor+" ��$ ActualHeight�.��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5       $��20 �6    � RowDefinitions 5#   
   �� 5$      $��20 �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   �� 5.      $
��Auto �6   �� 5/      $��* �6   �� 50      $��20 �6   .+�53   
   �� $��SUPLIERS��6      NormalLabel#��[  6#   $��2��54      $��2��6    $��2��6-   �� 56   
   $
��Name��6     NormalTextBlock#��[ 6    $��2��57      $��3��6$   �� 58   
   $��Contact name��6   #��[ 6(   $��2��59      $��4��6$   �� 5:   
   $��	Telephone��6   #��[ 6%   $��2��5;      $��5��6$   �� 5<   
   $��Address��6   #��[ 6#   $��2��5=      $��6��6$   �� 5>   
   $��Email��6   #��[ 6!   $��2��5?      $��7��6$   �� 5A   
   -   5         ��Name$ TextBoxName��5A        NormalTextBox#��[ 5B      $��3��69   $��3��6I   �� 5C   
   -   5        $ TextBoxContactName��5C      #��[ 5D      $��3��69   $��4��6I   �� 5E   
   -   5        $ TextBoxTelephone��5E      #��[ 5F      $��3��69   $��5��6I   �� 5G   
   -   5        $ TextBoxAddress��5G      #��[ 5H      $��3��69   $��6��6I   �� 5I   
   -   5        $ TextBoxEmail��5I      #��[ 5J      $��3��69   $��7��6I   �� 5M   
   -   5         ��Name$ buttoInsert��5M      $��Insert��6&     NormalButtons#��[ 5N      $��3��68   $��8��6H   �� 5O   
   -   5        $ buttonShowList��5O      $��	Show List��6)   #��[ 5P      $��3��68   $��9��6H   �� 5Q   
   -   5        $ button_Back��5Q      $
��Back��6&   $��2��5R      $��10��6!   5S      5T      
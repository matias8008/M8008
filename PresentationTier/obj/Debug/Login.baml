   M S B A M L   `   `   `  ����K  GPresentationTier, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PresentationTierPresentationTier  5          PresentationTier.Login   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PresentationTier     5      -   5          N�Name$  LoginWindow��5      .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5       � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��WELCOME��6      NormalLabel#��[  6"   $��2��5      $��2��6    $��2��6-   $��Center=�5       �� 5"   
   -   5         ��Name$ labelUserName��5"      $��	User name��6+     NormalTextBlock#��[ 5#      $��Center=�5$      $��Center=�6-   $��2��5%      $��3��6    �� 5'   
   -   5        $ labelPassword��5'      $��Password��6+   #��[ 5(      $��Center=�5)      $��Center=�61   $��2��5*      $��4��6$   �� 5,   
   -   5         ��Name$ button��5,      $��Go��6!     NormalButtons#��[ 5-      $��2��5.      $��5��6    $��2��6-   �� 50   
   -   5         ��Name$ userTextBox��50        NormalTextBox#��[ 51      $��Center=�52      $��Center=�6/   $��3��54      $��3��6"   �� 56   
   -   5        $ Response��56      #��[ 57      $��3��58      $��6��6$   $��Center=�59      $��Center=�61   
���  ��$
��Bold"�5:   %   G� 5<   
   -   5         G�Name$ passwordBox��5<      $��5q�6+   $��30��66   $	��200��6B   $��3��5=      $��4��6    G� 	MaxLength$ 15��5>       G� PasswordChar$ *��6   $��Center=�5?      $��Center=�6*   5@      5A      5B      
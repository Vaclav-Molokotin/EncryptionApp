   M S B A M L   `   `   `  ����H  DEncryptionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:EncryptionApp.UIEncryptionApp.UI  5   	   !    EncryptionApp.UI.WndOptions   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:EncryptionApp.UI     5   	   -   5          � Title$/  )Шифрование - Настройки��5   	    � Icon$ /Resources/Assets/Ico.png��5	   	   $	��450��5
   	   $	��800��6   $	��450��5   	   $	��800��6    � WindowStartupLocation$ CenterOwner=�5   	    � WindowStyle$ 
ToolWindow=�5   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%
  '��       �� 5   
   " ��6   .�5      ��  � ��$	 200��6&   64   �� 5       � ��$ 30��6'   64   �� 5       � ��$ Technical Italic)�6+   6F   �� 5       � ��$ 10q�6'   64   �� 5       � ��$ 15(�6)   66   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��70 �6   6*   	 � ColumnDefinitions	 5   
   �� 5      6!   �� 5      6!   .+�5"   
   �� -   5        
 ��Name$
 TblCeusarShift��5"      $��10q�6,   $��Right=�68   $"Шифр Цезаря (сдвиг)6i   �� 5#   
   -   5         ��Name$ TbCeusarShift��5#   "   $��1��6   $
��Left=�69   $��Center=�6T   6�   �� 5%   
   -   5        $
 TblCharReplace��5%      $��1��6,   $��10q�69   $��Right=�6E   ;9Таблица замены символов (номер)6�   �� 5&   
   -   5        $ TbCharReplace��5&   /   $��1��6   $��1��6"   $
��Left=�6F   $��Center=�6a   6�   �� 5(   
   -   5         ��Name$ BtnOk��5(      $��2��6    $��2��64   $	��200��6A   .��6a   Сохранить6l   5)      5*      
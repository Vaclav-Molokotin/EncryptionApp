   M S B A M L   `   `   `  ����H  DEncryptionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EncryptionAppEncryptionApp  5   	       EncryptionApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:EncryptionApp     5   	     � Title$  Шифрование��5   	    � Icon$ /Resources/Assets/Ico.png��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   $	��450��5   	   $	��800��6   $	��450��5   	   $	��800��6   .��5      � -   5         �Name$ GridContainer��5       ���#D9D9D9 � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��50px �6   �� 5      $��* �6   �� 5      $
��30px �6   .+�5   
   �� -   5         ��Name$ TbxFrom��5      6G   �� 5   
   -   5         ��Name$ BorderCenterPanel��5   i   $��1��6    �� CornerRadius$ 15��6   
�������   BorderCenter#��[  6C   ._�5      �� -   5         ��Name$ SpCenterPanel��5   O   	 �� Orientation$	 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        
 ��Name$
 TblEncryptedText��5      '%Зашифрованный текст6K   �� 5      -   5         ��Name$ 
ImgReverse��5   5   $��Center=�6   $��/Resources/Assets/Ico.png��6I   6�   �� 5      -   5        $
 TblOriginalText��5      %#Оригинальный текст6I   5      5      �� 5   
   -   5        $ TbxTo��5      $��2��6    �� 
IsReadOnly . 6B   �� 5!   
   -	   5        $ SpCurrEncrypt��5!   ;   $	 
Horizontal=�6   $��3��6.   $
��Left=�6R   .+�5"      �� $��10,0,0,0q�6   &$Текущее шифрование:6?   �� 5#      -
   5         ��Name$ CmbxCurrentEncryption��5#       �� SelectedIndex$ 1��66   $��4(�6H   6�   5$      �� 5&   
   $	 
Horizontal=�6   $��3��6.   $��Right=�6;   .+�5'      �� -   5         ��Name$ 
BtnOptions��5'      .��6B   Настройки6M   �� 5(      -   5        $ BtnOpenFile��5(      .��6D   Открыть файл6R   �� 5)      -   5        $ BtnSaveToFile��5)      .��6H    Сохранить в файл6Z   5*      5+      5,      
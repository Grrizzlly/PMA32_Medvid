   M S B A M L   `   `   `  ����  Course_project    Course_project.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $��900.149��6)   .��5      � $��0,0,-8,0q�6    � ColumnDefinitions 5   
   �� 5      $
��863* �6   �� 5      $	��27* �6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ workersGrid��5   /      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Інформація��6E      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Unemployer+6Y     5      $ Професія��6C   $	 110 6U    6%   �� *	profesion+6U     5      $ Освіта��6C   $ 70 6S    6%   �� *	education+6S     5      $ Вимоги��6F   $ 70 6V    6%   �� *requirements+6V     5      $ Посада��6>   $ 70 6N    6%   �� *Post+6N     5      $. (Попереднє місце праці��6G   $	 150 6f    6%   �� *Previos_place+6f     5      $+ %Причина звільненння��6B   $	 140 6_    6%   �� *
Whyfired+6_     5      $ Контакти��6B   $ 70 6T    6%   �� *
Contacts+6T   5      �� 5   
   $��Center=�6   $��1��63   	 �� Orientation$	 
Horizontal=�6@   $��22��6Y   $��390,0,363.164,0q�6e   $	��Top=�6~   .+�5      �� -   5        
 ��Name$
 updateButton��5      $��Обновить��6+   6>   �� 5      -   5        $
 deleteButton��5      $��Удалить��6+   6=   5      5       5!      
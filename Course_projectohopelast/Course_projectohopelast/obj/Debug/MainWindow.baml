   M S B A M L   `   `   `  ����R  NCourse_projectohopelast, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Course_projectohopelastCourse_projectohopelast  5   	   (    "Course_projectohopelast.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7local%clr-namespace:Course_projectohopelast     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $��786.194��6)    � 	Resources 5      -   'Course_projectohopelast.workersDataSet1   workersDataSet1  tableViewSource �� Source �� Source��%V   &	        &	      7     5   
   6    �� 5   
    67   �� *Table+8   5	      .��5
      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ tableDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��10,10,586,138q�6}      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6e   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��5   N      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Id+6l     5      -   5        profesionColumn��$
 	Profesion��5   \   $ SizeToHeader 6o    6>   �� *	Profesion+6o     5      -   5        requirementsColumn��$
 Requirements��5   b   $ SizeToHeader 6x    6A   �� *Requirements+6x   5      � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��
376,72,0,0q�69   $	��Top=�6M    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $	��Id:��6   $��0��6"   $
��Left=�62   $��3q�6M   $��0��6X   $��Center=�6e   �� 5      -   5         ��Name$ 	idTextBox��5      $��1��6)   $
��Left=�69   $��23��6T   $��3q�6`   $��0��6k   $��Center=�6�   $	��120��6�   ��6x   �� *Id+ �� Mode$ OneWay=�6�   �� 5      $��
Profesion:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��1��6_   $��Center=�6l   �� 5      -   5        $ profesionTextBox��5      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��1��6r   $��Center=�6�   $	��120��6�   ��6   �� *	Profesion+$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   �� 5       $��Requirements:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��2��6b   $��Center=�6o   �� 5!      -	   5        $ requirementsTextBox��5!      $��1��63   $
��Left=�6C   $��23��6^   $��3q�6j   $��2��6u   $��Center=�6�   $	��120��6  ��6�   �� *Requirements+$ TwoWay=� .  . 6  5"      5$      5%      
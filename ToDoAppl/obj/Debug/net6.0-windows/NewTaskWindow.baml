   M S B A M L   `   `   `  ����C  ?ToDoAppl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoApplToDoAppl  5   	       ToDoAppl.NewTaskWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ToDoAppl     5   	     � Title$  Нова задача��5   	   $	��350��6   $	��300��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��60 �6   .+�5   
   �� $��1��6   $��
12,0,12,12q�6"   �� 5   
   -   5         ��Name$ 
SaveButton��5      $��Зберегти��6%   $
��Left=�68   $��	32,28,0,0q�6S   $	��Top=�6f   $��1��6~   6�   �� 5   
   -   5        $ CancelButton��5      $��Відміна��6'   $
��Left=�69   $��32,3,0,0q�6T   $	��Top=�6f   $��1��6~   6�   �� 5   
   $��12,12,12,12q�6   .+�5      �� $
��Wrap=�6   $��0,0,0,4q�6,   �� 6>    � Language$ uk-ua�6B   $�Назва задачі��6S   6j   �� 5      -   5         ��Name$ NameTextBox��5       �� TextWrapping$
 Wrap=�6+   $	��200��6?   $
��Left=�6K   $��0,0,0,8q�6f   �� 5      -   5         ��Name$ IsCompletedCheckBox��5      $#��Задача виконана��64   $��0,0,0,8q�6N   �� 5      $
��Wrap=�6   $��0,0,0,4q�6,   �� 6>   $ uk-ua�6B   $�Опис задачі��6S   6i   �� 5      -   5        $ DescriptionTextBox��5      $
 Wrap=�62   $	��200��6F   $
��Left=�6R    �� AcceptsReturn$
 True��6m   $��71��6�   5      5      5      
   M S B A M L   `   `   `  ����E  ABlogReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BlogReader
BlogReader  5   	       BlogReader.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BlogReader     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6    K� ZIndex$
 1000��6.   .+�5      �� $��Select blog to read:��6   $��Center=�64   $��2q�6O   �� 5      $��10,0,0,0q�65    �� DisplayMemberPath$ Model.BlogTitle��6G   $	��170��6k   ��6   �� *Blogs+ �� SelectedItem 6w   �� *SelectedBlog+ �� Mode$ TwoWay=�5      �� 5      $
��Undo��6   $��6,2,2,2q�6D   ��6$   �� *UndoCommand+6D   �� 5      $
��Redo��6   $��2q�6D   ��6$   �� *RedoCommand+6D   �� 5      y�6   �� *IsSelectedBlog+.+�5      9� $��10,0,0,0q�6   $��Center=�6-    9� ExpandDirection$
 Down=�6H   $��Blog Information��6_      bloggerTemplate#��[  5      ��6N   �� *SelectedBlog.Blogger+5      5      5      �� 5   
     blogTemplate#��[ 6:   $��1��6j   $��2,10,2,2q�6�   ��6   �� *SelectedBlog+y�6w   �� *IsSelectedBlog+6�   5      5      
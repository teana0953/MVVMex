   M S B A M L   `   `   `  ����E  ABlogReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BlogReader.ViewsBlogReader.Views  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   commentTemplate  � RowDefinitions �� Orientation �� StringFormat  blogPostTemplate 9� ExpandDirection �� Padding  blogTemplate�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      (localclr-namespace:BlogReader.Views  5      %�  &	        &	 �    7   &	 �    7  �� 5      .R�5   
   � $	��2,8q�6     5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5
      �� $ 
Horizontal=�6   .+�5      �� ��6   �� *
Model.When+$ d���� 5      $��10,0,0,0q�6   $
��Bold"�6^   ��6.   �� *Name+$ 	From: {0}��6^   5      �� 5      $��1��6   $
��Wrap=�6;   ��6%   �� *Text+6;   5      5      �� 5      .R�5   
   � ���	#b0dddddd$
��2,10q�6&     5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $ 
Horizontal=�6   .+�5      �� $
��Bold"�63   ��6   �� *Title+63   �� 5      $��10,0,0,0q�6   $��Italic$�6c   ��6.   �� *
Model.When+$ ({0})��6c   5      �� 5      $��1��6   $��0,10,0,0q�6;   $
��Wrap=�6M   ��6%   �� *Text+6M   9� 5      $��2��6   $
 Down=�6$   ��5      �� 5      $ 
Horizontal=�6!   .+�5       �� $��Comments��6$   �� 5!      $��20,0,0,0q�6!   $��New Comment��63   ��6I   �� *NewCommentCommand+5"      .��5$      �� 
����  �$��2q�6,   $ 2q�6@   $��2q�6L   ._�5%      �� 8��  ��6#   �� *Model.Comments+6J   5&      5'      5(      5)      �� 5*      .R�5+   
   � 
�������  5,      �� 5-      $
��Auto �6    �� 5.      .+�50      �� $ 
Horizontal=�6   .+�51      �� $
��Bold"�6=   ��6   �� *Model.BlogTitle+6=   �� 52      $��20,0,0,0q�6   $��New Post��6+   ��6>   �� *NewPostCommand+53      �� 54      $��1��6   $��4q�6(   $
��Auto=�63   .��55      �� 8��  $��Stretch=�6n   ��6   �� *Posts+6n   56      57      58      59      
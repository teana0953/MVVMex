   M S B A M L   `   `   `  ����  
BlogReader$    BlogReader.Views.NewPostWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  New Post��5   	   $	��250��6   $	��350��6'   $��14(�63   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5	      $
��Auto �6   .+�5   
   ]� .+�5      �� $��Title:��6   $
��Left=�6&   $��Center=�6<   �� 5      $��10,0,0,0q�6   ��6(   �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $��4q�6   $��1��6    �� AcceptsReturn . ��6?   �� *Text+$ PropertyChanged=�A� 5   
    A� Rows$ 1��6    A� Columns$ 2��6   $��2��6+   $��2,10,2,2q�68   .+�5      �� -   5        $��Right=�5      $	��6,0q�61   $��50��6>   $��OK��6h    �� 	IsDefault . {�6I   �� *
IsPostOK+5   &   �� 5      $
��Left=�6   $	��6,0q�60   $��50��6=   $��Cancel��6H    �� IsCancel . 6Y   5      5      5      
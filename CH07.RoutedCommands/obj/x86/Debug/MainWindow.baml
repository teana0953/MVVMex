   M S B A M L   `   `   `  ����N  JCH07.RoutedCommands, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CH07.RoutedCommandsCH07.RoutedCommands  5   	   $    CH07.RoutedCommands.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   3local!clr-namespace:CH07.RoutedCommands     5   	     � Title$  Image Viewer��5   	   $	��350��6   $	��525��6+   .��5      �  � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      .+�5   
   c� $��14(�6   .@�5      �� $��Open...��6   $��6q�6P   ��6'   �� *OpenImageFileCommand+6P   �� 5      $��Zoom In��6   $��ZoomIn��6G   $��6q�6a   ��6'   �� *ZoomCommand+6a   �� 5      $��Zoom Out��6   $��ZoomOut��6H   $��6q�6c   ��6(   �� *ZoomCommand+6c   �� 5      $��Normal��6   $��
ZoomNormal��6F   $��6q�6d   ��6&   �� *ZoomCommand+6d   5      �� 5   
   $��1��6   $
��Auto=�6$   $
��Auto=�6I   .��5      �� $
��None=�61   ��6   �� *	ImagePath+ � LayoutTransform 5      �� 5       �� ScaleX 6%   �� *Zoom+ �� ScaleY 6=   �� *Zoom+5      5      5      5      
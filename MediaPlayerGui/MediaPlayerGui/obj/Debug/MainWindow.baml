   M S B A M L   `   `   `  ����I  EMediaPlayerGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MediaPlayerGuiMediaPlayerGui  5   	   3    -MediaPlayerGui.AudioVideoPlayerCompleteSample   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /customclr-namespace:MediaPlayerGui     5   	     � Title$  Media Player��5   	   $	��300��6   $	��300��6+   $	��300��5   	   $��95��6    � SizeToContent$ WidthAndHeight=�6'   
������� � Icon$ images\media.png��6]    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Open��5      6Y     5	   
   -   5        $ MediaCommands.Play��5	      6S     5
   
   -   5        $ MediaCommands.Pause��5
      6U     5   
   -   5        $ MediaCommands.Stop��5      6S   .��5      � -   5         � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   !   MediaPlayerGui.ColorControl  r� 5   
   -   5        $��mediaPlayer��5      $��1��6*    r� LoadedBehavior$ Manual=�67    r� Stretch$
 None=�6O   �� 5   
   $��2��6   ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5      $��* �6/   �� 5      $
��Auto �6/   5      5       .@�5"      �� .��5#      �� -   5        $��lblProgressStatus��5#      
���   �$��14(�6H   $
��Bold"�6V   
00:00:006r   5$      �� 5%      $��1��6   $��Stretch=�6,   .��5&      �� -   5        $��sliProgress��5&      ���	#FFFF58F0���	#FFF438FD���	#FFA6FF98	 J� OpacityMask
	 �  ��6�   5'      �� 5(      $��2��6   ��6,   Z� .��5)      � -	   5        $��pbVolume��5)      $��50��6.   $��12��69   
 � Maximum$
 1Q�6E   ���	#CCFF4949 � ToolTip$ Scroll For Volume��6�   ���	#FFD4D4D4 � Value 6Q   ��  �� ElementName$ mediaPlayer�� �� Path$ Volume�6�   5*      5+      5,      5-      
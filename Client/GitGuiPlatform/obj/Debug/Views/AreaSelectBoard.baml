   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5       GitGuiPlatform/   )Cafe.GitGuiPlatform.Views.AreaSelectBoard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5         Local_EachStackPanel �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  Local_NoticeText��%  &	        &	 2    �� 5	   
   " ��6-   .�5
      ��  � ��$ 60��6'   �� 5       � ��$	 120��6&   �� 5       �@��Orientation$ 
Horizontal=�6,   �� 5       � ��$	 Top=�62    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 � � �63   5      5      �� 5   
   " ��6)   .�5      ��  � ��
 �����6+   �� 5       � ��$ 20,0,0,0q�6'   �� 5       � ��$
 auto��6&   �� 5       � ��$ 16(�6)   �� 5       � ��$ Arial)�6+   �� 5       �@J�Opacity$ 10Q�6(   �� 5       � ��$ Center=�62   5      5      .��5      � $	��324��6   $	��576��5      ���	#FF6F6969.+�5!   
   �� $	��300��6   $	��381��5"      $��	12,57,0,0q�5#      $
��Left=�5$      $	��Top=�5%      .+�5E      � $	��290��6   $
��Left=�5F      $��Center=�5G       � Orientation$ 
Horizontal=�5H      .+�5I      �� $��3,5,18,0q�6   
�������$��2q�5K      ._�5L      �� -   5        $��m_ShangHaiArea��5L   !   #��[  67   .   (System.Windows.Interactivity.Interaction   Triggers 5M      /   )System.Windows.Interactivity.EventTrigger  5N      	   	EventName$	 	MouseDown��6-   .   (System.Windows.Interactivity.TriggerBase
   Actions.
 5O   "   6   0System.Windows.Interactivity.InvokeCommandAction     CommandParameter$ ShangHai��6^      Command 68   �� *SelectAreaCommand+6^   5P      .+�5R      �� #��[ 6$   $��ShangHai��6N   5S      5T      �� 5U      $��3,5,18,0q�6   
�������$��2q�5W      ._�5X      �� -   5        $��m_GuangZhouArea��5X   !   #��[  68    5Y        5Z      $	 	MouseDown��6-   .
 5[   "     $ 	GuangZhou��6^    68   �� *SelectAreaCommand+6^   5\      .+�5^      �� #��[ 6$   $��	GuangZhou��6N   5_      5`      �� 5a      $��3,5,18,0q�6   
�������$��2q�5c      ._�5d      �� -   5        $��m_BeiJingArea��5d   !   #��[  66    5e        5f      $	 	MouseDown��6-   .
 5g   "     $ BeiJing��6^    68   �� *SelectAreaCommand+6^   5h      .+�5j      �� #��[ 6$   $��BeiJing��6N   5k      5l      �� 5m      $��3,5,18,0q�6   
�������$��2q�5o      ._�5p      �� -   5        $��m_HeNanArea��5p   !   #��[  64    5q        5r      $	 	MouseDown��6-   .
 5s   "     $ HeNan��6^    68   �� *SelectAreaCommand+6^   5t      .+�5v      �� #��[ 6$   $��HeNan��6N   5w      5x      �� 5y      $��3,5,18,0q�6   
�������$��2q�5{      ._�5|      �� -   5        $��m_HeBeiArea��5|   !   #��[  64    5}        5~      $	 	MouseDown��6-   .
 5   "     $ HeBei��6^    68   �� *SelectAreaCommand+6^   5�      .+�5�      �� #��[ 6$   $��HeBei��6N   5�      5�      �� 5�      $��3,5,18,0q�6   
�������$��2q�5�      ._�5�      �� -   5        $��m_LondonArea��5�   !   #��[  65    5�        5�      $	 	MouseDown��6-   .
 5�   "     $ London��6^    68   �� *SelectAreaCommand+6^   5�      .+�5�      �� #��[ 6$   $��London��6N   5�      5�      �� 5�      $��3,5,18,0q�6   
�������$��2q�5�      ._�5�      �� -   5        $��m_ChengDuArea��5�   !   #��[  66    5�        5�      $	 	MouseDown��6-   .
 5�   "     $ ChengDu��6^    68   �� *SelectAreaCommand+6^   5�      .+�5�      �� #��[ 6$   $��ChengDu��6N   5�      5�      �� 5�      $��3,5,18,0q�6   
�������$��2q�5�      ._�5�      �� -   5        $��m_ShenZhenArea��5�   !   #��[  67    5�        5�      $	 	MouseDown��6-   .
 5�   "     $ ShenZhen��6^    68   �� *SelectAreaCommand+6^   5�      .+�5�      �� #��[ 6$   $��ShenZhen��6N   5�      5�      5�      5�      5�      5�      
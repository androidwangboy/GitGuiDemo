   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5       GitGuiPlatform+   %Cafe.GitGuiPlatform.Views.GenderBoard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5         Local_EachStackPanel �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value  Local_NoticeText��%�  &	        &	 �    �� 5	   
   " ��6-   .�5
      ��  � ��$ 60��6'   �� 5       � ��$	 250��6&   �� 5       �@��Orientation$ 
Horizontal=�6,   �� 5       � ��$	 Top=�62    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 � � �63   5      P� 5       �@J�	IsFocused . . �5      ��  � ��
 � � �63   5      5      �� 5   
   " ��6)   .�5      ��  � ��
 �����6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ Arial)�6+   �� 5       �@J�Opacity$ 10Q�6(   �� 5       � ��$ Center=�62   5      5      .��5      � $	��324��6   $	��576��5       ���	#FF6F6969.+�5"   
   �� $	��254��6   $	��237��5#      $��
35,204,0,0q�5$      $
��Left=�5%      $	��Top=�5&      .+�5'      �� 
�������$��2q�6)   ._�5(      �� -   5        $��m_NotSpePanel��5(      #��[  62   .   (System.Windows.Interactivity.Interaction   Triggers 5)      /   )System.Windows.Interactivity.EventTrigger  5*         	EventName$ MouseLeftButtonDown��6)   .   (System.Windows.Interactivity.TriggerBase	   Actions.	 5+      6   0System.Windows.Interactivity.InvokeCommandAction  
   CommandParameter$
 
NOTSPECIED��6\      Command 64   �� *SelectGenderCommand+6\   5,      .+�5.      �� $��70,0,0,0q�6    #��[ 5/       $��
NOTSPECIED��50       51      52      �� 53      
�������$��2q�6)   ._�54      �� -   5        $��m_Famale��54      #��[  6-    55        56      $ MouseLeftButtonDown��6)   .	 57        $
 FAMALE��6\    64   �� *SelectGenderCommand+6\   58      .+�5:      �� $��86,0,0,0q�6    #��[ 5;       $��FAMALE��5<       5=      5>      �� 5?      
�������$��2q�6)   ._�5@      �� -   5        $��m_Male��5@      #��[  6+    5A        5B      $ MouseLeftButtonDown��6)   .	 5C        $

 MALE��6\    64   �� *SelectGenderCommand+6\   5D      .+�5F      �� $��92,0,0,0q�6    #��[ 5G       $
��MALE��5H       5I      5J      5K      5L      5M      
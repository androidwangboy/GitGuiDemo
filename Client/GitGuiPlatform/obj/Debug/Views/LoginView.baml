   M S B A M L   `   `   `  ����K  GGitGuiPlatform, Version=2.0.1.182, Culture=neutral, PublicKeyToken=null]3clr-namespace:Cafe.GitGuiPlatform.ViewModels.Helper%Cafe.GitGuiPlatform.ViewModels.Helper  5      )    #Cafe.GitGuiPlatform.Views.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      FHelper3clr-namespace:Cafe.GitGuiPlatform.ViewModels.Helper     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5         Local_NoticeText �� 
TargetType �� Property �� Value  Local_NoticeStackPanel  Local_StandardTextBox  Local_PasswordBox  Local_StandardButton��%  &	        &	 �     &	 �    &	 �    &	 �    �� 5	   
   " ��6)   .�5
      ��  � ��$ 81��6&   �� 5       � ��$ 23��6'   �� 5       � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Lucida Sans Unicode)�6+   5      �� 5   
   " ��6/   .�5      ��  � ��$ 65��6'   �� 5       � ��$
 Left=�64   �� 5       � ��$	 Top=�62   �� 5       �@��Orientation$ 
Horizontal=�6,   5      �� 5   
   " ��6.   .�5      ��  � ��$ Lucida Sans Unicode)�6+   �� 5       � ��$ 16(�6)   �� 5       �@J�Opacity$ 10Q�6(   �� 5       � ��$ 5q�6(   �� 5       � ��$	 200��6&   �� 5       � ��$ 36��6'   5      �� 5   
   " G�6*   .�5      ��  � ��$ Lucida Sans Unicode)�6+   �� 5        � ��$ 16(�6)   �� 5!       �@J�Opacity$ 10Q�6(   �� 5"       � ��$ 5q�6(   �� 5#       � ��$	 200��6&   �� 5$       � ��$ 36��6'   5%      �� 5&   
   " ��6-   .�5'      ��  � ��$ 30��6'   �� 5(       � ��$ 88��6&   �� 5)       � ��$ Arial)�6+   �� 5*       � ��$ 16(�6)   �� 5+       � ��
 �����6+   �� 5,       � ��
 � � �6+   5-      5.      .��50      � $	��376��6   $	��376��51      $��	300,0,0,0q�52      ���	#FF453E3E J� Opacity$ 1Q�54      .+�55   
   �� $	��376��6   $
��Left=�56      $	��Top=�57       �� Orientation$ Vertical=�58      #��[ 59      .+�5:      �� $	��168��6   $��37��5;      $��0,12,0,0q�5<      $��Stretch=�5=      $��Stretch=�5>      $��26(�5?      #��[  5@      $��Please Login��5A       �� TextAlignment$ Center=�5B      5C      �� 5D   
   $	��332��6   $��93��5E      $��	21,71,0,0q�5F      $	��Top=�5G      #��[ 5H      .+�5I      �� $	��110��6   $��28��5J      $��5,0,0,0q�5K      $��20(�5L      #��[  5M      $��	Username:��5N      �� 5O      -   5        $��
m_Username��5O      #��[ 5P      ��5Q      �� *
Username+5R      �� 5S   
   $	��332��6   $��93��5T      $��
21,171,0,0q�5U      $	��Top=�5V      #��[ 5W      .+�5X      �� $	��110��6   $��28��5Y      $��5,0,0,0q�5Z      $��20(�5[      #��[  5\      $��	Password:��5]      G� 5^      -   5        $��
m_Password��5^      :   4Cafe.GitGuiPlatform.ViewModels.Helper.PasswordHelper   Attach . #��[ 5c         Password 5`      �� *
Password+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�5c      5d      �� 5e   
   $	��332��6   $��75��5f      $��
21,270,0,0q�5g      $	��Top=�5h      $ Vertical=�5i      #��[ 5j      .+�5k      �� -   5        $��m_Login��5k      $	��106��5l      $��31��5m      $��0,15,0,0q�5n      #��[ 5q      ��5o      �� *ClickCommand+��5p      �� *Value+5q      5r      5s      5t      
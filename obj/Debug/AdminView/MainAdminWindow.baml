   M S B A M L   `   `   `  ����@  <Elena, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Elena.AdminViewElena.AdminView  5   	   %    Elena.AdminView.MainAdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   )localclr-namespace:Elena.AdminView  5   	     � Title$  MainAdminWindow��5	   	   $	��450��6!   $	��800��61   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��1.3* �6   �� 5      $��1* �6   �� 5      $
��1.4* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6   .+�5   
    � -   5        $��frame��5      $��5��6   $��1��61     � NavigationUIVisibility$ Hidden=�6>   �� 5   
   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$" ../Images/bongocat-funny.gif��6   �� 5   
   -   5         ��Name$
 post��5      $��1��6   $��	20,0,20,0q�6/   $��Роли��6B   $��12(�6Q   6_   �� 5   
   -   5        $ userData��5      $��2��6#   $��	20,0,20,0q�63   $��Личные данные��6F   $��12(�6^   6l   �� 5   
   -   5        $
 exit��5      $��3��6   $��	20,0,20,0q�6/   $��
Выйти��6B   $��12(�6R   ���	#FFFD4C0A6s   �� 5   
   -   5        $ authData��5      $��4��6#   $��	20,0,20,0q�63   $)��#Данные авторизации��6F   $��12(�6c   6q   5      5      
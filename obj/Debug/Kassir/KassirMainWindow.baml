   M S B A M L   `   `   `  ����@  <Elena, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Elena.KassirElena.Kassir  5   	   #    Elena.Kassir.KassirMainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   &localclr-namespace:Elena.Kassir  5   	     � Title$  KassirMainWindow��5	   	   $	��450��6"   $
��1100��62   .��5
      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$" ../Images/bongocat-funny.gif��6   �� 5   
   -   5        $��	typeOfGet��5      $��Тип доставки��6"   $��1��69   $��	20,0,20,0q�6I   6\   �� 5   
   -   5        $��	typeOfPay��5      $��Тип оплаты��6"   $��2��67   $��	20,0,20,0q�6G   6Z   �� 5   
   -   5        $��createCheque��5      $��Создать чек��6%   $��4��6;   $��	20,0,20,0q�6K   6^   �� 5   
   -   5        $
��exit��5      $��
Выйти��6   $��6��6-   $��	20,0,20,0q�6=   6P   �� 5   
   -   5        $��	vieCheque��5      $��Все чеки��6"   $��5��65   $��	20,0,20,0q�6E   6X    � 5   
   -   5        $��Frame��5      $��1��6   $��7��6*     � NavigationUIVisibility$ Hidden=�6>   �� 5   
   -   5         ��Name$ typeOfCheque��5      $��3��6'   $��Тип чека��67   $��Center=�6J   $��Center=�6g   $	��122��6�   5       5!      
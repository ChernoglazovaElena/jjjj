   M S B A M L   `   `   `  ����@  <Elena, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Elena.SkladViewElena.SkladView  5   	   %    Elena.SkladView.SkladMainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   )localclr-namespace:Elena.SkladView  5   	     � Title$  SkladMainWindow��5	   	   $	��450��6!   $	��800��61   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6   .+�5   
   �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$" ../Images/bongocat-funny.gif��6   �� 5   
   -   5        $��typeOfProducts��5      $��Типы товаров��6'   $��1��6>   $��	20,0,20,0q�6N   6a   �� 5   
   -   5        $��products��5      $��Товары��6!   $��2��62   $��	20,0,20,0q�6B   6U   �� 5   
   -   5        $
��exit��5      $��
Выйти��6   $��3��6-   $��	20,0,20,0q�6=   6P    � 5   
   -   5        $��Frame��5      $��1��6   $��4��6*     � NavigationUIVisibility$ Hidden=�6>   5      5      
   M S B A M L   `   `   `  ����@  <Elena, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Elena.KassirElena.Kassir  5          Elena.Kassir.createCheque   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      &localclr-namespace:Elena.Kassir  5        N� Title$  createCheque��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $
��1.2* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��allProducts��5      $��1��6&   $��3��63   6o     5   
   -   5        $
��card��5      $��2��6   $��1��6/   $��3��6<   6x   �� 5   
   $��Товары��6   $��Center=�6"   $��	20,0,20,0q�6=   $��16(�6P    �� TextAlignment$ Center=�6^   �� 5   
   $��2��6   $��	20,0,20,0q�6$   $��Карзина��67   $��16(�6F   $��Center=�6T   $ Center=�6o   �� 5   
   -   5        $��typeGet��5      $��1��6"   $��	20,0,20,0q�62   $��1��6E   $��Center=�6R   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Тип получения��6m   �� 5   
   -   5        $��typePay��5      $��1��6"   $��
20,10,20,0q�62   $��2��6F   $	��Top=�6S   $ Тип оплаты��6k   �� 5   
   -   5        $��price��5       �� 	MaxLength$ 8��6   $��1��6-   $��	20,0,20,0q�6=   $��3��6P    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $��Center=�6y   $��16(�6�   $ Цена��6�   6�   �� 5    
   -   5        $��	cardPrice��5       $��1��6%   $
��Left=�65   $��	70,17,0,0q�6P   $
��Wrap=�6c   $��Цена: 0��6w   $	��Top=�6�   �� 5!   
   -   5        $	��pay��5!      $��1��6   $��4��6,   $��Оплатить��69   $��16(�6L   $��Center=�6Z   $��Center=�6w   $��	20,0,20,0q�6�   6�   �� 5"   
   -   5        $��
typeCheque��5"      $��1��6%   $��
20,20,20,0q�65   $��2��6I   $ Тип чека��6W   $��Center=�6�   5$      5%      
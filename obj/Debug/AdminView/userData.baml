   M S B A M L   `   `   `  ����@  <Elena, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Elena.AdminViewElena.AdminView  5          Elena.AdminView.userData   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      )localclr-namespace:Elena.AdminView  5        N� Title$  userData��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��userDataDataGrid��5      $��6��6+   6g   �� 5   
   -   5        $
��name��5   !    �� 	MaxLength$ 50��6   $��1��6-   $��Center=�6=   $��	20,0,20,0q�6X   
���   �$��16(�6~   $��0��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Имя��6�   6�   �� 5   
   -   5        $��
secondName��5   !   $ 50��6   $��1��63   $��Center=�6C   $��	20,0,20,0q�6^   
���   �$��16(�6�   $��1��6�   $ Фамилия��6�   6�   �� 5   
   -   5        $��	midleName��5   !   $ 50��6   $��1��62   $��Center=�6B   $��	20,0,20,0q�6]   
���   �$��16(�6�   $��2��6�   $ Отчество��6�   6�   �� 5   
   -   5        $
��save��5      $��1��6   $��Сохранить��6-   $��Center=�6A   $��5��6^   $��Center=�6k   $��20(�6�   $��42��6�   $	��172��6�   �� 5   
   -   5        $��delete��5      $��1��6   $��Удалить��6/   $��Center=�6A   $��4��6^   $��Center=�6k   $��20(�6�   $��42��6�   $	��172��6�   �� 5   
   -   5        $��update��5      $��1��6   $��Изменить��6/   $��Center=�6B   $��3��6_   $��Center=�6l   $��20(�6�   $��42��6�   $	��172��6�   5       5!      
   M S B A M L   `   `   `  ����M  ICurrency_converter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CurrencyConverterCurrencyConverter  5     #    Currency_converter.MainWindow   6	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6`   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   1localclr-namespace:CurrencyConverter     6    � Title$  
MainWindow��6Z  $	��450��6m  $	��800��6z  .��5      � .+�5   
   o� .@�5      m� $
��From��6   .@�5      m� -   5        $��Dollars��5      6?   m� 5      -   5        $��Pesos��5      6=   5      m� 5      $��To��6   .@�5	      m� -   5        $��Dollars��5	      6=   m� 5
      -   5        $��Pesos��5
      6;   m� 5      -   5        $��Pound��5      6;   m� 5      -   5        $��Euros��5      6;   m� 5      -   5        $	��Yen��5      69   m� 5      -   5        $��Ruble��5      6;   5      5      �� 5   
   $��From:��6   $
��Left=�6    $��	24,50,0,0q�6;   $	��Top=�6N   �� 5   
   -	   5         ��Name$ FromtextBox��5      $
��Left=�6'   $��	67,50,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $��TextBox��6i   $	��Top=�6x   $	��120��6�   �� 5   
   $	��To:��6   $
��Left=�6   $��	24,75,0,0q�69   $	��Top=�6L   �� 5   
   -
   5        $ 	TotextBox��5      $
��Left=�6%   $��	67,75,0,0q�6@   $
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ TotextAmount��5      $
��Left=�6(   $��
187,75,0,0q�6C   $
 Wrap=�6W   $��TextBox��6k   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ FromtextAmount��5      $
��Left=�6*   $��
187,50,0,0q�6E   $
 Wrap=�6Y   $��TextBox��6m   $	��Top=�6|   $	��120��6�   �� 5   
   -   5         ��Name$ button��5      $��Convert��6!   $
��Left=�63   $��
24,127,0,0q�6N   $	��Top=�6b   5      5      
   M S B A M L   `   `   `  ����W  SStandard to metric converter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Standard_to_metric_converterStandard_to_metric_converter  5   	   -    'Standard_to_metric_converter.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Standard_to_metric_converter     5   	     � Title$  
MainWindow��5   	   $	��310��6   $	��673��6)   .��5	      � -   5         �Name$ ___No_Name_��5	       J� RenderTransformOrigin$ 
0.507,0.53&�6    .+�5
   
   �� -   5         ��Name$ StandardvolumeCombobox��5
      $
��Left=�63   $��
218,55,0,0q�6N   $	��Top=�6b   $	��120��6z   $��22��6�   $��Mongolian Baiti)�6�   .@�5      �� $��
tablespoon��6   �� 5      $��fluid ounce��6   �� 5      $
��gill��6   �� 5      $	��cup��6   �� 5      $
��pint��6   �� 5      $��quart��6   �� 5      $��gallon��6   5      �� 5   
   -   5        $ Metricvolumecombobox��5      $
��Left=�61   $��217,111,0,0q�6L   $	��Top=�6a   $	��119��6y   $��22��6�   $��Mongolian Baiti)�6�   .@�5      �� $��
milliliter��6   �� 5      $��liter��6   �� 5      $��	kiloliter��6   5      �� 5   
   -   5        $ Standardlengthcombobox��5      $
��Left=�63   $��216,165,0,0q�6N   $	��Top=�6c   $	��120��6{   $��22��6�   $��Mongolian Baiti)�6�   .@�5      �� $
��inch��6   �� 5      $
��foot��6   �� 5      $
��yard��6   �� 5      $
��mile��6   5      �� 5   
   -   5        $ Metriclengthcombobox��5      $
��Left=�61   $��216,228,0,0q�6L   $	��Top=�6a   $	��120��6y   $��Mongolian Baiti)�6�   .@�5       �� $��
millimeter��6   �� 5!      $��
centimeter��6   �� 5"      $��meter��6   �� 5#      $��	kilometer��6   5$      �� 5%   
   -   5         ��Name$ Fromtextbox��5%      $
��Left=�6'   $��
386,51,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��146��6�   $ 
0.502,0.47&�6�   $��28��6�   $��Mongolian Baiti)�6�   �� 5&   
   -   5        $ 	Totextbox��5&      $
��Left=�6%   $��386,109,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��146��6�   $��28��6�   $��Mongolian Baiti)�6�   �� 5'   
   -   5         ��Name$ Clearbutton��5'      $��Clear��6&   $
��Left=�66   $��354,161,0,0q�6Q   $	��Top=�6f   $	��209��6~   $��29��6�   $��Mongolian Baiti)�6�   �� 5(   
   -	   5        $ Volumeconvertbutton��5(      $��Volume Convert��6.   $
��Left=�6G   $��354,205,0,0q�6b   $	��Top=�6w   $��45��6�   $	��102��6�   $��Mongolian Baiti)�6�   �� 5)   
   -
   5        $ Lengthconvertbuttton��5)      $��Length Convert��6/   $
��Left=�6H   $��461,205,0,0q�6c   $	��Top=�6x   $��45��6�   $	��102��6�   $��Mongolian Baiti)�6�   �� 5*   
   $
��Left=�6   $��
56,108,0,0q�6+   $	��Top=�6?   $ 0.15,-1&�6W   �� 5+   
   $!��From imperial legnth units:��6   $
��Left=�66   $��
56,168,0,0q�6Q   $	��Top=�6e   $��Mongolian Baiti)�6}   �� 5,   
   $!��From imperial volume units:��6   $
��Left=�66   $��	46,59,0,0q�6Q   $	��Top=�6d   $��Mongolian Baiti)�6|   �� 5-   
   $��To metric volume units:��6   $
��Left=�62   $��
71,109,0,0q�6M   $	��Top=�6a   $��Mongolian Baiti)�6y   �� 5.   
   $��To metric legnth units:��6   $
��Left=�62   $��
76,221,0,0q�6M   $	��Top=�6a   $ 1.051,0.287&�6y   $��Mongolian Baiti)�6�   �� 5/   
   $"��Imperial to Metric Converter��6   $
��Left=�67   $��
198,10,0,0q�6R   $	��Top=�6f   $��18(�6~   $��Mongolian Baiti)�6�   50      51      
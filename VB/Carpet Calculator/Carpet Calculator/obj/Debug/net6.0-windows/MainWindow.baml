   M S B A M L   `   `   `  ����L  HCarpet Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Carpet_CalculatorCarpet_Calculator  5   	   "    Carpet_Calculator.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Carpet_Calculator     5   	     � Title$  
MainWindow��5   	   $	��471��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Length:��6   $
��Left=�6"   $��	21,15,0,0q�6=   $	��Top=�6P   $��Mongolian Baiti)�6h   $��20(�6�   �� 5   
   $��Width:��6   $
��Left=�6!   $��	27,84,0,0q�6<   $	��Top=�6O   $��Mongolian Baiti)�6g   $��20(�6�   �� 5   
   $
��Left=�6   $	��100��6+   $��
548,10,0,0q�68   $	��Top=�6L   $	��100��6d   $��/Carpet1.JPG��6p   �� 5   
   $��$4 per sqr foot��6   $
��Left=�6*   $��
653,47,0,0q�6E   $	��Top=�6Y   �� 5   
   $
��Left=�6   $	��100��6+   $��548,115,0,0q�68   $	��Top=�6M   $	��100��6e   $��/Carpet2.JPG��6q   �� 5   
   $
��Left=�6   $	��100��6+   $��548,219,0,0q�68   $	��Top=�6M   $	��100��6e   $��/Carpet3.JPG��6q   �� 5   
   $��$3.70 per sqr foot��6   $
��Left=�6-   $��653,152,0,0q�6H   $	��Top=�6]   �� 5   
   $��$3.50 per sqr foot��6   $
��Left=�6-   $��653,261,0,0q�6H   $	��Top=�6]   �� 5   
   -   5         ��Name$ Carpetcombo��5      $
��Left=�6(   $��
93,163,0,0q�6C   $	��Top=�6W   $	��120��6o   .@�5      �� $��Trendy Threat II��6   �� 5      $��Soft Breath II��6   �� 5      $��Westchester III��6   �� 5      $��Trendy Threads I��6   5      �� 5   
   $��Carpet:��6   $
��Left=�6"   $��
18,156,0,0q�6=   $	��Top=�6Q   $��Mongolian Baiti)�6i   $��22(�6�   �� 5   
   $��Westchester III��6   $
��Left=�6*   $��31��6E   $��455,258,0,0q�6Q   $	��Top=�6f   $��88��6~   �� 5   
   $��Trendy Thread II��6   $
��Left=�6+   $��
448,47,0,0q�6F   $	��Top=�6Z   �� 5   
   $��Soft Breath II��6   $
��Left=�6)   $��465,152,0,0q�6D   $	��Top=�6Y    J� RenderTransformOrigin$ 0.907,0.593&�6q   �� 5   
   -   5        $
��Exit��5      $
��Left=�6    $��
10,390,0,0q�6;   $	��Top=�6O   $��70��6g   $��40��6r   $��Mongolian Baiti)�6~   $��36(�6�   6�   �� 5   
   -   5        $��	Calculate��5      $
��Left=�6%   $��
27,248,0,0q�6@   $	��Top=�6T   $��22(�6l   $��Mongolian Baiti)�6z   6�   �� 5    
   $��Cost:��6   $
��Left=�6    $��
32,313,0,0q�6;   $	��Top=�6O   $��22(�6g   $��Mongolian Baiti)�6u   �� 5!   
   -   5         ��Name$ 	Costlabel��5!      $�� ��6#   $
��Left=�6.   $��
93,313,0,0q�6I   $	��Top=�6]   $��Mongolian Baiti)�6u   $��22(�6�   �� 5"   
   -   5        $��Clear ��5"      $
��Left=�6"   $��153,248,0,0q�6=   $	��Top=�6R   $��Mongolian Baiti)�6j   $��22(�6�   6�   �� 5#   
   -   5         ��Name$ Lengthslider��5#      $
��Left=�6'   $��	93,23,0,0q�6B   $	��Top=�6U   $	��120��6m    �� TickFrequency$ 0Q�6�   �� 5$   
   -   5        $ Widthslider��5$      $
��Left=�6&   $��	93,92,0,0q�6A   $	��Top=�6T   $	��120��6l   6x   �� 5%   
   -   5        $ Lengthlabel��5%      $�� ��6%   $
��Left=�60   $��
213,19,0,0q�6K   $	��Top=�6_   �� 5&   
   -	   5        $ 
widthlabel��5&      $�� ��6$   $
��Left=�6/   $��
213,92,0,0q�6J   $	��Top=�6^   �� 5'   
   $
��Left=�6   $	��100��6+   $��548,324,0,0q�68   $	��Top=�6M   $	��100��6e   $��/Carpet4��6q   �� 5(   
   $��Trendy Threads I��6   $
��Left=�6+   $��32��6F   $��443,358,0,0q�6R   $	��Top=�6g   $	��100��6   �� 5)   
   $��$2.80per sqr foot��6   $
��Left=�6,   $��653,361,0,0q�6G   $	��Top=�6\   5+      5,      
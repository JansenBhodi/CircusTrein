   M S B A M L   `   `   `  ����F  BCircustrein, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CircustreinCircustrein  5   	       Circustrein.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Circustrein     5   	     � Title$  
MainWindow��5   	   $	��500��6   $
��1000��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   6,   �� 5      $
��1.5* �6   6.   .+�5   
   �  � RowDefinitions 5      �� 5      6"   �� 5      6"   .+�5      � .+�5      ]� .+�5      �� $��Center=�6!   $	��150��6>   .+�5      �� $��10q�6$   $��15(�60   $��Center=�6>   	Herbivore6f   ]� 5      $��Center=�6$   .+�5      �� -   5        .��5   ?   Small6F   �� 5      -   5        $
��10,0q�5   @   .��6N   Medium6V   �� 5      -   5        .��5   ?   Large6F   5      �� 5      $��10q�6$   $��15(�60   $��Center=�6>   	Carnivore6f   ]� 5      $��Center=�6$   .+�5       �� -   5        .��5    ?   Small6F   �� 5!      -   5        $
��10,0q�5!   @   .��6N   Medium6V   �� 5"      -   5        .��5"   ?   Large6F   5#      ]� 5$      $
��0,30q�6$   $��Center=�62   .+�5%      �� -   5        $��50��5%   %   $
��10,0q�60   .��6Q   Start6X   �� 5&      -   5        $��50��5&   %   .��6B   Reset6I   5'      5(      �� 5)      -	   5         ��Name$ LbCurrentAnimals��5)      $	��225��68   
���   �$	��2pxq�6X   $��Right=�6n   6�   5*      5+      � 5-      $��1��6   .+�5/      �� $��20q�6   $��Center=�6)   .+�50      �� 534 Herbi, 1 large, 2 medium, 1 small. 1 Carni, Large6U   �� 51      -
   5        $	��0,5q�51      .��6B   Load Preset6O   �� 52      A?4 Herbi, 2 Large, 1 Medium, 1 Small. 4 Carni, 1 Large, 1 Medium6a   �� 53      -   5        $	��0,5q�53      .��6B   Load Preset6O   �� 54      A?2 Herbi, 1 Large, 1 Medium. 4 Carni, 2 Large, 1 Medium, 1 Small6a   �� 55      -   5        $	��0,5q�55      .��6D   Load Preset6Q   56      59      5;      � 5=   
   $��1��6   .+�5?      ]� .+�5@      �� -   5        $ 
LbCartView��5@      $	��300��6.   
���   �$	��2pxq�6N   $
��Left=�6d   6�   �� 5A      6   5B      5D      5F      5G      
   M S B A M L   `   `   `  ����>  :wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:wpf.UserControlswpf.UserControls  5   	       wpf.MainWindow   5   
   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:wpf.UserControls     5   	      MaterialDesignWindow#��[  5   	     � Title$  Jongeren GroepsReizen��5	   	   $	��550��6'   $	��900��64   .��5
      � $��2q�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnPersonen��5      $��0��6&   $��0��63   
���z���$��Personen��6[   $��2q�6n   4  .System.Windows.Automation.AutomationProperties   AutomationId$ Personen��6y   6�   �� 5   
   -   5        $ btnInschrijvingen��5      $��0��6,   $��1��69   
����  �$��Inschrijvingen��6[   $��2q�6t   $ Inschrijvingen��6   6�   �� 5   
   -   5        $ btnGroepsreizen��5      $��0��6*   $��2��67   
����i��$��Groepsreizen��6]   $��2q�6t   $ Groepsreizen��6   6�   �� 5   
   -   5        $ btnOpleidingen��5      $��0��6)   $��3��66   
���� ��$��Opleidingen��6Z   $��2q�6p   $ Opleidingen��6{   6�   �� 5   
   -   5        $ btnBestemmingen��5      $��0��6*   $��4��67   
����� �$��Bestemmingen��6]   $��2q�6t   $ Bestemmingen��6   6�   �� 5   
   -   5        $ btnUitloggen��5      $��0��6'   $��5��64   
���  ��$��	Uitloggen��6V   $��2q�6j   6�   � 5   
   -   5         �Name$ gridContainer��5      $��1��6&   $��0��63   $��7��6C   $��5q�6W   .+�5          wpf.UserControls.Personen  -   5          Name$ 	personen2��5       $y�	Collapsed=�60   6I   %   wpf.UserControls.Inschrijvingen  5!      -	   5          Name$ inschrijvingen2��5!   #   $y�	Collapsed=�6<   6U   #   wpf.UserControls.Groepsreizen  5"      -
   5          Name$ groepsreizen2��5"   !   $y�	Collapsed=�68   6Q   "   wpf.UserControls.Opleidingen  5#      -   5        	  Name$	 opleidingen2��5#       $y�	Collapsed=�66   6O   #   wpf.UserControls.Bestemmingen  5$      -   5        
  Name$
 bestemmingen2��5$   !   $y�	Collapsed=�68   6Q   5%      5(      5)      
   M S B A M L   `   `   `  ����>  :wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:wpf.UserControlswpf.UserControls  5          wpf.UserControls.Personen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:wpf.UserControls     5      -   5          >�Name$  	personen1��5      .��5	      � 
���z��� � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $	��350 �6   �� 5      .+�5   
   �� $��0��6   $��0��6"   $��2��62   $��10q�6C   .+�5      �� $��5q�6   Geef op te zoeken naam:6<   �� 5      -   5        $��txtNaamGebruiker��5      4  .System.Windows.Automation.AutomationProperties   AutomationId$ NaamGebruiker��6M   $��20q�6   ��6.   �� *NaamGebruiker+6�   �� 5      -   5        $��btnZoekGebruikers��5      $��ZoekGebruikers��6B   $ ZoekGebruikers��6d   $��Zoek gebruikers��6�   $��10q�6�   ��6.   �� 6�   �� 5      -   5        $��lstGebruikers��5      $ lstGebruikers��6~   
�������$	��300��6�   ��6+   �� *
Gebruikers+ �� SelectedItem 6N   �� *GeselecteerdeGebruiker+6�   5      �� 5   
   $��0��6   $��1��6    $��2��60   $��Persoongegevens��6A   
�������$��5q�6m   .��5      �  5      �� 5      $��30 �6$   �� 5      $��30 �6$   �� 5       $��30 �6$   �� 5!      $��30 �6$   �� 5"      $��30 �6$   �� 5#      $��30 �6$   �� 5$      $��30 �6$   �� 5%      $��30 �6$   �� 5&      $��30 �6$   �� 5'      $��30 �6$   �� 5(      $��30 �6$   �� 5)      $��30 �6$   �� 5*      $��* �6$    5,      �� 5-      $	��150 �6'   �� 5.      .+�50      �� $��0��6   $��0��6)   $��Center=�69   Naam6Z   �� 51      -   5        $��txtFamilienaam��51      $
 Naam��6r   $��0��6�   $��1��6�   ��60   �� *GebruikerRecord.Naam+ �� ValidatesOnDataErrors$
 True��6�   �� 52      $��1��6   $��0��6)   $��Center=�69   
Voornaam6^   �� 53      -   5        $��txtVoornaam��53      $ Voornaam��6s   $��1��6�   $��1��6�   ��6-   �� *GebruikerRecord.Voornaam+$
 True��6�   �� 54      $��2��6   $��0��6)   $��Center=�69   Geboortedatum6c   (  "System.Windows.Controls.DatePicker  55      -   5        $��dateGeboortedatum��55      $ Geboortedatum��6�   $��2��6�   $��1��6�      SelectedDate 66   �� *GebruikerRecord.Geboortedatum+$
 True�� �� Mode$ TwoWay=�6�   �� 56      $��3��6   $��0��6)   $��Center=�69   
TelefoonNr6`   �� 57      -   5        $��txtTelefoonnr��57      $ Telefoonnummer��6{   $��3��6�   $��1��6�   ��6/   �� * GebruikerRecord.Telefoonnummer+$
 True��6�   �� 58      $��4��6   $��0��6)   $��Center=�69   Email6[   �� 59      -	   5        $��txtEmail��59      $ Email��6m   $��4��6�   $��1��6�   ��6*   �� *GebruikerRecord.Email+$
 True��6�   �� 5:      $��5��6   $��0��6)   $��Center=�69   Adres6[   �� 5;      -
   5        $��txtAdres��5;      $ Adres��6m   $��5��6�   $��1��6�   ��6*   �� *GebruikerRecord.Adres+$
 True��6�   �� 5<      $��6��6   $��0��6)   $��Center=�69   
Woonplaats6`   �� 5=      -   5        $��txtWoonplaats��5=      $ 
Woonplaats��6w   $��6��6�   $��1��6�   ��6/   �� *GebruikerRecord.Woonplaats+$
 True��6�   �� 5>      $��7��6   $��0��6)   $��Center=�69   
Allergie6^   �� 5?      -   5        $��txtAllergie��5?      $ Allergie��6s   $��7��6�   $��1��6�   ��6-   �� *GebruikerRecord.Allergie+$
 True��6�   �� 5@      $��8��6   $��0��6)   $��Center=�69   	Medicatie6_   �� 5A      -   5        $��txtMedicatie��5A      $ 	Medicatie��6u   $��8��6�   $��1��6�   ��6.   �� *GebruikerRecord.Medicatie+$
 True��6�   �� 5B      -   5        $��cbIsLid��5B      $ IsLid��6s   $��9��6�   $��0��6�   $��1q�6�    d� 	IsChecked 6+   �� *GebruikerRecord.IsLid+$
 True��.��6�   Is-Lid6�   �� 5C      -   5        $��
cbRolstoel��5C      $ Rolstoel��6x   $��9��6�   $��1��6�   $��1q�6�    6-   �� *GebruikerRecord.Rolstoel+$
 True��.��6�   
Rolstoel6�   �� 5D      -   5        $��cbMonitorBrevet��5D      $ MonitorBrevet��6�   $��10��6�   $��0��6�   $��1q�6�    62   �� *GebruikerRecord.MonitorBrevet+$
 True��.��6�   MonitorBrevet6�   �� 5E      -   5        $��cbHoofdMonitorBrevet��5E      $ Hoofdmonitorbrevet��6�   $��11��6�   $��0��6�   $��2��6�   $��1q�6�    67   �� *$"GebruikerRecord.Hoofdmonitorbrevet+$
 True��.��6   HoofdMonitorBrevet6  �� 5F      -   5        $��
cbWebAdmin��5F      $ WebAdmin��6x   $��10��6�   $��1��6�   $��1q�6�    6-   �� *GebruikerRecord.Webadmin+$
 True��.��6�   
WebAdmin6�   �� 5G      $��13��6   $��0��6*   	Opmerking6E   �� 5H      -   5        $��txtOpmerkingen��5H      $ 	Opmerking��6w   	 �� TextWrapping$
	 Wrap=�6�   
 �� AcceptsReturn$

 True��6�   $��13��6�   $��1��6�   ��60   �� *GebruikerRecord.Opmerking+$
 True��6�   5I      5J      �� 5L   
   $��0��6   $��2��6"   $��5q�62   .+�5M      �� -   5         ��Name$ btnNiewePersoonAanmaken��5M      $��GebruikerAanmaken��6J   $ GebruikerAanmaken��6o   $��Aanmaken��6�   $��10q�6�   ��66   �� 6�   �� 5N      -   5        $ btnPersoonAanpassen��5N      $��GebruikerAanpassen��6F   $��	Aanpassen��6l   $��10q�6�   ��62   �� 6�   �� 5O      -   5        $ btnPersoonVerwijderen��5O      $��GebruikerVerwijderen��6H   $��Verwijderen��6p   $��10q�6�   ��64   �� 6�   �� 5P      -   5        $ btnFormulierLeegmaken��5P      $��FormulierLeegmaken��6H   $ FormulierLeegmaken��6n   $��Formulier leegmaken��6�   $��10q�6�   ��64   �� 6�   5Q      �� 5T   
   -   5         ��Name$ lblErrorPersoon��5T      $��1��6)   $��2��66   
�������$y�Visible=�6]   $��20q�6r   .��5U      �� $
��Wrap=�67   ��6   �� *Foutmeldingen+6N   5V      5W      5X      
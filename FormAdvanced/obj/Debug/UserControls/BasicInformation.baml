   M S B A M L   `   `   `  ����G  CFormAdvanced, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FormAdvancedFormAdvanced  5      #    FormAdvanced.BasicInformation   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FormAdvanced     5        � 	Resources  5      *   $FormAdvanced.RadioBoolToIntConverter   radioBoolToIntConverter �� 
TargetType  TextBoxBaseStyle �� Property �� Value  LabelBaseStyle��%y  &	        &	      &	 s      5   
   6(   �� 5   
   " ��6   .�5      ��  � ��$ 0 0 0 5q�60   �� 5       � ��
 �   �6+   �� 5       � ��$	 200��6&   �� 5       � ��$ 30��6'   �� 5       � {� .  6*   �� 5       � ��
 ��� �6+   �� 5       � ��
 ��� �6,   �� 5       �@��TextAlignment$ Center=�6.   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$	 200��6&   �� 5        � ��$
 Left=�64   �� 5!       � ��$ Calibri Light)�6+   �� 5"       � ��$ 15(�6)   5#      5&      .��5*      � 
����� �.+�5-      �� $
��Left=�6   $��50��63   $	��500��6?   $��Enter your personal info��6K   $	��Top=�6k   $��	22,32,0,0q�5.      $��34(�6'   $��Calibri Light)�65   �� 54      $��
First Name��6   #��[ 6)   $��22,154,0,165q�6Q   �� 55      -   5         ��Name$
 name��55      #��[ 6$   $��22,124,378,196q�6q   ��6N   �� *Name+ �� Mode$ TwoWay=�56      �� 58      $��	Last Name��6   #��[ 6(   $��22,220,0,99q�6P   �� 59      -   5        $ lastName��59      #��[ 6(   $��22,190,378,130q�6x   ��6R   �� *	Surname+$ TwoWay=�5:      �� 5<      $��Your phone number��6   #��[ 60   $��22,286,0,32q�6X   �� 5=      -   5        $ phone��5=      #��[ 6%   $��22,256,378,64q�6s   ��6O   �� *Phone+$ TwoWay=�6s   �� 5?      -   5         ��Name$ 
CountryBox��5?      $
��Left=�6+   $��277,124,0,0q�6F   $	��Top=�6[   $	��200��6s   $��30��6   �� 5@      $��Select your country��6   #��[ 62   $	��150��6Z   $��277,154,0,165q�6f   �� 5B      $	��Age��6   #��[ 6"   $��277,220,0,99q�6J   �� 5C      -   5        $	 age��5C      #��[ 6#   $��277,190,249,130q�6p   $
��Auto��6�   ��6N   �� *Age+$ TwoWay=�6�   	� 5E      -   5         	�Name$
 male��5E      $
��Male��6(   $
��Left=�67   $��277,274,0,46q�6R   $��30��6h   
�������$��15(�6�    d� 	IsChecked 5F      �� 	 �� Path$		 Sex�
 �� 	Converter#
 [   �� ConverterParameter$
 Male��	� 5G      -   5        $ female��5G      $��Female��6*   $
��Left=�6;   $��360,274,0,46q�6V   $��30��6l   
�������$��15(�6�    5H      �� $		 Sex�#
 [  $ Female��5K      5M      
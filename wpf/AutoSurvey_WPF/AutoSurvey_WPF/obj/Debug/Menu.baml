   M S B A M L   `   `   `  ����I  EAutoSurvey_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AutoSurvey_WPFAutoSurvey_WPF  5   	       AutoSurvey_WPF.Menu   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:AutoSurvey_WPF     5   	     � Title$  MyMapua Login��5   	   $��383.5��6   $	��608��6.    � AllowsTransparency .  � WindowStyle$
 None=�5
   	   
������ .��5      ��  �� Padding$ 2q�6    �� CornerRadius$ 20��6   ���#3C038C._�5   
   �� $ 10q�6   $ 20��6   ���#0E0326._�5      �� .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $��* �6+   �� 5      $��* �6+   .+�5      �� -   5        $��textBlock_Username��5   �   $��Welcome, [Username]��6    $��0��6;   $��Center=�6K   $��Italic$�6f   $��Century Gothic)�6y   
�������6�   �� 5      $��2��6!    �� Orientation$ 
Horizontal=�61   $��Right=�6J   .+�5      �� $��Readme: ��6$   
�������$��Century Gothic)�6G   $��Center=�6c   �� 5      -   5        $��button_ReadMe��5   �   $��0q�6!   $��?��65   $��20��6B   $��20��6N   $��Right=�6Y   ���#3C038C
������� � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 5   "   " ��6(   .�5   &   �� 	 �@��CornerRadius$
 10��6E   5   #   5       5!      5"      5$      �� 5&      $��	0 50 0 50q�6   .+�5'      �� $��AutoSurveyV2��6    $��50(�64   
�������$��Center=�6U   $��Century Gothic)�6s   �� 5(      $��	By ABDRDG��6    $��10(�61   ���#3C038C$��Century Gothic)�6T   $��Right=�6p   $��	0 0 100 0q�6�   5)      �� 5+      -   5        $��button_FacEvaluation��5+   �   $��Answer Faculty Evaluation��6   $��17(�6=   $��0q�6K   $��
40 0 40 10q�6_   $��10q�6s   ���#F28705
�������$��Century Gothic)�6�    5,      ��%_   '��       �� 5-      " ��6    .�5.      �� 	 �@��CornerRadius$
 20��6=   5/      50      51      �� 53      -   5        $��button_LabAssessment��53   �   $"��Answer Laboratory Assessment��6   $��17(�6@   $��0q�6N   $��
40 0 40 10q�6b   $��10q�6v   ���#F28705
�������$��Century Gothic)�6�    54      ��%_   '��       �� 55      " ��6    .�56      �� 	 �@��CornerRadius$
 20��6=   57      58      59      �� 5;      -   5        $��button_Exit��5;   �   $
��EXIT��6   $��0q�6(   $��
90 15 90 0q�6<   $��10q�6P   ���#F2B705
�������$��Century Gothic)�6�    5<      ��%_   '��       �� 5=      " ��6    .�5>      �� 	 �@��CornerRadius$
 20��6=   5?      5@      5A      5C      5D      5E      5F      
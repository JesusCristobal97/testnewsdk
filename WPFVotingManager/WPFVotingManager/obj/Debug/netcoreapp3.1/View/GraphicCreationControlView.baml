   M S B A M L   `   `   `  ����K  GWPFVotingManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WPFVotingManager.ViewWPFVotingManager.View  5      6    0WPFVotingManager.View.GraphicCreationControlView   5      4mah,http://metro.mahapps.com/winfx/xaml/controls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WPFVotingManager.View     5      X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  69     N� Title$   GraphicCreationControlView��5	       N� 
Background �#F6E2BA.��5      �� .+�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   �� 5      $��25 �6#   .+�5      �� $��0��6   $��2��6&   $��Center=�6:   $��0��6W    �� Orientation$ 
Horizontal=�6g   $��50,0,0,0q�6�   .+�5      �� $��Gráfico��6   $
��Bold"�6+   $��30(�6=   5      �� 5      -   5         ��Name$ btnClose��5      
���  ��$��2��5      $��0q�5       $��16(�5!       � Cursor$
 Hand��5"      
�������$��X��5#   $   5%      �� 5&      $��1��6   $��0��6&   $��Básico��66   $��20(�6D   $
��Bold"�6R   $��	20,10,0,0q�6d   �� 5(      $��2��6   $��0��6&   $��3��66   $ 
Horizontal=�6J   $��20q�6c   .+�5)      �� $��30��6   $��Cargar Imagen de fondo��6%   $	��200��6F   
�������
�������$
��Bold"�6w   $��20,0,0,0q�6�   5*      5+      � 5,   
    5-      �� 5.      $
��Auto �6    �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      $
��Auto �6    �� 54      $
��Auto �6    �� 55      $
��Auto �6    �� 56      $
��Auto �6    �� 57      $
��Auto �6    �� 58      $
��Auto �6    �� 59      $
��Auto �6    �� 5:      $
��Auto �6    �� 5;      $
��Auto �6    �� 5<      $��20 �6    �� 5=      $
��Auto �6     5?      �� 5@      $��1* �6#   �� 5A      $��1* �6#   �� 5B      $��1* �6#   �� 5C      $��1* �6#   .+�5G      �� $��0��6   $��0��6&   $��Gráfico��66   $��20(�6E   $
��Bold"�6S   $��	20,10,0,0q�6e   �� 5I      $��1��6   $��0��6&   $
��Alto��66   $��15(�6C   $��20,10,10,10q�6Q   %  Xceed.Wpf.Toolkit.IntegerUpDown  5J      -   5          Name$ miNumericUpDown��5J   f   $��1��6!   $��30��6.   $��1��6;   $	��150��6K   $��15(�6W   �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   	Increment 16   �� 5L      $��2��6   $��0��6%   $��Ancho��65   $��15(�6C   $��20,10,10,10q�6Q     5M      -   5        $ miNumericUpDown2��5M   f   $��2��6!   $��30��6.   $��1��6;   $	��150��6K   $��15(�6W    16�   �� 5O      $��3��6   $��0��6%   $��	Posición��65   $��15(�6F   $��20,10,10,10q�6T   �� 5P      $��3��6   $��30��6$   $��1��61   $	��150��6A   $��15(�6M   �� 5R      $��1��6   $��2��6%   $��Fondo��65   $��15(�6C   $��20,10,10,10q�6Q   �� 5S      $��1��6   $��30��6$   $��3��61   $	��150��6A   $��15(�6M   �� 5W      $��4��6   $��0��6&   $��	Preguntas��66   $��20(�6G   $
��Bold"�6U   $��	20,10,0,0q�6g   �� 5Y      $��5��6   $��0��6%   $��Tamaño de fuente��65   $��15(�6N   $��20,10,10,10q�6\     5Z      -   5        $ miNumericUpDown3��5Z   g   $��5��6"   $��30��6/   $��1��6<   $	��150��6L   $��15(�6X    16�   �� 5\      $��6��6   $��0��6%   $��Tipo de fuente��65   $��15(�6L   $��20,10,10,10q�6Z   �� 5]      $��6��6   $��30��6$   $��1��60   $	��150��6@   $��15(�6L   �� 5_      $��7��6   $��0��6%   $��	Posición��65   $��15(�6F   $��20,10,10,10q�6T   �� 5`      $��7��6   $��30��6$   $��1��60   $	��150��6@   $��15(�6L   �� 5b      $��8��6   $��0��6%   $��Color��65   $��15(�6C   $��20,10,10,10q�6Q   #  Xceed.Wpf.Toolkit.ColorPicker  5c      -   5        $��miColorPicker��5c   b   $��8��6   $��30��6,   $��1��68   $	��150��6H   $��15(�6T   6b   �� 5e      $��5��6   $��2��6%   $��Margen superior��65   $��15(�6M   $��20,10,10,10q�6[     5f      -   5        $ miNumericUpDown4��5f   g   $��5��6"   $��30��6/   $��3��6<   $	��150��6L   $��15(�6X    16�   �� 5h      $��6��6   $��2��6%   $��Margen izquierdo��65   $��15(�6N   $��20,10,10,10q�6\     5i      -   5        $ miNumericUpDown5��5i   g   $��6��6"   $��30��6/   $��3��6<   $	��150��6L   $��15(�6X    16�   �� 5l      $��7��6   $��2��6%   $��Margen derecho��65   $��15(�6L   $��20,10,10,10q�6Z     5m      -   5        $ miNumericUpDown6��5m   g   $��7��6"   $��30��6/   $��3��6<   $	��150��6L   $��15(�6X    16�   �� 5o      $��8��6   $��2��6%   $��Margen inferior��65   $��15(�6M   $��20,10,10,10q�6[     5p      -	   5        $ miNumericUpDown7��5p   g   $��8��6"   $��30��6/   $��3��6<   $	��150��6L   $��15(�6X    16�   �� 5t      $��9��6   $��0��6&   $��
Respuestas��66   $��20(�6H   $
��Bold"�6V   $��	20,10,0,0q�6h   �� 5v      $��10��6   $��0��6&   $��Tamaño de fuente��66   $��15(�6O   $��20,10,10,10q�6]     5w      -
   5        $ miNumericUpDown8��5w   h   $��10��6"   $��30��60   $��1��6=   $	��150��6M   $��15(�6Y    16�   �� 5z      $��11��6   $��0��6&   $��Tipo de fuente��66   $��15(�6M   $��20,10,10,10q�6[   �� 5{      $��30��6   $��11��6#   $��1��62   $	��150��6B   $��15(�6N   �� 5}      $��12��6   $��0��6&   $��	Posición��66   $��15(�6G   $��20,10,10,10q�6U   �� 5~      $��30��6   $��12��6#   $��1��62   $	��150��6B   $��15(�6N   �� 5�      $��13��6   $��0��6&   $��Color��66   $��15(�6D   $��20,10,10,10q�6R     5�      -   5        $��miColorPicker2��5�   c   $��13��6   $��30��6-   $��1��69   $	��150��6I   $��15(�6U   6c   �� 5�      $��10��6   $��2��6&   $
��Alto��66   $��15(�6C   $��20,10,10,10q�6Q     5�      -   5        $ miNumericUpDown9��5�   h   $��10��6"   $��30��60   $��3��6=   $	��150��6M   $��15(�6Y    16�   �� 5�      $��11��6   $��2��6&   $��Ancho��66   $��15(�6D   $��20,10,10,10q�6R     5�      -   5        $ miNumericUpDown10��5�   h   $��11��6"   $��30��60   $��3��6=   $	��150��6M   $��15(�6Y    16�   �� 5�      $��12��6   $��2��6&   $��	Posición��66   $��15(�6G   $��20,10,10,10q�6U     5�      -   5        $ miNumericUpDown11��5�   h   $��12��6"   $��30��60   $��3��6=   $	��150��6M   $��15(�6Y    16�   �� 5�      $��13��6   $��2��6&   $��Fondo��66   $��15(�6D   $��20,10,10,10q�6R     5�      -   5        $ miNumericUpDown12��5�   h   $��13��6"   $��30��60   $��3��6=   $	��150��6M   $��15(�6Y    16�   �� 5�      $��3��6   $��15��6%   $��30��63   $��Guardar��6?   $	��150��6Q   
�������
�������$
��Bold"�6�   $��20,0,0,0q�6�   5�      5�      5�      
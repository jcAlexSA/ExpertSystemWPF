   M S B A M L   `   `   `  ����  ExpertSystem1    +ExpertSystem.RuleBlockWizardDefineOperators   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Rule Block Wizard: RB1��5   	   $	��375��6(   $	��300��65   .��5      �� .+�5   
   �� $��80��6   $!��Define Rule Block Operators��6   .��5      �� $��5q�6   $
��Wrap=�6#   $t��nIn this step you specift the input aggregation and the result aggregation (fuzzy operators) of the rule block.��67    �� TextAlignment$ Justify=�5	      5
      �� 5   
   $��Operator��6   $
��10,5q�6%   .��5      �� .+�5      	� $��2q�6   $��Min/Max��6)    d� 	IsChecked$
 TrueY�6;   	� 5      $��2q�6   $��Min/Prod��6)   	� 5      $��2q�6   $��Min/Mean��6)   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��Parameter: ��6   $��80��62   �� 5      $��0.117��6   $	��120��6+   5      �� 5       � Value$ 0.117Q�6    � Minimum$ 0Q�6'    � Maximum$ 1Q�63   5      5      �� 5   
   $��Result Aggregation��6   $
��10,5q�6/   .��5      �� .+�5      	� $
��10,5q�6   $)��#Max (Maximum of all firing degrees)��6,   $
 TrueY�6Z   	� 5      $
��10,5q�6   $.��(BSum (Bounded sum of all firing degrees)��6,   5      5       � 5"   
    � ColumnDefinitions 5#      �� 5$      �� 5%      �� 5&      .+�5)      �� $��8q�6   $��Previous��6    {�.  $��0��6E   �� 5*      $��8q�6   $
��Next��6    $��1��6/   �� 5+      $��8q�6   $��Cancel��6    $��2��61   5,      5.      5/      
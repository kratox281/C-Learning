   M S B A M L   `   `   `  ????H  DWpfAppResumen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfAppResumenWpfAppResumen  5   	       WpfAppResumen.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfAppResumen     5   	     ? Title$  RESUMEN contenedores??5   	   $	??450??6&   $	??800??63   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      ?? 5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      .+?5   
   ?? 
???i??$??10q?6%    ?? RadiusX$ 20??5       ?? RadiusY$ 20??6!   A? 5   
   
???????$??20q?6   $	??150??5      $	??150??6   ??5      ?? 5       ?? 
StartPoint$ 0.3,0.8&?6&    ?? EndPoint$ 0.8,0.3&?6;   .??5      ?  ? Color$ Black??6#    ? Offset$ 0Q?61   ? 5      $ White??6#   $ 1Q?61   5      5      A? 5   
   $??40q?6   $	??110??6   $	??110??6*   $??5??67   ??5      
? 5      	 
? GradientOrigin$	 0.8,0.3&?6&   .??5       ? $ White??6#   $ 0.133Q?61   ? 5!      $ #FFD61D??6#   $ 0.884Q?63   5"      ??5$      ?? 5%      $ 0.3,0.8&?6&   $ 0.8,0.3&?69   .??5&      ? $ Black??6#   $ 0.088Q?61   ? 5'      $ White??6#   $ 0.594Q?61   5(      5*      ?? 5+   
   $??0??6   $??1??6$   $
??Auto=?5,      $??Disabled=?5-      $??0,0,0,10q?5.      .??5/      ?? -   5        
 ??Name$	
 sp1??5/       ?? Orientation$ 
Horizontal=?6&   
????ح?6?   50      ?? 51   
   $??1??6   $??1??6$   $??0,10,0,0q?64   .??52      ? -   5         ?Name$	 wp1??52       ? Orientation$ 
Horizontal=?6%   
???????6>   53      ? 54   
   $??1??6   $??10q?6    55      ?? 56      ?? 57      .+?59      ?? $ Vertical=?6   $??1??5:      $??Center=?5;      $??Center=?5<      .+?5=      ?? -   5         ??Name$ boton1??5=      $??Llenar StackPanel??6)   $??10q?5>      $??20q?6%   62   ?? 5?      -   5        $ boton2??5?      $??Llenar WrapPanel??6)   $??10q?5@      $??20q?6%   62   5A      ?? 5B         ButtonStyle1#???   6   
???   ?.??5D      ??  J? RenderTransformOrigin$ 0.5,0.5&?6    ? Cursor$
 Hand??5E      $??3q?5F      
??????? J? Effect 5H      3  -System.Windows.Media.Effects.DropShadowEffect  5I      z?5K      V? 5L      .~?5M      ?? ?? 5N      ?? 5O       ?? Angle$	 -18Q?6.   T? 5P      5Q      ._?5S      ?? 
???????.+?5T      ?? $	??100??6    $??/CSharp.png??6-   ?? 5U      $??Pulsa??6    
???????$??Center=?5W      5X      5Y      5Z      5[      5]      5^      
   M S B A M L   `   `   `  ????H  DWpfAppEstilos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfAppEstilosWpfAppEstilos  5   	       WpfAppEstilos.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfAppEstilos     5   	     ? WindowStyle$
  None=?5   	    ? WindowStartupLocation$ CenterScreen=?6    ? Topmost$
 True??5	   	    ? 
ResizeMode$ NoResize=?6   
??????  ? AllowsTransparency$
 True??5
   "    ? Title$ 
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5       ?? 
TargetType ?? Property	 ?? Value3  -System.Windows.Media.Effects.DropShadowEffect
 ?? Triggers P? Property P? Value T? X T? Y   ShadowDepth   
BlurRadius??%	  '??       ?? 5   
   " ??6   .?5      ??  ? ??
	 ?????6+   ?? 5       ? ??$	 80??6&   ?? 5       ? ??$	 10q?6'   ?? 5       ?@?Cursor$
	 Hand??6'   ?? 5       ?@J?Effect	 5        5      5      
 5      P? 5       ? ??$
 True??6/   . ?5      ??  ? z?	 5      T? 5      $ 5Q?5   O   $ 5Q?5   O   5      5!      ?? 5"       ?@J?Effect	 5#        5$      $ 0Q?6/   $ 0Q?6?   5&      5'      5)      5*      .??5+      ?  ? RowDefinitions 5,   
   ?? 5-      $??7* ?6   ?? 5.      .+?50   
   ?? 
????ح?$??0??6%   $??3q?62    J? Opacity$	 0.5Q?51       ?? RadiusX$ 10??52       ?? RadiusY$ 10??6!   ?? 53   
   
????ح?$??1??6%   $??3q?62   $ 10??54      $ 10??6!   A? 55   
   -   5        $??50??55      $??50??6   
???????$??5??56      
???????$??10q?57       ? Cursor$ 	ScrollAll??6   $	??Top=?59      $??Right=?6*   ?? 5:   
   $??Ventana uno??6   $??Center=?5;      $??Center=?6+   $??72(?5<      
??? ???$
??Bold"?60    J? RenderTransformOrigin$ 0.5,0.5&?6B   z?5=      V? 5>      .~?5?      ?? ?? 5@      ?? 5A       ?? Angle$	 -15Q?6&   T? 5B      5C       J? Effect 5E        5F      5H      ?? 5I   
   $??1??6   $??0,0,20,0q?6"    ?? Orientation$ 
Horizontal=?5J      $??Right=?5K      $
 Hand??61   .+?5L      ?? .??6   
botón 16   ?? 5M      .??6   
botón 26   ?? 5N      -   5         ??Name$ 
botonSalir??5N      $??Salir??5O      5P      5Q      5R      5S      
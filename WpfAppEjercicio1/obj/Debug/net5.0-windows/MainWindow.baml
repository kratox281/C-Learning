   M S B A M L   `   `   `  ????K  GWpfAppEjercicio1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfAppEjercicio1WpfAppEjercicio1  5   	   !    WpfAppEjercicio1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfAppEjercicio1     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??2??6(   
???P??$??1??5   *   $??Right=?5      $??Stretch=?5      ?? 5   
   -   5        
????ح? ?? CornerRadius$ 90??5   (   $??20q?5       ?? Padding$ 20q?6   ._?5      (? .??5      ?? $??pulsa aquí??6    J? Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5      -   5        
efecto??   Radius$ 3Q?5   5   5      5        5!      3  -System.Windows.Media.Effects.DropShadowEffect  5"      -   5        
sombra??   
BlurRadius$ 20Q?5"   3      Color$ Black??5#   #   5%      ?? 5&   
   $??1??5'      $??1??6#   ??5(      ?? 5)      
??? ???	 ?? Padding$	 7q?5*      
???????Datos del empleado6O   .??5,      ?? .+?5-      ?? 
???z???
 ?? TabStripPlacement$	
 Top=?5.      $??0, 0, 0, 10q?5/      .@?50      ?? -   5         ??Name$ PersonalInfo??50      ??51      ?? 52   "   $??Empleado??6,   .??54      ?? .+?55      ?? 
Empleado62   ?? 56      -   5        $??lbNombre??56   &   .@?57   "   ??  ?? 
IsSelected$
 true??6.   .??6@   Esther6H   ?? 58   "   .??6.   George66   ?? 59   "   .??6.   Alan64   ?? 5:   "   .??6.   Eric64   5;      5<      5=      ?? 5>      $??Información _Laboral??5?   N   .??5@      ?? .+?5A      ?? Seleccione un puesto6>   ?? 5B      -   5        $??lbPuesto??5B   &   .@?5C   "   ?? $
 true??6.   .??6@   Desarrollador6O   ?? 5D   "   .??6.   Tester66   ?? 5E   "   .??6.   Operador de consola6C   ?? 5F   "   .??6.   	Manager67   5G      5H      5I      ?? 5J      -   5        $??Habilidades??5J      $??_Habilidades??5K   F   .??5L      ?? .+?5M      ?? #!Seleccione su principal habilidad5O      ?? 5P      -   5        $??lbSkils??5P   &   .@?5Q   "   ?? $
 true??6.   .??6@   C#6D   ?? 5R   "   .??6.   Visual Basic6<   ?? 5S   "   .??6.   .NET64   ?? 5T   "   .??6.   	JScript67   5U      5V      5W      ?? 5X      -	   5        $??Sumario??5X      $??_Sumario??5Y   B   .??5Z      ?? .+?5[      ?? -
   5        $??empleado??5[   (   ?? 5\      -   5        $??puesto??5\   (   ?? 5]      -   5        $??skill??5]   (   5^      5_      5`      5a      5b      ?? 5c   
   $??20q?6   
???   ? ? Cursor$
 Hand??61   $??1??5d      $
??Left=?6   .??5e      ?? $??10q?6   
??????? J? RenderTransformOrigin$ 0.5,0.5&?5f      z?5g      V? 5h      .~?5i      ?? ?? 5j      ?? 5k       ?? Angle$ -17.354Q?6*   T? 5l      5m      .+?5o      ?? $??/CSharp.png??6   $	??100??6-   $	??Top=?6:   ?? 5p      $??Pulsa??6   
???????$??Center=?5r      5s      5t      5v      5w      
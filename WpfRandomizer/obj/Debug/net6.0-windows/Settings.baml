   M S B A M L   `   `   `  ????H  DWpfRandomizer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfRandomizerWpfRandomizer  5   	       WpfRandomizer.Settings   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   -localclr-namespace:WpfRandomizer     5   	     ? Title$  Settings??5   	   $	??200??6   $	??250??6'    ? 
ResizeMode$ NoResize=?63    ? 	Resources 5	         SaveButtonTemplate ?? 
TargetType ??Name ?? Triggers P? Property P? Value ?? Property	 ?? Value
 ?? 
TargetName  SaveButtonStyle ?? 
TargetType??%x  &	        &	 m    ?? 5
   
   " ??65   .R?5      ? .+?5      ?? $ BtnSave??6   #??z??6-   #??z??6Q   6y   ?? 5      $??Center=?6#   $??Center=?6@   6]   5       5      P? 5       ?@J?IsMouseOver$
 True??61   . ?5      ??  ?@?Cursor$
	 Hand??6/   6>   ?? 5      $
 BtnSave??6-    ? ??	 ?#577a6b6T   5      5      ?? 5   
   " ??6(   .?5      ??  ? ??$	 5q?6(   64   ?? 5       ?@?Cursor$
	 Hand??6'   66   ?? 5       ? ??	 ?#6D98866=   ?? 5       ? ??
	 ?????6;   ?? 5       ? ??$	 16(?6)   66   5      5       .??5!      ? ???#393E46.+?5"   
   ?? $??Center=?6   $??Center=?62   .+?5#      ?? $??Center=?6   $??Center=?66   $??0 0 0 10q?6Q   .+?5$      ?? $??0 10 0 0q?6   $??14(?6.   
???????Separation options:5&      	? 5'      -   5        $??
EnterRadio??5'       	? 	GroupName$ Separations??60   $??10(?6c   
???????$
??Bold"?6?   $??Center=?6?   .??6?   
New line6?   	? 5(      -   5        $??
CommaRadio??5(      $ Separations??60   $??10(?6d   
???????$
??Bold"?6?   $??Center=?6?   .??6?   Comma6?   	? 5)      -   5        $??NumberRadio??5)      $ Separations??61   $??10(?6e   
???????$
??Bold"?6?   $??Center=?6?   .??6?   Number6?   5*      ?? 5+      $??Center=?6   $??Center=?66   .+?5,      ?? -   5        $??NumberedCheckBox??5,      $??14(?63   
???????.??6W   Numbered output6h   ?? 5-      -   5         ??Name$ BtnSave??5-      #??[ 6*   #??[  6S   $??	0 10 0 10q?6?   .??6?   Save6?   5.      5/      50      51      
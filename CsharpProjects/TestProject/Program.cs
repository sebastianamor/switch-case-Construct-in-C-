﻿// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch  (product[0])  {
         
       case "01":
       type = "Sweat shirt";
       break;

       case "02":
       type = "T-Shirt";
       break;

       case "03":
       type = "Sweat pants";
       break;

       default:
       type = "Other";
       break;
}

 switch( product[1]) {

       case "BK":
       color = "black";
       break;

       case "MN":
       color = "marron";
       break;

       default:
       color = "white";
       break;

 }

switch( product[2]) {

       case "S":
       size = "small";
       break;

       case "M":
       size = "Medium";
       break;

       case "L":
       size = "Large";
       break;

       default:
       size = " One Size Fits All  ";
       break;

 }
 

 Console.WriteLine($"Product: {size} {color} {type}");
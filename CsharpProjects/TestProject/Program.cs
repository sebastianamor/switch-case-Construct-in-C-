// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string  sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product) {  
     
      case (product[0] == "01")
      type = "Sweat shirt";
      break;

      case (product[0] == "02")
      type = "T-Shirt";
      break; 


     case  (product[0] == "03")
    type = "Sweat pants";
     break;

    type = "Other";
   case (product[1] == "BL")
    color = "Black";
    break;
    case (product[1] == "MN")
    color = "Maroon";
    break;

    color = "White";


  case  (product[2] == "S")
    size = "Small";
    break;


   case (product[2] == "M")
    size = "Medium";
    break;

   case (product[2] == "L")
    size = "Large";
    break;
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
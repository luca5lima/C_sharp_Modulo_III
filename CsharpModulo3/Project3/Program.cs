// switch (fruit)
// {
//     case "apple":
//     Console.WriteLine($"App will display information for apple.");
//     break;

//     case "banana":
//     ConsoleWriteLine($"App will display information for banana.");
//     break;

//     case "cherry":
//     ConsoleWriteLine($"App will display information for cherry.");
//     break;
// }
// ------------------------------------------------------------------

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
    title = "Senior Associate";
    break;

    case 300:
    title = "Manager";
    break;

    case 400:
    title = "Senior Manager";
    break;

    default:
    title = "Associate";
    break;
}

Console.WriteLine($"{employeeName}, {title}");
Console.WriteLine("--------------------------------------------------------------\n");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
    type = "Sweat shirt";
    break;

    case "02":
    type = "T-shirt";
    break;

    case "03":
    type = "Sweat pants";
    break;

    default:
    type = "Other";
    break;
}

switch (product[1])
{
    case "BL":
    color = "Black";
    break;

    case "MN":
    color = "Maroon";
    break;

    default:
    color = "Write";
    break;
}

switch (product[2])
{
    case "S":
    size = "Small";
    break;

    case "M":
    size = "Medium";
    break;

    case "L":
    size = "Large";
    break;

    default:
    size = "One Size Fits All";
    break;
}

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

Console.WriteLine($"Product: {size} {color} {type}");
Console.WriteLine("--------------------------------------------------------------\n");
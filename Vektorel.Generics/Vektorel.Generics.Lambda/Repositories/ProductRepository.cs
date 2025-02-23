using Vektorel.Generics.Lambda.Models;

namespace Vektorel.Generics.Lambda.Repositories;

internal class ProductRepository
{
    List<Product> products = new List<Product>
    {
        new Product(1, "Chai", 18.00m, 39, "Exotic Liquids", "Beverages"),
        new Product(2, "Chang", 19.00m, 17, "Exotic Liquids", "Beverages"),
        new Product(3, "Aniseed Syrup", 10.00m, 13, "Exotic Liquids", "Condiments"),
        new Product(4, "Chef Anton's Cajun Seasoning", 22.00m, 53, "New Orleans Cajun Delights", "Condiments"),
        new Product(5, "Chef Anton's Gumbo Mix", 21.35m, 0, "New Orleans Cajun Delights", "Condiments"),
        new Product(6, "Grandma's Boysenberry Spread", 25.00m, 120, "Grandma Kelly's Homestead", "Condiments"),
        new Product(7, "Uncle Bob's Organic Dried Pears", 30.00m, 15, "Grandma Kelly's Homestead", "Produce"),
        new Product(8, "Northwoods Cranberry Sauce", 40.00m, 6, "Northwoods Produce", "Condiments"),
        new Product(9, "Mishi Kobe Niku", 97.00m, 29, "Tokyo Traders", "Meat/Poultry"),
        new Product(10, "Ikura", 31.00m, 31, "Tokyo Traders", "Seafood"),
        new Product(11, "Queso Cabrales", 21.00m, 22, "Cooperativa de Quesos 'Las Cabras'", "Dairy Products"),
        new Product(12, "Queso Manchego La Pastora", 38.00m, 86, "Cooperativa de Quesos 'Las Cabras'", "Dairy Products"),
        new Product(13, "Konbu", 6.00m, 24, "Tokyo Traders", "Seafood"),
        new Product(14, "Tofu", 23.25m, 35, "Tokyo Traders", "Produce"),
        new Product(15, "Genen Shouyu", 15.50m, 39, "Tokyo Traders", "Condiments"),
        new Product(16, "Pavlova", 17.45m, 29, "Pavlova, Ltd.", "Confections"),
        new Product(17, "Alice Mutton", 39.00m, 0, "Odd Lots", "Meat/Poultry"),
        new Product(18, "Carnarvon Tigers", 62.50m, 42, "Seafood Australia", "Seafood"),
        new Product(19, "Teatime Chocolate Biscuits", 9.20m, 25, "Teatime Biscuits Ltd", "Confections"),
        new Product(20, "Sir Rodney's Scones", 12.50m, 40, "Aux joyeux ecureuils", "Confections"),
        new Product(21, "Gorgonzola Telino", 20.00m, 15, "Cooperativa di San Cristoforo", "Dairy Products"),
        new Product(22, "Mascarpone Fabioli", 32.00m, 15, "Caseificio Di Nuova Roma", "Dairy Products"),
        new Product(23, "Pasta Bazooka", 22.50m, 30, "Paolo's Pasta", "Grains/Cereals"),
        new Product(24, "Tofu", 23.25m, 35, "Tokyo Traders", "Produce"),
        new Product(25, "Durian", 38.00m, 24, "Durian R&D", "Fruit"),
        new Product(26, "Merguez", 55.00m, 20, "Parisian Sausages", "Meat/Poultry"),
        new Product(27, "Chocolade", 12.50m, 60, "Gourmet Chocolate Co.", "Confections"),
        new Product(28, "Casablanca", 25.00m, 40, "Moroccan Delights", "Beverages"),
        new Product(29, "Balsamic Vinegar", 30.00m, 90, "Balsamic Makers", "Condiments"),
        new Product(30, "Green Tea", 9.00m, 15, "Tea Traders", "Beverages"),
        new Product(31, "Saffron", 50.00m, 10, "Spice Traders", "Condiments"),
        new Product(32, "Aged Gouda", 40.00m, 35, "Dutch Dairy", "Dairy Products"),
        new Product(33, "Pineapple", 4.00m, 100, "Tropical Fruits", "Produce"),
        new Product(34, "Kiwi", 3.50m, 80, "Tropical Fruits", "Produce"),
        new Product(35, "Chicken Tenders", 22.00m, 60, "Poultry World", "Meat/Poultry"),
        new Product(36, "Blueberries", 6.00m, 45, "Berry Farms", "Produce"),
        new Product(37, "Artichokes", 10.00m, 20, "Mediterranean Greens", "Vegetables"),
        new Product(38, "Roquefort", 38.00m, 50, "French Cheese Co.", "Dairy Products"),
        new Product(39, "Chili Sauce", 12.00m, 80, "Spicy Foods Ltd.", "Condiments"),
        new Product(40, "Feta Cheese", 18.00m, 110, "Greek Cheese Makers", "Dairy Products"),
         new Product(41, "Mozzarella", 15.00m, 70, "Italian Cheese Co.", "Dairy Products"),
        new Product(42, "Cheddar", 12.50m, 85, "British Dairy", "Dairy Products"),
        new Product(43, "Spinach", 7.00m, 50, "Green Farms", "Vegetables"),
        new Product(44, "Cabbage", 5.00m, 100, "Green Farms", "Vegetables"),
        new Product(45, "Lamb Chops", 45.00m, 30, "Meat Masters", "Meat/Poultry"),
        new Product(46, "Duck Breast", 55.00m, 20, "Gourmet Farms", "Meat/Poultry"),
        new Product(47, "Salmon", 30.00m, 40, "Fresh Seafood", "Seafood"),
        new Product(48, "Crab", 50.00m, 15, "Oceanic Seafood", "Seafood"),
        new Product(49, "Prawns", 25.00m, 60, "Oceanic Seafood", "Seafood"),
        new Product(50, "Lobster", 70.00m, 10, "Luxury Seafood", "Seafood"),
        new Product(51, "Mangoes", 5.50m, 120, "Tropical Fruits", "Fruit"),
        new Product(52, "Papayas", 6.00m, 75, "Tropical Fruits", "Fruit"),
        new Product(53, "Bananas", 3.00m, 200, "Tropical Fruits", "Fruit"),
        new Product(54, "Apples", 4.50m, 150, "Orchard Farms", "Fruit"),
        new Product(55, "Pears", 4.00m, 90, "Orchard Farms", "Fruit"),
        new Product(56, "Tomatoes", 8.00m, 110, "Veggie Farms", "Vegetables"),
        new Product(57, "Cucumbers", 3.50m, 130, "Veggie Farms", "Vegetables"),
        new Product(58, "Potatoes", 6.00m, 180, "Root Vegetables", "Vegetables"),
        new Product(59, "Carrots", 5.50m, 160, "Root Vegetables", "Vegetables"),
        new Product(60, "Eggplant", 7.00m, 50, "Mediterranean Greens", "Vegetables"),
        new Product(61, "Frying Pan", 25.00m, 45, "Kitchen Essentials", "Kitchen"),
        new Product(62, "Blender", 60.00m, 30, "Home Appliances", "Kitchen"),
        new Product(63, "Coffee Maker", 80.00m, 50, "CoffeeCo", "Kitchen"),
        new Product(64, "Toaster", 40.00m, 25, "Home Appliances", "Kitchen"),
        new Product(65, "Knife Set", 100.00m, 15, "Chef Supplies", "Kitchen"),
        new Product(66, "Cutting Board", 15.00m, 100, "Kitchen Essentials", "Kitchen"),
        new Product(67, "Dish Rack", 20.00m, 55, "Home Accessories", "Kitchen"),
        new Product(68, "Whisk", 7.00m, 120, "Kitchen Essentials", "Kitchen"),
        new Product(69, "Pots and Pans Set", 150.00m, 40, "Home Appliances", "Kitchen"),
        new Product(70, "Measuring Cups", 10.00m, 200, "Baking Supplies", "Kitchen"),
        new Product(71, "T-Shirt", 15.00m, 200, "Fashion Co.", "Clothes"),
        new Product(72, "Jeans", 45.00m, 150, "Denim World", "Clothes"),
        new Product(73, "Sweater", 30.00m, 100, "Cozy Wear", "Clothes"),
        new Product(74, "Jacket", 70.00m, 80, "Warmth Clothing", "Clothes"),
        new Product(75, "Shorts", 20.00m, 120, "Sunny Wear", "Clothes"),
        new Product(76, "Skirt", 25.00m, 90, "Fashion Co.", "Clothes"),
        new Product(77, "Shirt", 18.00m, 180, "Fashion Co.", "Clothes"),
        new Product(78, "Sneakers", 55.00m, 200, "Sporty Footwear", "Clothes"),
        new Product(79, "Boots", 75.00m, 100, "Outdoor Gear", "Clothes"),
        new Product(80, "Dress", 50.00m, 60, "Elegant Wear", "Clothes")
    };

    public List<Product> Products => products;

    //public List<Product> Products { get { return products; } }

    // Lambda Expression
    // Gösterimi " => "
    // Manası : return
}

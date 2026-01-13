using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCEightToTen.Services
{
    public class MCTenServices
    {
        public string RandomizedRestaurant(string foodcategory)
        {
            switch (foodcategory.ToLower())
            {
                case "mexican":
                    Random rnd = new Random();
                    int mexican = rnd.Next(1, 11);
                    switch (mexican)
                    {
                        case 1:
                            return "How about Xochimilco Cafe? That sounds delicious.";
                            
                        case 2:
                            return "How about Carolina's Grill? That sounds delicious.";
                            
                        case 3:
                            return "How about Tepa Taqueria? That sounds delicious.";
                            
                        case 4:
                            return "How about Beto's Tacos? That sounds delicious.";
                            
                        case 5:
                            return "How about Cancun? That sounds delicious.";
                            
                        case 6:
                            return "How about El Señor Frog's? That sounds delicious.";
                            
                        case 7:
                            return "How about Irma's Place? That sounds delicious.";
                            
                        case 8:
                            return "How about Nena's Mexican Cuisine? That sounds delicious.";
                            
                        case 9:
                            return "How about Arroyo's Cafe? That sounds delicious.";
                            
                        case 10:
                            return "How about Tio Pepe's? That sounds delicious.";
                            
                        default:
                            return "Please enter valid input.";
                            
                    }
                    
                case "asian":
                    Random rnd2 = new Random();
                    int asian = rnd2.Next(1, 11);
                    switch (asian)
                    {
                        case 1:
                            return "How about Misaki Sushi & Bar? That sounds delicious.";
                            
                        case 2:
                            return "How about Cocoro Bistro? That sounds delicious.";
                            
                        case 3:
                            return "How about Sushi Burrito? That sounds delicious.";
                            
                        case 4:
                            return "How about Johnny Wokker? That sounds delicious.";
                            
                        case 5:
                            return "How about China Palace? That sounds delicious.";
                            
                        case 6:
                            return "How about Pho Island? That sounds delicious.";
                            
                        case 7:
                            return "How about K-Town Korean BBQ? That sounds delicious.";
                            
                        case 8:
                            return "How about Thai Me Up? That sounds delicious.";
                            
                        case 9:
                            return "How about Shirasoni? That sounds delicious.";
                            
                        case 10:
                            return "How about Domo? That sounds delicious.";
                            
                        default:
                            return "Please enter valid input.";
                            
                    }
                    
                case "fast":
                    Random rnd3 = new Random();
                    int fastFood = rnd3.Next(1, 11);
                    switch (fastFood)
                    {
                        case 1:
                            return "How about KFC? That sounds delicious.";
                            
                        case 2:
                            return "How about Raising Canes? That sounds delicious.";
                            
                        case 3:
                            return "How about McDonald's? That sounds delicious.";
                            
                        case 4:
                            return "How about Jack in the Box? That sounds delicious.";
                            
                        case 5:
                            return "How about Burger King? That sounds delicious.";
                            
                        case 6:
                            return "How about Subway? That sounds delicious.";
                            
                        case 7:
                            return "How about Carl's Jr? That sounds delicious.";
                            
                        case 8:
                            return "How about Wendy's? That sounds delicious.";
                            
                        case 9:
                            return "How about Taco Bell? That sounds delicious.";
                            
                        case 10:
                            return "How about Popeye's? That sounds delicious.";
                            
                        default:
                            return "Please enter valid input.";
                            
                    }
                case "default":
                {
                    return "Please enter only either 'mexican', 'asian', or 'fast' as a category." ;  
                }
                    
            }
        return "Please enter only either 'mexican', 'asian', or 'fast' as a category." ;  
        }
    }
}
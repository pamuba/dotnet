// // using System;
// // namespace EventsDemo{
// //     public class Order
// //     {
// //         public string Item { get; set; }
// //         public string Ingredients { get; set; }
// //     }
// //     //publisher
// //     public class FoodOrderingService
// //     {
// //         public delegate void FoodPreparedEventHandler(object source, EventArgs args);
// //         public event FoodPreparedEventHandler FoodPrepared;
// //         public void PrepareOrder(Order order)
// //         {
// //             Console.WriteLine($"Preparing your order '{order.Item}', please wait...");
// //             Thread.Sleep(4000);

// //             OnFoodPrepared(order);
// //         }
// //         protected virtual void OnFoodPrepared(Order order)
// //         {
// //             if (FoodPrepared != null)
// //                 FoodPrepared(this, new FoodPreparedEventArgs { Order = order });
// //         }
// //     }
// //     public class MailService
// //     {
// //         public void OnFoodPrepared(object source, EventArgs eventArgs)
// //         {
// //             Console.WriteLine("MailService: your food is prepared.");
// //         }
// //     }
// //     public class AppService
// //     {
// //         public void OnFoodPrepared(object source, EventArgs eventArgs)
// //         {
// //             Console.WriteLine("AppService: your food is prepared.");
// //             Console.WriteLine("SOURCE:"+source+ " " + "ARGS:"+eventArgs);
// //         }
// //     }
// //     public class FoodPreparedEventArgs : EventArgs
// //     {
// //         public Order Order { get; set; }
// //     }
// //     // Subscriber
// //     class EventsDemos{
// //         static void Main(){
// //             var order = new Order{ Item = "Pizza with extra cheese" };
// //             var orderingService = new FoodOrderingService();
// //             var appService = new AppService();
// //             var mailService = new MailService();
// //             orderingService.FoodPrepared += appService.OnFoodPrepared;
// //             orderingService.FoodPrepared += mailService.OnFoodPrepared;
// //             orderingService.PrepareOrder(order);
// //         }
// //     }
// // }

// //difine a delegate
// //define a event that uses the delegate
// //raise the event


// namespace Demo{
//     public class Order{
//         public string Item{get; set;}
//         public string Ingredients{get; set;}
//     }
//     public class AppService{
//         public void OnFoodPrepared(object sender, FoodPreparedEventArgs eventArgs){
//             Console.WriteLine($"AppService: your food '{eventArgs.Order.Item}' is prepared");
//         }
//     }

//      public class MailService{
//         public void OnFoodPrepared(object sender, FoodPreparedEventArgs eventArgs){
//             Console.WriteLine($"MailService: your food '{eventArgs.Order.Item}' is prepared");
//         }
//     }
//     public class FoodOrderingService{
//         //define a delegate
//         public delegate void FoodPreparedEventHandler(object sender, FoodPreparedEventArgs args);
//         //declare an event
//         public event FoodPreparedEventHandler FoodPrepared;
//         //Function to be used with events
//         //publisher function
//         public void PrepareOrder(Order order){
//             Console.WriteLine($"Preparing your Order '{order.Item}', please wait....");
//             Thread.Sleep(4000);
//             //After the food is ready raise the event to inform the customer
//             OnFoodPrepared(order);
//         }
//         public void OnFoodPrepared(Order order){
//             if(FoodPrepared != null){
//                 FoodPrepared(this, new FoodPreparedEventArgs{Order = order});
//                 Console.WriteLine($"Source:{this}  Args:{null}");
//             }
//         }
//     }

//     public class FoodPreparedEventArgs:EventArgs{
//         public Order Order{get; set;}
//     }
//     class Demo{
//         static void Main(){
//             var order = new Order{Item="Pizza with extra cheese"};
//             var orderingService = new FoodOrderingService();
//             var appService = new AppService();
//             var mailService = new MailService();
//             //subscribing to the Event
//             orderingService.FoodPrepared += appService.OnFoodPrepared;
//             orderingService.FoodPrepared += mailService.OnFoodPrepared;
//             //Raise the Event
//             orderingService.PrepareOrder(order);

//         }
//     }
// }
// interface ISampleInterface
// {
//     // must declare a body if it is not marked abstract, extern, or partial
//     void SampleMethod();
//     int Add(int x, int y){
//         return x+y;
//     }
//     static int Sub(int x, int y){
//         return x-y;
//     }
//     virtual int Div(int x, int y){
//         return x/y;
//     }
// }
// interface IMy:ISampleInterface{
//    int ISampleInterface.Div(int x, int y){
//         return x/y;
//     }
// }

// class ImplementationClass : ISampleInterface
// {
//     void ISampleInterface.SampleMethod()
//     {
//     }
//     public int Sub(int x, int y){
//         return (x-y)*(-1);
//     }
//     static void Main()
//     {
//         ISampleInterface obj = new ImplementationClass();
//         obj.SampleMethod();
        
//         Console.WriteLine(ISampleInterface.Sub(11,22));
//     }
// }
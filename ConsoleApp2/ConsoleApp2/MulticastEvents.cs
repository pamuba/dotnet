// using System;
// delegate void MyEventHandler();
// class MyEvent {
//  public event MyEventHandler SomeEvent;
//  public void OnSomeEvent() {
//  if(SomeEvent != null)
//  SomeEvent();
//  }
// }
// class X {
//  public void Xhandler() {
//  Console.WriteLine("Event received by X object");
//  }
// }
// class Y {
//  public void Yhandler() {
//  Console.WriteLine("Event received by Y object");
//  }
// }
// class EventDemo2 {
//  static void Handler() {
//  Console.WriteLine("Event received by EventDemo");
//  }
//  static void Main() {
//  MyEvent evt = new MyEvent();
//  X xOb = new X();
//  Y yOb = new Y();
//  // Add handlers to the event list.
//  evt.SomeEvent += Handler;
//  evt.SomeEvent += xOb.Xhandler;
//  evt.SomeEvent += yOb.Yhandler;
//  // Raise the event.
//  evt.OnSomeEvent();
//  Console.WriteLine();
//  // Remove a handler.
//  evt.SomeEvent -= xOb.Xhandler;
//  evt.OnSomeEvent();
//  }
// }
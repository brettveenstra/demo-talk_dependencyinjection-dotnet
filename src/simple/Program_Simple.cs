namespace DIDemo
{


  // http://lostechies.com/derickbailey/files/2011/03/DependencyInversionPrinciple_0278F9E2.jpg
  /*
  DEPENDENCY INVERSION PRINCIPLE:
  
  A. HIGH LEVEL MODULES SHOULD NOT DEPEND UPON LOW LEVEL MODULES.  BOTH SHOULD DEPEND UPON ABSTRACTIONS
  B. ABSTRACTIONS SHOULD NOT DEPEND UPON DETAILS BUT DETAILS SHOULD DEPEND UPON ABSTRACTIONS
  
  */
  
/*

In Simpler Terms:
Any relationships between our classes, that relationship should be stated in terms of abstractions instead of concrete implementations (e.g. Base Classes, Interfaces)

High Level modules should not create the classes they need, rather something outside the module should hand off (inject) the proper objects.

*/
  
  // Tight coupling - a change shouldn't be felt everywhere in the application
  //  (e.g. Single Responsibility principle is a very good thing)
  // Don't Repeat Yourself - there should be exactly one way to get at the information in the entire application (e.g. ConnectionString)
  
    // Most code starts out good but over times turns bad (complexity gets baked in) - strive for simplicity
  
 
 /*
 
 http://blog.ploeh.dk/2011/05/30/DesignSmellDefaultConstructor.aspx
 
"Constructor Injection is the dominating DI pattern exactly because it statically advertises dependencies and protects the integrity of those dependencies by guaranteeing that an initialized consumer is always in a consistent state"
 */

 
  internal class Program
  {
    
  }
}
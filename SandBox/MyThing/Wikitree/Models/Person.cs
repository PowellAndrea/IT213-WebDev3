namespace Wikitree.Models
{
   public class Person
   {
      public Guid Id { get; set; }
      public string CommonName { get; set; }
      public Relationship[] Relationships { get; set; }
      
   }
}

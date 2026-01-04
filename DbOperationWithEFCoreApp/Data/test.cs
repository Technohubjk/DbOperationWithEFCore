using System.ComponentModel.DataAnnotations.Schema;

namespace DbOperationWithEFCoreApp.Data
{
    [Table("Shiv")]
    public class test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

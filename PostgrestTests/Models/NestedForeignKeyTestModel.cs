using Postgrest.Attributes;
using Postgrest.Models;

namespace PostgrestTests.Models;

[Table("nested_foreign_key_test")]
public class NestedForeignKeyTestModel : BaseModel
{
    [PrimaryKey("id")] public int Id { get; set; }

    [Reference(typeof(ForeignKeyTestModel))]
    public ForeignKeyTestModel FKTestModel { get; set; }

    [Reference(typeof(User))] public User User { get; set; }
}
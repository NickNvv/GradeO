namespace GradeO.Data.Models
{
    using GradeO.Data.Common.Models;

    public class Setting : BaseDeletableModel
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}

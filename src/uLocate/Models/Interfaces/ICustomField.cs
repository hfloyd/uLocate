namespace uLocate.Models
{
    using System.Collections.Generic;

    public interface ICustomField
    {
        string Label { get; set; }

        string Alias { get; set; }

        string PropertyEditorAlias { get; set; }

        string Value { get; set; }

        int SortOrder { get; set; }

        IEnumerable<object> PreValues { get; set; } 
    }
}
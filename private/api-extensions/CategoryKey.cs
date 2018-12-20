namespace Nutanix.Powershell.Models
{

    /// <summary>Category key definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(CategoryKeyTypeConverter))]
    public partial class CategoryKey
    {

        /// <summary>
        /// Creates a new instance of <see cref="CategoryKey" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ICategoryKey FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Category key definition.
    [System.ComponentModel.TypeConverter(typeof(CategoryKeyTypeConverter))]
    public partial interface ICategoryKey {

    }
}
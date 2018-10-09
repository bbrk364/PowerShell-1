namespace Sample.API.Models
{

    /// <summary>Cluster software.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterSoftwareTypeConverter))]
    public partial class ClusterSoftware
    {

        /// <summary>
        /// Creates a new instance of <see cref="ClusterSoftware" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IClusterSoftware FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Cluster software.
    [System.ComponentModel.TypeConverter(typeof(ClusterSoftwareTypeConverter))]
    public partial interface IClusterSoftware {

    }
}
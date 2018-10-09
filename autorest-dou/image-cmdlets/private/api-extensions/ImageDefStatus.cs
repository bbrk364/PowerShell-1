namespace Sample.API.Models
{

    /// <summary>An intentful representation of a image status</summary>
    [System.ComponentModel.TypeConverter(typeof(ImageDefStatusTypeConverter))]
    public partial class ImageDefStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="ImageDefStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IImageDefStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An intentful representation of a image status
    [System.ComponentModel.TypeConverter(typeof(ImageDefStatusTypeConverter))]
    public partial interface IImageDefStatus {

    }
}
namespace Sample.API.Models
{

    /// <summary>Credentials to login server</summary>
    [System.ComponentModel.TypeConverter(typeof(CredentialsTypeConverter))]
    public partial class Credentials
    {

        /// <summary>
        /// Creates a new instance of <see cref="Credentials" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ICredentials FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Credentials to login server
    [System.ComponentModel.TypeConverter(typeof(CredentialsTypeConverter))]
    public partial interface ICredentials {

    }
}
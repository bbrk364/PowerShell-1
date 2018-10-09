namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster network entity.</summary>
    public partial class ClusterNetworkEntity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Carbon.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Carbon.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Carbon.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Carbon.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Carbon.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="ClusterNetworkEntity" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal ClusterNetworkEntity(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _address = If( json?.PropertyT<Carbon.Json.JsonObject>("address"), out var __jsonAddress) ? Sample.API.Models.Address.FromJson(__jsonAddress) : Address;
            _credentials = If( json?.PropertyT<Carbon.Json.JsonObject>("credentials"), out var __jsonCredentials) ? Sample.API.Models.Credentials.FromJson(__jsonCredentials) : Credentials;
            _proxyTypeList = If( json?.PropertyT<Carbon.Json.JsonArray>("proxy_type_list"), out var __jsonProxyTypeList) ? If( __jsonProxyTypeList, out var __w) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> __v is Carbon.Json.JsonString __u ? (string)__u : null ) ) )() : null : ProxyTypeList;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IClusterNetworkEntity.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IClusterNetworkEntity.</returns>
        public static Sample.API.Models.IClusterNetworkEntity FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ClusterNetworkEntity(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ClusterNetworkEntity" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ClusterNetworkEntity" /> as a <see cref="Carbon.Json.JsonNode" />.
        /// </returns>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.SerializationMode serializationMode)
        {
            container = container ?? new Carbon.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != Address ? (Carbon.Json.JsonNode) Address.ToJson(null) : null, "address" ,container.Add );
            AddIf( null != Credentials ? (Carbon.Json.JsonNode) Credentials.ToJson(null) : null, "credentials" ,container.Add );
            if (null != ProxyTypeList)
            {
                var __x = new Carbon.Json.XNodeArray();
                foreach( var __y in ProxyTypeList )
                {
                    AddIf(null != __y ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__y) : null ,__x.Add);
                }
                container.Add("proxy_type_list",__x);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}
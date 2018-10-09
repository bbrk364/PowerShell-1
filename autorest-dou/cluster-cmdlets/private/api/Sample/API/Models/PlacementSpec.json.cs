namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Entity placement spec</summary>
    public partial class PlacementSpec
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IPlacementSpec.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IPlacementSpec.</returns>
        public static Sample.API.Models.IPlacementSpec FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new PlacementSpec(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="PlacementSpec" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal PlacementSpec(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _entitySpecList = If( json?.PropertyT<Carbon.Json.JsonArray>("entity_spec_list"), out var __jsonEntitySpecList) ? If( __jsonEntitySpecList, out var __w) ? new System.Func<Sample.API.Models.IEntitySpec[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> Sample.API.Models.EntitySpec.FromJson(__v)  ) ) )() : null : EntitySpecList;
            _probableClusterReference = If( json?.PropertyT<Carbon.Json.JsonObject>("probable_cluster_reference"), out var __jsonProbableClusterReference) ? Sample.API.Models.ClusterReference.FromJson(__jsonProbableClusterReference) : ProbableClusterReference;
            _tenantUuid = If( json?.PropertyT<Carbon.Json.JsonString>("tenant_uuid"), out var __jsonTenantUuid) ? (string)__jsonTenantUuid : (string)TenantUuid;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="PlacementSpec" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PlacementSpec" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            if (null != EntitySpecList)
            {
                var __x = new Carbon.Json.XNodeArray();
                foreach( var __y in EntitySpecList )
                {
                    AddIf(__y?.ToJson(null) ,__x.Add);
                }
                container.Add("entity_spec_list",__x);
            }
            AddIf( null != ProbableClusterReference ? (Carbon.Json.JsonNode) ProbableClusterReference.ToJson(null) : null, "probable_cluster_reference" ,container.Add );
            AddIf( null != TenantUuid ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(TenantUuid) : null, "tenant_uuid" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}
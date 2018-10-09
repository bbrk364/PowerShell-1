namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a image status</summary>
    public partial class ImageDefStatus : Sample.API.Models.IImageDefStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AvailabilityZoneReference property</summary>
        private Sample.API.Models.IAvailabilityZoneReference _availabilityZoneReference;

        /// <summary>The reference to a availability_zone</summary>
        public Sample.API.Models.IAvailabilityZoneReference AvailabilityZoneReference
        {
            get
            {
                return this._availabilityZoneReference;
            }
            set
            {
                this._availabilityZoneReference = value;
            }
        }
        /// <summary>Backing field for ClusterReference property</summary>
        private Sample.API.Models.IClusterReference _clusterReference;

        /// <summary>The reference to a cluster</summary>
        public Sample.API.Models.IClusterReference ClusterReference
        {
            get
            {
                return this._clusterReference;
            }
            set
            {
                this._clusterReference = value;
            }
        }
        /// <summary>Backing field for Description property</summary>
        private string _description;

        /// <summary>A description for image.</summary>
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for MessageList property</summary>
        private Sample.API.Models.IMessageResource[] _messageList;

        /// <summary>Any error messages for the image, if in an error state.</summary>
        public Sample.API.Models.IMessageResource[] MessageList
        {
            get
            {
                return this._messageList;
            }
            set
            {
                this._messageList = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>image Name.</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for Resources property</summary>
        private Sample.API.Models.IImageResourcesDefStatus _resources;

        /// <summary>Describes the image status resources object.</summary>
        public Sample.API.Models.IImageResourcesDefStatus Resources
        {
            get
            {
                return this._resources;
            }
            set
            {
                this._resources = value;
            }
        }
        /// <summary>Backing field for State property</summary>
        private string _state;

        /// <summary>The state of the image.</summary>
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Creates an new <see cref="ImageDefStatus" /> instance.</summary>
        public ImageDefStatus()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertObjectIsValid(nameof(AvailabilityZoneReference), AvailabilityZoneReference);
            await eventListener.AssertObjectIsValid(nameof(ClusterReference), ClusterReference);
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// An intentful representation of a image status
    public partial interface IImageDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IAvailabilityZoneReference AvailabilityZoneReference { get; set; }
        Sample.API.Models.IClusterReference ClusterReference { get; set; }
        string Description { get; set; }
        Sample.API.Models.IMessageResource[] MessageList { get; set; }
        string Name { get; set; }
        Sample.API.Models.IImageResourcesDefStatus Resources { get; set; }
        string State { get; set; }
    }
}
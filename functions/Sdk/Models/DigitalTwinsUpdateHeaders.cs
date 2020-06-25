// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AdtExplorer.Functions.Sdk.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Update operation.
    /// </summary>
    public partial class DigitalTwinsUpdateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the DigitalTwinsUpdateHeaders class.
        /// </summary>
        public DigitalTwinsUpdateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DigitalTwinsUpdateHeaders class.
        /// </summary>
        /// <param name="eTag">Weak Etag.</param>
        public DigitalTwinsUpdateHeaders(string eTag = default(string))
        {
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets weak Etag.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

    }
}
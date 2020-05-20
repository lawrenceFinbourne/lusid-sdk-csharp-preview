/* 
 * LUSID API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.10.1392
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// DeleteInstrumentResponse
    /// </summary>
    [DataContract]
    public partial class DeleteInstrumentResponse :  IEquatable<DeleteInstrumentResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInstrumentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteInstrumentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInstrumentResponse" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="asAt">The asAt datetime at which the instrument was deleted. (required).</param>
        /// <param name="links">links.</param>
        public DeleteInstrumentResponse(string href = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), List<Link> links = default(List<Link>))
        {
            // to ensure "asAt" is required (not null)
            if (asAt == null)
            {
                throw new InvalidDataException("asAt is a required property for DeleteInstrumentResponse and cannot be null");
            }
            else
            {
                this.AsAt = asAt;
            }
            
            this.Href = href;
            this.Links = links;
        }
        
        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// The asAt datetime at which the instrument was deleted.
        /// </summary>
        /// <value>The asAt datetime at which the instrument was deleted.</value>
        [DataMember(Name="asAt", EmitDefaultValue=false)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInstrumentResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteInstrumentResponse);
        }

        /// <summary>
        /// Returns true if DeleteInstrumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteInstrumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteInstrumentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.AsAt != null)
                    hashCode = hashCode * 59 + this.AsAt.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}

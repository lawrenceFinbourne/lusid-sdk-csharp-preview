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
    /// PortfolioDetails
    /// </summary>
    [DataContract]
    public partial class PortfolioDetails :  IEquatable<PortfolioDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioDetails" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="originPortfolioId">originPortfolioId (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="baseCurrency">The base currency of the transaction portfolio. (required).</param>
        /// <param name="corporateActionSourceId">corporateActionSourceId.</param>
        /// <param name="subHoldingKeys">subHoldingKeys.</param>
        /// <param name="links">links.</param>
        public PortfolioDetails(string href = default(string), ResourceId originPortfolioId = default(ResourceId), Version version = default(Version), string baseCurrency = default(string), ResourceId corporateActionSourceId = default(ResourceId), List<string> subHoldingKeys = default(List<string>), List<Link> links = default(List<Link>))
        {
            // to ensure "originPortfolioId" is required (not null)
            if (originPortfolioId == null)
            {
                throw new InvalidDataException("originPortfolioId is a required property for PortfolioDetails and cannot be null");
            }
            else
            {
                this.OriginPortfolioId = originPortfolioId;
            }
            
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for PortfolioDetails and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            
            // to ensure "baseCurrency" is required (not null)
            if (baseCurrency == null)
            {
                throw new InvalidDataException("baseCurrency is a required property for PortfolioDetails and cannot be null");
            }
            else
            {
                this.BaseCurrency = baseCurrency;
            }
            
            this.Href = href;
            this.CorporateActionSourceId = corporateActionSourceId;
            this.SubHoldingKeys = subHoldingKeys;
            this.Links = links;
        }
        
        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets OriginPortfolioId
        /// </summary>
        [DataMember(Name="originPortfolioId", EmitDefaultValue=false)]
        public ResourceId OriginPortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// The base currency of the transaction portfolio.
        /// </summary>
        /// <value>The base currency of the transaction portfolio.</value>
        [DataMember(Name="baseCurrency", EmitDefaultValue=false)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CorporateActionSourceId
        /// </summary>
        [DataMember(Name="corporateActionSourceId", EmitDefaultValue=false)]
        public ResourceId CorporateActionSourceId { get; set; }

        /// <summary>
        /// Gets or Sets SubHoldingKeys
        /// </summary>
        [DataMember(Name="subHoldingKeys", EmitDefaultValue=false)]
        public List<string> SubHoldingKeys { get; set; }

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
            sb.Append("class PortfolioDetails {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  OriginPortfolioId: ").Append(OriginPortfolioId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  CorporateActionSourceId: ").Append(CorporateActionSourceId).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
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
            return this.Equals(input as PortfolioDetails);
        }

        /// <summary>
        /// Returns true if PortfolioDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioDetails input)
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
                    this.OriginPortfolioId == input.OriginPortfolioId ||
                    (this.OriginPortfolioId != null &&
                    this.OriginPortfolioId.Equals(input.OriginPortfolioId))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    (this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(input.BaseCurrency))
                ) && 
                (
                    this.CorporateActionSourceId == input.CorporateActionSourceId ||
                    (this.CorporateActionSourceId != null &&
                    this.CorporateActionSourceId.Equals(input.CorporateActionSourceId))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
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
                if (this.OriginPortfolioId != null)
                    hashCode = hashCode * 59 + this.OriginPortfolioId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.BaseCurrency != null)
                    hashCode = hashCode * 59 + this.BaseCurrency.GetHashCode();
                if (this.CorporateActionSourceId != null)
                    hashCode = hashCode * 59 + this.CorporateActionSourceId.GetHashCode();
                if (this.SubHoldingKeys != null)
                    hashCode = hashCode * 59 + this.SubHoldingKeys.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}

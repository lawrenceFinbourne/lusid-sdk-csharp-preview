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
    /// PortfoliosReconciliationRequestPreview
    /// </summary>
    [DataContract]
    public partial class PortfoliosReconciliationRequestPreview :  IEquatable<PortfoliosReconciliationRequestPreview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosReconciliationRequestPreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfoliosReconciliationRequestPreview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfoliosReconciliationRequestPreview" /> class.
        /// </summary>
        /// <param name="tolerance">Tolerance to be included for the units and cost..</param>
        /// <param name="left">left (required).</param>
        /// <param name="right">right (required).</param>
        /// <param name="instrumentPropertyKeys">Instrument properties to be included with any identified breaks. These properties will be in the effective and AsAt dates of the left portfolio (required).</param>
        public PortfoliosReconciliationRequestPreview(Dictionary<string, Tolerance> tolerance = default(Dictionary<string, Tolerance>), PortfolioReconciliationRequest left = default(PortfolioReconciliationRequest), PortfolioReconciliationRequest right = default(PortfolioReconciliationRequest), List<string> instrumentPropertyKeys = default(List<string>))
        {
            // to ensure "left" is required (not null)
            if (left == null)
            {
                throw new InvalidDataException("left is a required property for PortfoliosReconciliationRequestPreview and cannot be null");
            }
            else
            {
                this.Left = left;
            }
            
            // to ensure "right" is required (not null)
            if (right == null)
            {
                throw new InvalidDataException("right is a required property for PortfoliosReconciliationRequestPreview and cannot be null");
            }
            else
            {
                this.Right = right;
            }
            
            // to ensure "instrumentPropertyKeys" is required (not null)
            if (instrumentPropertyKeys == null)
            {
                throw new InvalidDataException("instrumentPropertyKeys is a required property for PortfoliosReconciliationRequestPreview and cannot be null");
            }
            else
            {
                this.InstrumentPropertyKeys = instrumentPropertyKeys;
            }
            
            this.Tolerance = tolerance;
        }
        
        /// <summary>
        /// Tolerance to be included for the units and cost.
        /// </summary>
        /// <value>Tolerance to be included for the units and cost.</value>
        [DataMember(Name="tolerance", EmitDefaultValue=false)]
        public Dictionary<string, Tolerance> Tolerance { get; set; }

        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name="left", EmitDefaultValue=false)]
        public PortfolioReconciliationRequest Left { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name="right", EmitDefaultValue=false)]
        public PortfolioReconciliationRequest Right { get; set; }

        /// <summary>
        /// Instrument properties to be included with any identified breaks. These properties will be in the effective and AsAt dates of the left portfolio
        /// </summary>
        /// <value>Instrument properties to be included with any identified breaks. These properties will be in the effective and AsAt dates of the left portfolio</value>
        [DataMember(Name="instrumentPropertyKeys", EmitDefaultValue=false)]
        public List<string> InstrumentPropertyKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortfoliosReconciliationRequestPreview {\n");
            sb.Append("  Tolerance: ").Append(Tolerance).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  InstrumentPropertyKeys: ").Append(InstrumentPropertyKeys).Append("\n");
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
            return this.Equals(input as PortfoliosReconciliationRequestPreview);
        }

        /// <summary>
        /// Returns true if PortfoliosReconciliationRequestPreview instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfoliosReconciliationRequestPreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfoliosReconciliationRequestPreview input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tolerance == input.Tolerance ||
                    this.Tolerance != null &&
                    input.Tolerance != null &&
                    this.Tolerance.SequenceEqual(input.Tolerance)
                ) && 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.InstrumentPropertyKeys == input.InstrumentPropertyKeys ||
                    this.InstrumentPropertyKeys != null &&
                    input.InstrumentPropertyKeys != null &&
                    this.InstrumentPropertyKeys.SequenceEqual(input.InstrumentPropertyKeys)
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
                if (this.Tolerance != null)
                    hashCode = hashCode * 59 + this.Tolerance.GetHashCode();
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Right != null)
                    hashCode = hashCode * 59 + this.Right.GetHashCode();
                if (this.InstrumentPropertyKeys != null)
                    hashCode = hashCode * 59 + this.InstrumentPropertyKeys.GetHashCode();
                return hashCode;
            }
        }
    }

}

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
    /// The quote id, value and lineage of the quotes all keyed by a unique correlation id.
    /// </summary>
    [DataContract]
    public partial class Quote :  IEquatable<Quote>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Quote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Quote" /> class.
        /// </summary>
        /// <param name="quoteId">quoteId (required).</param>
        /// <param name="metricValue">metricValue.</param>
        /// <param name="lineage">Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;..</param>
        /// <param name="cutLabel">The cut label that this quote was updated or inserted with..</param>
        /// <param name="uploadedBy">The unique id of the user that updated or inserted the quote. (required).</param>
        /// <param name="asAt">The asAt datetime at which the quote was committed to LUSID. (required).</param>
        public Quote(QuoteId quoteId = default(QuoteId), MetricValue metricValue = default(MetricValue), string lineage = default(string), string cutLabel = default(string), string uploadedBy = default(string), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // to ensure "quoteId" is required (not null)
            if (quoteId == null)
            {
                throw new InvalidDataException("quoteId is a required property for Quote and cannot be null");
            }
            else
            {
                this.QuoteId = quoteId;
            }
            
            // to ensure "uploadedBy" is required (not null)
            if (uploadedBy == null)
            {
                throw new InvalidDataException("uploadedBy is a required property for Quote and cannot be null");
            }
            else
            {
                this.UploadedBy = uploadedBy;
            }
            
            // to ensure "asAt" is required (not null)
            if (asAt == null)
            {
                throw new InvalidDataException("asAt is a required property for Quote and cannot be null");
            }
            else
            {
                this.AsAt = asAt;
            }
            
            this.MetricValue = metricValue;
            this.Lineage = lineage;
            this.CutLabel = cutLabel;
        }
        
        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name="quoteId", EmitDefaultValue=false)]
        public QuoteId QuoteId { get; set; }

        /// <summary>
        /// Gets or Sets MetricValue
        /// </summary>
        [DataMember(Name="metricValue", EmitDefaultValue=false)]
        public MetricValue MetricValue { get; set; }

        /// <summary>
        /// Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.
        /// </summary>
        /// <value>Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.</value>
        [DataMember(Name="lineage", EmitDefaultValue=false)]
        public string Lineage { get; set; }

        /// <summary>
        /// The cut label that this quote was updated or inserted with.
        /// </summary>
        /// <value>The cut label that this quote was updated or inserted with.</value>
        [DataMember(Name="cutLabel", EmitDefaultValue=false)]
        public string CutLabel { get; set; }

        /// <summary>
        /// The unique id of the user that updated or inserted the quote.
        /// </summary>
        /// <value>The unique id of the user that updated or inserted the quote.</value>
        [DataMember(Name="uploadedBy", EmitDefaultValue=false)]
        public string UploadedBy { get; set; }

        /// <summary>
        /// The asAt datetime at which the quote was committed to LUSID.
        /// </summary>
        /// <value>The asAt datetime at which the quote was committed to LUSID.</value>
        [DataMember(Name="asAt", EmitDefaultValue=false)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quote {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  MetricValue: ").Append(MetricValue).Append("\n");
            sb.Append("  Lineage: ").Append(Lineage).Append("\n");
            sb.Append("  CutLabel: ").Append(CutLabel).Append("\n");
            sb.Append("  UploadedBy: ").Append(UploadedBy).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
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
            return this.Equals(input as Quote);
        }

        /// <summary>
        /// Returns true if Quote instances are equal
        /// </summary>
        /// <param name="input">Instance of Quote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteId == input.QuoteId ||
                    (this.QuoteId != null &&
                    this.QuoteId.Equals(input.QuoteId))
                ) && 
                (
                    this.MetricValue == input.MetricValue ||
                    (this.MetricValue != null &&
                    this.MetricValue.Equals(input.MetricValue))
                ) && 
                (
                    this.Lineage == input.Lineage ||
                    (this.Lineage != null &&
                    this.Lineage.Equals(input.Lineage))
                ) && 
                (
                    this.CutLabel == input.CutLabel ||
                    (this.CutLabel != null &&
                    this.CutLabel.Equals(input.CutLabel))
                ) && 
                (
                    this.UploadedBy == input.UploadedBy ||
                    (this.UploadedBy != null &&
                    this.UploadedBy.Equals(input.UploadedBy))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
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
                if (this.QuoteId != null)
                    hashCode = hashCode * 59 + this.QuoteId.GetHashCode();
                if (this.MetricValue != null)
                    hashCode = hashCode * 59 + this.MetricValue.GetHashCode();
                if (this.Lineage != null)
                    hashCode = hashCode * 59 + this.Lineage.GetHashCode();
                if (this.CutLabel != null)
                    hashCode = hashCode * 59 + this.CutLabel.GetHashCode();
                if (this.UploadedBy != null)
                    hashCode = hashCode * 59 + this.UploadedBy.GetHashCode();
                if (this.AsAt != null)
                    hashCode = hashCode * 59 + this.AsAt.GetHashCode();
                return hashCode;
            }
        }
    }

}

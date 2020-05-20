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
using JsonSubTypes;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// Base class in hierarchy for LUSID Instruments. Valuation would normally be performed through passing LUSID a Code for a portfolio to be valued.  In that case the set of instruments have already been uploaded. Equally, one might wish to pass in a set of instruments directly and have LUSID  value the inlined set. This the base instrument for this case.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "LusidInstrument")]
    [JsonSubtypes.KnownSubType(typeof(FxForwardInstrument), "FxForwardInstrument")]
    [JsonSubtypes.KnownSubType(typeof(EquityOption), "EquityOption")]
    [JsonSubtypes.KnownSubType(typeof(BondInstrument), "BondInstrument")]
    [JsonSubtypes.KnownSubType(typeof(FxOption), "FxOption")]
    [JsonSubtypes.KnownSubType(typeof(Swaption), "Swaption")]
    [JsonSubtypes.KnownSubType(typeof(SwapInstrument), "SwapInstrument")]
    [JsonSubtypes.KnownSubType(typeof(CdsInstrument), "CdsInstrument")]
    public partial class LusidInstrument :  IEquatable<LusidInstrument>
    {
        /// <summary>
        /// Instrument type, must be property for JSON.
        /// </summary>
        /// <value>Instrument type, must be property for JSON.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentTypeEnum
        {
            /// <summary>
            /// Enum QuotedSecurity for value: QuotedSecurity
            /// </summary>
            [EnumMember(Value = "QuotedSecurity")]
            QuotedSecurity = 1,

            /// <summary>
            /// Enum InterestRateSwap for value: InterestRateSwap
            /// </summary>
            [EnumMember(Value = "InterestRateSwap")]
            InterestRateSwap = 2,

            /// <summary>
            /// Enum FxForward for value: FxForward
            /// </summary>
            [EnumMember(Value = "FxForward")]
            FxForward = 3,

            /// <summary>
            /// Enum Exotic for value: Exotic
            /// </summary>
            [EnumMember(Value = "Exotic")]
            Exotic = 4,

            /// <summary>
            /// Enum FxOption for value: FxOption
            /// </summary>
            [EnumMember(Value = "FxOption")]
            FxOption = 5,

            /// <summary>
            /// Enum CreditDefaultSwap for value: CreditDefaultSwap
            /// </summary>
            [EnumMember(Value = "CreditDefaultSwap")]
            CreditDefaultSwap = 6,

            /// <summary>
            /// Enum InterestRateSwaption for value: InterestRateSwaption
            /// </summary>
            [EnumMember(Value = "InterestRateSwaption")]
            InterestRateSwaption = 7,

            /// <summary>
            /// Enum Bond for value: Bond
            /// </summary>
            [EnumMember(Value = "Bond")]
            Bond = 8,

            /// <summary>
            /// Enum EquityOption for value: EquityOption
            /// </summary>
            [EnumMember(Value = "EquityOption")]
            EquityOption = 9,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 10

        }

        /// <summary>
        /// Instrument type, must be property for JSON.
        /// </summary>
        /// <value>Instrument type, must be property for JSON.</value>
        [DataMember(Name="instrumentType", EmitDefaultValue=false)]
        public InstrumentTypeEnum InstrumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidInstrument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LusidInstrument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidInstrument" /> class.
        /// </summary>
        /// <param name="instrumentType">Instrument type, must be property for JSON. (required).</param>
        public LusidInstrument(InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            // to ensure "instrumentType" is required (not null)
            if (instrumentType == null)
            {
                throw new InvalidDataException("instrumentType is a required property for LusidInstrument and cannot be null");
            }
            else
            {
                this.InstrumentType = instrumentType;
            }
            
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LusidInstrument {\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
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
            return this.Equals(input as LusidInstrument);
        }

        /// <summary>
        /// Returns true if LusidInstrument instances are equal
        /// </summary>
        /// <param name="input">Instance of LusidInstrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LusidInstrument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentType == input.InstrumentType ||
                    (this.InstrumentType != null &&
                    this.InstrumentType.Equals(input.InstrumentType))
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
                if (this.InstrumentType != null)
                    hashCode = hashCode * 59 + this.InstrumentType.GetHashCode();
                return hashCode;
            }
        }
    }

}

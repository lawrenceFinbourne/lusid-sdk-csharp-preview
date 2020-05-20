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
    /// FxForwardInstrumentAllOf
    /// </summary>
    [DataContract]
    public partial class FxForwardInstrumentAllOf :  IEquatable<FxForwardInstrumentAllOf>
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
        /// Initializes a new instance of the <see cref="FxForwardInstrumentAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxForwardInstrumentAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardInstrumentAllOf" /> class.
        /// </summary>
        /// <param name="domAmount">The amount that is to be paid in the domestic currency on the maturity date. (required).</param>
        /// <param name="fgnAmount">The amount that is to be paid in the foreign currency on the maturity date (required).</param>
        /// <param name="isNdf">Is the contract an Fx-Forward of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the domestic currency based on  the change in fx-rate vs  a reference rate is used..</param>
        /// <param name="fixingDate">The fixing date. Its presence determines the NDF status of the instrument..</param>
        /// <param name="fgnCcy">The foreign (other) currency of the instrument. In the NDF case, only payments are made in the domestic currency.  For the outright forward, currencies are exchanged. By domestic is then that of the portfolio. (required).</param>
        /// <param name="refSpotRate">The reference Fx Spot rate for currency pair Foreign-Domestic that was seen on the trade start date (time)..</param>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="maturityDate">The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="instrumentType">Instrument type, must be property for JSON. (required).</param>
        public FxForwardInstrumentAllOf(decimal? domAmount = default(decimal?), decimal? fgnAmount = default(decimal?), bool? isNdf = default(bool?), DateTimeOffset? fixingDate = default(DateTimeOffset?), string fgnCcy = default(string), decimal? refSpotRate = default(decimal?), DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? maturityDate = default(DateTimeOffset?), string domCcy = default(string), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            // to ensure "domAmount" is required (not null)
            if (domAmount == null)
            {
                throw new InvalidDataException("domAmount is a required property for FxForwardInstrumentAllOf and cannot be null");
            }
            else
            {
                this.DomAmount = domAmount;
            }
            
            // to ensure "fgnAmount" is required (not null)
            if (fgnAmount == null)
            {
                throw new InvalidDataException("fgnAmount is a required property for FxForwardInstrumentAllOf and cannot be null");
            }
            else
            {
                this.FgnAmount = fgnAmount;
            }
            
            // to ensure "fgnCcy" is required (not null)
            if (fgnCcy == null)
            {
                throw new InvalidDataException("fgnCcy is a required property for FxForwardInstrumentAllOf and cannot be null");
            }
            else
            {
                this.FgnCcy = fgnCcy;
            }
            
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for FxForwardInstrumentAllOf and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            
            // to ensure "maturityDate" is required (not null)
            if (maturityDate == null)
            {
                throw new InvalidDataException("maturityDate is a required property for FxForwardInstrumentAllOf and cannot be null");
            }
            else
            {
                this.MaturityDate = maturityDate;
            }
            
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new InvalidDataException("domCcy is a required property for FxForwardInstrumentAllOf and cannot be null");
            }
            else
            {
                this.DomCcy = domCcy;
            }
            
            // to ensure "instrumentType" is required (not null)
            if (instrumentType == null)
            {
                throw new InvalidDataException("instrumentType is a required property for FxForwardInstrumentAllOf and cannot be null");
            }
            else
            {
                this.InstrumentType = instrumentType;
            }
            
            this.IsNdf = isNdf;
            this.FixingDate = fixingDate;
            this.RefSpotRate = refSpotRate;
        }
        
        /// <summary>
        /// The amount that is to be paid in the domestic currency on the maturity date.
        /// </summary>
        /// <value>The amount that is to be paid in the domestic currency on the maturity date.</value>
        [DataMember(Name="domAmount", EmitDefaultValue=false)]
        public decimal? DomAmount { get; set; }

        /// <summary>
        /// The amount that is to be paid in the foreign currency on the maturity date
        /// </summary>
        /// <value>The amount that is to be paid in the foreign currency on the maturity date</value>
        [DataMember(Name="fgnAmount", EmitDefaultValue=false)]
        public decimal? FgnAmount { get; set; }

        /// <summary>
        /// Is the contract an Fx-Forward of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the domestic currency based on  the change in fx-rate vs  a reference rate is used.
        /// </summary>
        /// <value>Is the contract an Fx-Forward of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the domestic currency based on  the change in fx-rate vs  a reference rate is used.</value>
        [DataMember(Name="isNdf", EmitDefaultValue=false)]
        public bool? IsNdf { get; set; }

        /// <summary>
        /// The fixing date. Its presence determines the NDF status of the instrument.
        /// </summary>
        /// <value>The fixing date. Its presence determines the NDF status of the instrument.</value>
        [DataMember(Name="fixingDate", EmitDefaultValue=false)]
        public DateTimeOffset? FixingDate { get; set; }

        /// <summary>
        /// The foreign (other) currency of the instrument. In the NDF case, only payments are made in the domestic currency.  For the outright forward, currencies are exchanged. By domestic is then that of the portfolio.
        /// </summary>
        /// <value>The foreign (other) currency of the instrument. In the NDF case, only payments are made in the domestic currency.  For the outright forward, currencies are exchanged. By domestic is then that of the portfolio.</value>
        [DataMember(Name="fgnCcy", EmitDefaultValue=false)]
        public string FgnCcy { get; set; }

        /// <summary>
        /// The reference Fx Spot rate for currency pair Foreign-Domestic that was seen on the trade start date (time).
        /// </summary>
        /// <value>The reference Fx Spot rate for currency pair Foreign-Domestic that was seen on the trade start date (time).</value>
        [DataMember(Name="refSpotRate", EmitDefaultValue=false)]
        public decimal? RefSpotRate { get; set; }

        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date
        /// </summary>
        /// <value>The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date</value>
        [DataMember(Name="maturityDate", EmitDefaultValue=false)]
        public DateTimeOffset? MaturityDate { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name="domCcy", EmitDefaultValue=false)]
        public string DomCcy { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FxForwardInstrumentAllOf {\n");
            sb.Append("  DomAmount: ").Append(DomAmount).Append("\n");
            sb.Append("  FgnAmount: ").Append(FgnAmount).Append("\n");
            sb.Append("  IsNdf: ").Append(IsNdf).Append("\n");
            sb.Append("  FixingDate: ").Append(FixingDate).Append("\n");
            sb.Append("  FgnCcy: ").Append(FgnCcy).Append("\n");
            sb.Append("  RefSpotRate: ").Append(RefSpotRate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
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
            return this.Equals(input as FxForwardInstrumentAllOf);
        }

        /// <summary>
        /// Returns true if FxForwardInstrumentAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of FxForwardInstrumentAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxForwardInstrumentAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomAmount == input.DomAmount ||
                    (this.DomAmount != null &&
                    this.DomAmount.Equals(input.DomAmount))
                ) && 
                (
                    this.FgnAmount == input.FgnAmount ||
                    (this.FgnAmount != null &&
                    this.FgnAmount.Equals(input.FgnAmount))
                ) && 
                (
                    this.IsNdf == input.IsNdf ||
                    (this.IsNdf != null &&
                    this.IsNdf.Equals(input.IsNdf))
                ) && 
                (
                    this.FixingDate == input.FixingDate ||
                    (this.FixingDate != null &&
                    this.FixingDate.Equals(input.FixingDate))
                ) && 
                (
                    this.FgnCcy == input.FgnCcy ||
                    (this.FgnCcy != null &&
                    this.FgnCcy.Equals(input.FgnCcy))
                ) && 
                (
                    this.RefSpotRate == input.RefSpotRate ||
                    (this.RefSpotRate != null &&
                    this.RefSpotRate.Equals(input.RefSpotRate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && 
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
                if (this.DomAmount != null)
                    hashCode = hashCode * 59 + this.DomAmount.GetHashCode();
                if (this.FgnAmount != null)
                    hashCode = hashCode * 59 + this.FgnAmount.GetHashCode();
                if (this.IsNdf != null)
                    hashCode = hashCode * 59 + this.IsNdf.GetHashCode();
                if (this.FixingDate != null)
                    hashCode = hashCode * 59 + this.FixingDate.GetHashCode();
                if (this.FgnCcy != null)
                    hashCode = hashCode * 59 + this.FgnCcy.GetHashCode();
                if (this.RefSpotRate != null)
                    hashCode = hashCode * 59 + this.RefSpotRate.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.MaturityDate != null)
                    hashCode = hashCode * 59 + this.MaturityDate.GetHashCode();
                if (this.DomCcy != null)
                    hashCode = hashCode * 59 + this.DomCcy.GetHashCode();
                if (this.InstrumentType != null)
                    hashCode = hashCode * 59 + this.InstrumentType.GetHashCode();
                return hashCode;
            }
        }
    }

}

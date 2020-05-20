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
    /// RealisedGainLoss
    /// </summary>
    [DataContract]
    public partial class RealisedGainLoss :  IEquatable<RealisedGainLoss>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealisedGainLoss" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RealisedGainLoss() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RealisedGainLoss" /> class.
        /// </summary>
        /// <param name="costTradeCcy">costTradeCcy (required).</param>
        /// <param name="costPortfolioCcy">costPortfolioCcy (required).</param>
        /// <param name="realisedTradeCcy">realisedTradeCcy (required).</param>
        /// <param name="realisedTotal">realisedTotal (required).</param>
        /// <param name="realisedMarket">realisedMarket.</param>
        /// <param name="realisedCurrency">realisedCurrency.</param>
        public RealisedGainLoss(CurrencyAndAmount costTradeCcy = default(CurrencyAndAmount), CurrencyAndAmount costPortfolioCcy = default(CurrencyAndAmount), CurrencyAndAmount realisedTradeCcy = default(CurrencyAndAmount), CurrencyAndAmount realisedTotal = default(CurrencyAndAmount), CurrencyAndAmount realisedMarket = default(CurrencyAndAmount), CurrencyAndAmount realisedCurrency = default(CurrencyAndAmount))
        {
            // to ensure "costTradeCcy" is required (not null)
            if (costTradeCcy == null)
            {
                throw new InvalidDataException("costTradeCcy is a required property for RealisedGainLoss and cannot be null");
            }
            else
            {
                this.CostTradeCcy = costTradeCcy;
            }
            
            // to ensure "costPortfolioCcy" is required (not null)
            if (costPortfolioCcy == null)
            {
                throw new InvalidDataException("costPortfolioCcy is a required property for RealisedGainLoss and cannot be null");
            }
            else
            {
                this.CostPortfolioCcy = costPortfolioCcy;
            }
            
            // to ensure "realisedTradeCcy" is required (not null)
            if (realisedTradeCcy == null)
            {
                throw new InvalidDataException("realisedTradeCcy is a required property for RealisedGainLoss and cannot be null");
            }
            else
            {
                this.RealisedTradeCcy = realisedTradeCcy;
            }
            
            // to ensure "realisedTotal" is required (not null)
            if (realisedTotal == null)
            {
                throw new InvalidDataException("realisedTotal is a required property for RealisedGainLoss and cannot be null");
            }
            else
            {
                this.RealisedTotal = realisedTotal;
            }
            
            this.RealisedMarket = realisedMarket;
            this.RealisedCurrency = realisedCurrency;
        }
        
        /// <summary>
        /// The unqiue Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with.
        /// </summary>
        /// <value>The unqiue Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with.</value>
        [DataMember(Name="instrumentUid", EmitDefaultValue=false)]
        public string InstrumentUid { get; private set; }

        /// <summary>
        /// The number of units of the associated instrument against which the gain or loss has been realised.
        /// </summary>
        /// <value>The number of units of the associated instrument against which the gain or loss has been realised.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public decimal? Units { get; private set; }

        /// <summary>
        /// The effective datetime that the units associated with this gain or loss where originally purchased.
        /// </summary>
        /// <value>The effective datetime that the units associated with this gain or loss where originally purchased.</value>
        [DataMember(Name="purchaseTradeDate", EmitDefaultValue=false)]
        public DateTimeOffset? PurchaseTradeDate { get; private set; }

        /// <summary>
        /// The effective datetime that the units associated with this gain or loss where originally settled.
        /// </summary>
        /// <value>The effective datetime that the units associated with this gain or loss where originally settled.</value>
        [DataMember(Name="purchaseSettlementDate", EmitDefaultValue=false)]
        public DateTimeOffset? PurchaseSettlementDate { get; private set; }

        /// <summary>
        /// The purchase price of each unit associated with this gain or loss.
        /// </summary>
        /// <value>The purchase price of each unit associated with this gain or loss.</value>
        [DataMember(Name="purchasePrice", EmitDefaultValue=false)]
        public decimal? PurchasePrice { get; private set; }

        /// <summary>
        /// Gets or Sets CostTradeCcy
        /// </summary>
        [DataMember(Name="costTradeCcy", EmitDefaultValue=false)]
        public CurrencyAndAmount CostTradeCcy { get; set; }

        /// <summary>
        /// Gets or Sets CostPortfolioCcy
        /// </summary>
        [DataMember(Name="costPortfolioCcy", EmitDefaultValue=false)]
        public CurrencyAndAmount CostPortfolioCcy { get; set; }

        /// <summary>
        /// Gets or Sets RealisedTradeCcy
        /// </summary>
        [DataMember(Name="realisedTradeCcy", EmitDefaultValue=false)]
        public CurrencyAndAmount RealisedTradeCcy { get; set; }

        /// <summary>
        /// Gets or Sets RealisedTotal
        /// </summary>
        [DataMember(Name="realisedTotal", EmitDefaultValue=false)]
        public CurrencyAndAmount RealisedTotal { get; set; }

        /// <summary>
        /// Gets or Sets RealisedMarket
        /// </summary>
        [DataMember(Name="realisedMarket", EmitDefaultValue=false)]
        public CurrencyAndAmount RealisedMarket { get; set; }

        /// <summary>
        /// Gets or Sets RealisedCurrency
        /// </summary>
        [DataMember(Name="realisedCurrency", EmitDefaultValue=false)]
        public CurrencyAndAmount RealisedCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealisedGainLoss {\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  PurchaseTradeDate: ").Append(PurchaseTradeDate).Append("\n");
            sb.Append("  PurchaseSettlementDate: ").Append(PurchaseSettlementDate).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  CostTradeCcy: ").Append(CostTradeCcy).Append("\n");
            sb.Append("  CostPortfolioCcy: ").Append(CostPortfolioCcy).Append("\n");
            sb.Append("  RealisedTradeCcy: ").Append(RealisedTradeCcy).Append("\n");
            sb.Append("  RealisedTotal: ").Append(RealisedTotal).Append("\n");
            sb.Append("  RealisedMarket: ").Append(RealisedMarket).Append("\n");
            sb.Append("  RealisedCurrency: ").Append(RealisedCurrency).Append("\n");
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
            return this.Equals(input as RealisedGainLoss);
        }

        /// <summary>
        /// Returns true if RealisedGainLoss instances are equal
        /// </summary>
        /// <param name="input">Instance of RealisedGainLoss to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealisedGainLoss input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.PurchaseTradeDate == input.PurchaseTradeDate ||
                    (this.PurchaseTradeDate != null &&
                    this.PurchaseTradeDate.Equals(input.PurchaseTradeDate))
                ) && 
                (
                    this.PurchaseSettlementDate == input.PurchaseSettlementDate ||
                    (this.PurchaseSettlementDate != null &&
                    this.PurchaseSettlementDate.Equals(input.PurchaseSettlementDate))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.CostTradeCcy == input.CostTradeCcy ||
                    (this.CostTradeCcy != null &&
                    this.CostTradeCcy.Equals(input.CostTradeCcy))
                ) && 
                (
                    this.CostPortfolioCcy == input.CostPortfolioCcy ||
                    (this.CostPortfolioCcy != null &&
                    this.CostPortfolioCcy.Equals(input.CostPortfolioCcy))
                ) && 
                (
                    this.RealisedTradeCcy == input.RealisedTradeCcy ||
                    (this.RealisedTradeCcy != null &&
                    this.RealisedTradeCcy.Equals(input.RealisedTradeCcy))
                ) && 
                (
                    this.RealisedTotal == input.RealisedTotal ||
                    (this.RealisedTotal != null &&
                    this.RealisedTotal.Equals(input.RealisedTotal))
                ) && 
                (
                    this.RealisedMarket == input.RealisedMarket ||
                    (this.RealisedMarket != null &&
                    this.RealisedMarket.Equals(input.RealisedMarket))
                ) && 
                (
                    this.RealisedCurrency == input.RealisedCurrency ||
                    (this.RealisedCurrency != null &&
                    this.RealisedCurrency.Equals(input.RealisedCurrency))
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
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.PurchaseTradeDate != null)
                    hashCode = hashCode * 59 + this.PurchaseTradeDate.GetHashCode();
                if (this.PurchaseSettlementDate != null)
                    hashCode = hashCode * 59 + this.PurchaseSettlementDate.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.CostTradeCcy != null)
                    hashCode = hashCode * 59 + this.CostTradeCcy.GetHashCode();
                if (this.CostPortfolioCcy != null)
                    hashCode = hashCode * 59 + this.CostPortfolioCcy.GetHashCode();
                if (this.RealisedTradeCcy != null)
                    hashCode = hashCode * 59 + this.RealisedTradeCcy.GetHashCode();
                if (this.RealisedTotal != null)
                    hashCode = hashCode * 59 + this.RealisedTotal.GetHashCode();
                if (this.RealisedMarket != null)
                    hashCode = hashCode * 59 + this.RealisedMarket.GetHashCode();
                if (this.RealisedCurrency != null)
                    hashCode = hashCode * 59 + this.RealisedCurrency.GetHashCode();
                return hashCode;
            }
        }
    }

}

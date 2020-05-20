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
    /// The description of an allowable instrument identifier.
    /// </summary>
    [DataContract]
    public partial class InstrumentIdTypeDescriptor :  IEquatable<InstrumentIdTypeDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentIdTypeDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstrumentIdTypeDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentIdTypeDescriptor" /> class.
        /// </summary>
        /// <param name="identifierType">The name of the identifier type. (required).</param>
        /// <param name="propertyKey">The property key that corresponds to the identifier type. (required).</param>
        /// <param name="isUniqueIdentifierType">Whether or not the identifier type is enforced to be unique. (required).</param>
        public InstrumentIdTypeDescriptor(string identifierType = default(string), string propertyKey = default(string), bool? isUniqueIdentifierType = default(bool?))
        {
            // to ensure "identifierType" is required (not null)
            if (identifierType == null)
            {
                throw new InvalidDataException("identifierType is a required property for InstrumentIdTypeDescriptor and cannot be null");
            }
            else
            {
                this.IdentifierType = identifierType;
            }
            
            // to ensure "propertyKey" is required (not null)
            if (propertyKey == null)
            {
                throw new InvalidDataException("propertyKey is a required property for InstrumentIdTypeDescriptor and cannot be null");
            }
            else
            {
                this.PropertyKey = propertyKey;
            }
            
            // to ensure "isUniqueIdentifierType" is required (not null)
            if (isUniqueIdentifierType == null)
            {
                throw new InvalidDataException("isUniqueIdentifierType is a required property for InstrumentIdTypeDescriptor and cannot be null");
            }
            else
            {
                this.IsUniqueIdentifierType = isUniqueIdentifierType;
            }
            
        }
        
        /// <summary>
        /// The name of the identifier type.
        /// </summary>
        /// <value>The name of the identifier type.</value>
        [DataMember(Name="identifierType", EmitDefaultValue=false)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// The property key that corresponds to the identifier type.
        /// </summary>
        /// <value>The property key that corresponds to the identifier type.</value>
        [DataMember(Name="propertyKey", EmitDefaultValue=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// Whether or not the identifier type is enforced to be unique.
        /// </summary>
        /// <value>Whether or not the identifier type is enforced to be unique.</value>
        [DataMember(Name="isUniqueIdentifierType", EmitDefaultValue=false)]
        public bool? IsUniqueIdentifierType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstrumentIdTypeDescriptor {\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
            sb.Append("  PropertyKey: ").Append(PropertyKey).Append("\n");
            sb.Append("  IsUniqueIdentifierType: ").Append(IsUniqueIdentifierType).Append("\n");
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
            return this.Equals(input as InstrumentIdTypeDescriptor);
        }

        /// <summary>
        /// Returns true if InstrumentIdTypeDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentIdTypeDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentIdTypeDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentifierType == input.IdentifierType ||
                    (this.IdentifierType != null &&
                    this.IdentifierType.Equals(input.IdentifierType))
                ) && 
                (
                    this.PropertyKey == input.PropertyKey ||
                    (this.PropertyKey != null &&
                    this.PropertyKey.Equals(input.PropertyKey))
                ) && 
                (
                    this.IsUniqueIdentifierType == input.IsUniqueIdentifierType ||
                    (this.IsUniqueIdentifierType != null &&
                    this.IsUniqueIdentifierType.Equals(input.IsUniqueIdentifierType))
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
                if (this.IdentifierType != null)
                    hashCode = hashCode * 59 + this.IdentifierType.GetHashCode();
                if (this.PropertyKey != null)
                    hashCode = hashCode * 59 + this.PropertyKey.GetHashCode();
                if (this.IsUniqueIdentifierType != null)
                    hashCode = hashCode * 59 + this.IsUniqueIdentifierType.GetHashCode();
                return hashCode;
            }
        }
    }

}

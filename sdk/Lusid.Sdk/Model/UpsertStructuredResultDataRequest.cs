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
    /// The details of the structured unit result data item to upsert into Lusid.
    /// </summary>
    [DataContract]
    public partial class UpsertStructuredResultDataRequest :  IEquatable<UpsertStructuredResultDataRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertStructuredResultDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertStructuredResultDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertStructuredResultDataRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="data">data.</param>
        public UpsertStructuredResultDataRequest(StructuredResultDataId id = default(StructuredResultDataId), StructuredResultData data = default(StructuredResultData))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UpsertStructuredResultDataRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            this.Data = data;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public StructuredResultDataId Id { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public StructuredResultData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertStructuredResultDataRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as UpsertStructuredResultDataRequest);
        }

        /// <summary>
        /// Returns true if UpsertStructuredResultDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertStructuredResultDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertStructuredResultDataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }

}

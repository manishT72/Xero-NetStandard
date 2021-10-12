/* 
 * Xero AppStore API
 *
 * These endpoints are for Xero Partners to interact with the App Store Billing platform
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Appstore
{
    /// <summary>
    /// Product
    /// </summary>
    [DataContract]
    public partial class Product :  IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// The pricing model of the product: * FIXED: Customers are charged a fixed amount for each billing period * PER_SEAT: Customers are charged based on the number of units they purchase 
        /// </summary>
        /// <value>The pricing model of the product: * FIXED: Customers are charged a fixed amount for each billing period * PER_SEAT: Customers are charged based on the number of units they purchase </value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FIXED for value: FIXED
            /// </summary>
            [EnumMember(Value = "FIXED")]
            FIXED = 1,

            /// <summary>
            /// Enum PERSEAT for value: PER_SEAT
            /// </summary>
            [EnumMember(Value = "PER_SEAT")]
            PERSEAT = 2

        }

        /// <summary>
        /// The pricing model of the product: * FIXED: Customers are charged a fixed amount for each billing period * PER_SEAT: Customers are charged based on the number of units they purchase 
        /// </summary>
        /// <value>The pricing model of the product: * FIXED: Customers are charged a fixed amount for each billing period * PER_SEAT: Customers are charged based on the number of units they purchase </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        
        /// <summary>
        /// The unique identifier for the product
        /// </summary>
        /// <value>The unique identifier for the product</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        /// <value>The name of the product</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The unit of the per seat product. e.g. \&quot;user\&quot;, \&quot;organisation\&quot;, \&quot;SMS\&quot;, etc
        /// </summary>
        /// <value>The unit of the per seat product. e.g. \&quot;user\&quot;, \&quot;organisation\&quot;, \&quot;SMS\&quot;, etc</value>
        [DataMember(Name="seatUnit", EmitDefaultValue=false)]
        public string SeatUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SeatUnit: ").Append(SeatUnit).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SeatUnit == input.SeatUnit ||
                    (this.SeatUnit != null &&
                    this.SeatUnit.Equals(input.SeatUnit))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SeatUnit != null)
                    hashCode = hashCode * 59 + this.SeatUnit.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

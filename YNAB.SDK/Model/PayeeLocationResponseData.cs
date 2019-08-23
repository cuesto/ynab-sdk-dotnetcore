/* 
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
using OpenAPIDateConverter = YNAB.SDK.Client.OpenAPIDateConverter;

namespace YNAB.SDK.Model
{
    /// <summary>
    /// PayeeLocationResponseData
    /// </summary>
    [DataContract]
    public partial class PayeeLocationResponseData :  IEquatable<PayeeLocationResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeLocationResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayeeLocationResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeLocationResponseData" /> class.
        /// </summary>
        /// <param name="payeeLocation">payeeLocation (required).</param>
        public PayeeLocationResponseData(PayeeLocation payeeLocation = default(PayeeLocation))
        {
            // to ensure "payeeLocation" is required (not null)
            if (payeeLocation == null)
            {
                throw new InvalidDataException("payeeLocation is a required property for PayeeLocationResponseData and cannot be null");
            }
            else
            {
                this.PayeeLocation = payeeLocation;
            }

        }
        
        /// <summary>
        /// Gets or Sets PayeeLocation
        /// </summary>
        [DataMember(Name="payee_location", EmitDefaultValue=false)]
        public PayeeLocation PayeeLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayeeLocationResponseData {\n");
            sb.Append("  PayeeLocation: ").Append(PayeeLocation).Append("\n");
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
            return this.Equals(input as PayeeLocationResponseData);
        }

        /// <summary>
        /// Returns true if PayeeLocationResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of PayeeLocationResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayeeLocationResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayeeLocation == input.PayeeLocation ||
                    (this.PayeeLocation != null &&
                    this.PayeeLocation.Equals(input.PayeeLocation))
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
                if (this.PayeeLocation != null)
                    hashCode = hashCode * 59 + this.PayeeLocation.GetHashCode();
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
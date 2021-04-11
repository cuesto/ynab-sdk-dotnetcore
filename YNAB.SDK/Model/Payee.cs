/*
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YNAB.SDK.Client.OpenAPIDateConverter;

namespace YNAB.SDK.Model
{
    /// <summary>
    /// Payee
    /// </summary>
    [DataContract(Name = "Payee")]
    public partial class Payee : IEquatable<Payee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payee() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payee" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="transferAccountId">If a transfer payee, the &#x60;account_id&#x60; to which this payee transfers to.</param>
        /// <param name="deleted">Whether or not the payee has been deleted.  Deleted payees will only be included in delta requests. (required).</param>
        public Payee(Guid id = default(Guid), string name = default(string), string transferAccountId = default(string), bool deleted = default(bool))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Payee and cannot be null");
            this.Deleted = deleted;
            this.TransferAccountId = transferAccountId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// If a transfer payee, the &#x60;account_id&#x60; to which this payee transfers to
        /// </summary>
        /// <value>If a transfer payee, the &#x60;account_id&#x60; to which this payee transfers to</value>
        [DataMember(Name = "transfer_account_id", EmitDefaultValue = false)]
        public string TransferAccountId { get; set; }

        /// <summary>
        /// Whether or not the payee has been deleted.  Deleted payees will only be included in delta requests.
        /// </summary>
        /// <value>Whether or not the payee has been deleted.  Deleted payees will only be included in delta requests.</value>
        [DataMember(Name = "deleted", IsRequired = true, EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TransferAccountId: ").Append(TransferAccountId).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Payee);
        }

        /// <summary>
        /// Returns true if Payee instances are equal
        /// </summary>
        /// <param name="input">Instance of Payee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payee input)
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
                    this.TransferAccountId == input.TransferAccountId ||
                    (this.TransferAccountId != null &&
                    this.TransferAccountId.Equals(input.TransferAccountId))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
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
                if (this.TransferAccountId != null)
                    hashCode = hashCode * 59 + this.TransferAccountId.GetHashCode();
                hashCode = hashCode * 59 + this.Deleted.GetHashCode();
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

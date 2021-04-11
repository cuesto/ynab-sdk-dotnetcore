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
    /// ScheduledTransactionDetailAllOf
    /// </summary>
    [DataContract(Name = "ScheduledTransactionDetail_allOf")]
    public partial class ScheduledTransactionDetailAllOf : IEquatable<ScheduledTransactionDetailAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionDetailAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduledTransactionDetailAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledTransactionDetailAllOf" /> class.
        /// </summary>
        /// <param name="accountName">accountName (required).</param>
        /// <param name="payeeName">payeeName.</param>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="subtransactions">If a split scheduled transaction, the subtransactions. (required).</param>
        public ScheduledTransactionDetailAllOf(string accountName = default(string), string payeeName = default(string), string categoryName = default(string), List<ScheduledSubTransaction> subtransactions = default(List<ScheduledSubTransaction>))
        {
            // to ensure "accountName" is required (not null)
            this.AccountName = accountName ?? throw new ArgumentNullException("accountName is a required property for ScheduledTransactionDetailAllOf and cannot be null");
            // to ensure "subtransactions" is required (not null)
            this.Subtransactions = subtransactions ?? throw new ArgumentNullException("subtransactions is a required property for ScheduledTransactionDetailAllOf and cannot be null");
            this.PayeeName = payeeName;
            this.CategoryName = categoryName;
        }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name = "account_name", IsRequired = true, EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets PayeeName
        /// </summary>
        [DataMember(Name = "payee_name", EmitDefaultValue = false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// If a split scheduled transaction, the subtransactions.
        /// </summary>
        /// <value>If a split scheduled transaction, the subtransactions.</value>
        [DataMember(Name = "subtransactions", IsRequired = true, EmitDefaultValue = false)]
        public List<ScheduledSubTransaction> Subtransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledTransactionDetailAllOf {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
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
            return this.Equals(input as ScheduledTransactionDetailAllOf);
        }

        /// <summary>
        /// Returns true if ScheduledTransactionDetailAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledTransactionDetailAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledTransactionDetailAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.Subtransactions == input.Subtransactions ||
                    this.Subtransactions != null &&
                    input.Subtransactions != null &&
                    this.Subtransactions.SequenceEqual(input.Subtransactions)
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
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.PayeeName != null)
                    hashCode = hashCode * 59 + this.PayeeName.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.Subtransactions != null)
                    hashCode = hashCode * 59 + this.Subtransactions.GetHashCode();
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

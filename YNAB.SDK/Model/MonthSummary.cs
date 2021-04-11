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
    /// MonthSummary
    /// </summary>
    [DataContract(Name = "MonthSummary")]
    public partial class MonthSummary : IEquatable<MonthSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MonthSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthSummary" /> class.
        /// </summary>
        /// <param name="month">month (required).</param>
        /// <param name="note">note.</param>
        /// <param name="income">The total amount of transactions categorized to &#39;Inflow: To be Budgeted&#39; in the month (required).</param>
        /// <param name="budgeted">The total amount budgeted in the month (required).</param>
        /// <param name="activity">The total amount of transactions in the month, excluding those categorized to &#39;Inflow: To be Budgeted&#39; (required).</param>
        /// <param name="toBeBudgeted">The available amount for &#39;To be Budgeted&#39; (required).</param>
        /// <param name="ageOfMoney">The Age of Money as of the month.</param>
        /// <param name="deleted">Whether or not the month has been deleted.  Deleted months will only be included in delta requests. (required).</param>
        public MonthSummary(DateTime month = default(DateTime), string note = default(string), long income = default(long), long budgeted = default(long), long activity = default(long), long toBeBudgeted = default(long), int ageOfMoney = default(int), bool deleted = default(bool))
        {
            this.Month = month;
            this.Income = income;
            this.Budgeted = budgeted;
            this.Activity = activity;
            this.ToBeBudgeted = toBeBudgeted;
            this.Deleted = deleted;
            this.Note = note;
            this.AgeOfMoney = ageOfMoney;
        }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Month { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// The total amount of transactions categorized to &#39;Inflow: To be Budgeted&#39; in the month
        /// </summary>
        /// <value>The total amount of transactions categorized to &#39;Inflow: To be Budgeted&#39; in the month</value>
        [DataMember(Name = "income", IsRequired = true, EmitDefaultValue = false)]
        public long Income { get; set; }

        /// <summary>
        /// The total amount budgeted in the month
        /// </summary>
        /// <value>The total amount budgeted in the month</value>
        [DataMember(Name = "budgeted", IsRequired = true, EmitDefaultValue = false)]
        public long Budgeted { get; set; }

        /// <summary>
        /// The total amount of transactions in the month, excluding those categorized to &#39;Inflow: To be Budgeted&#39;
        /// </summary>
        /// <value>The total amount of transactions in the month, excluding those categorized to &#39;Inflow: To be Budgeted&#39;</value>
        [DataMember(Name = "activity", IsRequired = true, EmitDefaultValue = false)]
        public long Activity { get; set; }

        /// <summary>
        /// The available amount for &#39;To be Budgeted&#39;
        /// </summary>
        /// <value>The available amount for &#39;To be Budgeted&#39;</value>
        [DataMember(Name = "to_be_budgeted", IsRequired = true, EmitDefaultValue = false)]
        public long ToBeBudgeted { get; set; }

        /// <summary>
        /// The Age of Money as of the month
        /// </summary>
        /// <value>The Age of Money as of the month</value>
        [DataMember(Name = "age_of_money", EmitDefaultValue = false)]
        public int AgeOfMoney { get; set; }

        /// <summary>
        /// Whether or not the month has been deleted.  Deleted months will only be included in delta requests.
        /// </summary>
        /// <value>Whether or not the month has been deleted.  Deleted months will only be included in delta requests.</value>
        [DataMember(Name = "deleted", IsRequired = true, EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonthSummary {\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Income: ").Append(Income).Append("\n");
            sb.Append("  Budgeted: ").Append(Budgeted).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  ToBeBudgeted: ").Append(ToBeBudgeted).Append("\n");
            sb.Append("  AgeOfMoney: ").Append(AgeOfMoney).Append("\n");
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
            return this.Equals(input as MonthSummary);
        }

        /// <summary>
        /// Returns true if MonthSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.Income == input.Income ||
                    this.Income.Equals(input.Income)
                ) && 
                (
                    this.Budgeted == input.Budgeted ||
                    this.Budgeted.Equals(input.Budgeted)
                ) && 
                (
                    this.Activity == input.Activity ||
                    this.Activity.Equals(input.Activity)
                ) && 
                (
                    this.ToBeBudgeted == input.ToBeBudgeted ||
                    this.ToBeBudgeted.Equals(input.ToBeBudgeted)
                ) && 
                (
                    this.AgeOfMoney == input.AgeOfMoney ||
                    this.AgeOfMoney.Equals(input.AgeOfMoney)
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
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                hashCode = hashCode * 59 + this.Income.GetHashCode();
                hashCode = hashCode * 59 + this.Budgeted.GetHashCode();
                hashCode = hashCode * 59 + this.Activity.GetHashCode();
                hashCode = hashCode * 59 + this.ToBeBudgeted.GetHashCode();
                hashCode = hashCode * 59 + this.AgeOfMoney.GetHashCode();
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

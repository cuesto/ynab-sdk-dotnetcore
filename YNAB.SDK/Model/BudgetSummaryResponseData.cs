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
    /// BudgetSummaryResponseData
    /// </summary>
    [DataContract(Name = "BudgetSummaryResponse_data")]
    public partial class BudgetSummaryResponseData : IEquatable<BudgetSummaryResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetSummaryResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetSummaryResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetSummaryResponseData" /> class.
        /// </summary>
        /// <param name="budgets">budgets (required).</param>
        /// <param name="defaultBudget">defaultBudget.</param>
        public BudgetSummaryResponseData(List<BudgetSummary> budgets = default(List<BudgetSummary>), BudgetSummary defaultBudget = default(BudgetSummary))
        {
            // to ensure "budgets" is required (not null)
            this.Budgets = budgets ?? throw new ArgumentNullException("budgets is a required property for BudgetSummaryResponseData and cannot be null");
            this.DefaultBudget = defaultBudget;
        }

        /// <summary>
        /// Gets or Sets Budgets
        /// </summary>
        [DataMember(Name = "budgets", IsRequired = true, EmitDefaultValue = false)]
        public List<BudgetSummary> Budgets { get; set; }

        /// <summary>
        /// Gets or Sets DefaultBudget
        /// </summary>
        [DataMember(Name = "default_budget", EmitDefaultValue = false)]
        public BudgetSummary DefaultBudget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BudgetSummaryResponseData {\n");
            sb.Append("  Budgets: ").Append(Budgets).Append("\n");
            sb.Append("  DefaultBudget: ").Append(DefaultBudget).Append("\n");
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
            return this.Equals(input as BudgetSummaryResponseData);
        }

        /// <summary>
        /// Returns true if BudgetSummaryResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetSummaryResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetSummaryResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Budgets == input.Budgets ||
                    this.Budgets != null &&
                    input.Budgets != null &&
                    this.Budgets.SequenceEqual(input.Budgets)
                ) && 
                (
                    this.DefaultBudget == input.DefaultBudget ||
                    (this.DefaultBudget != null &&
                    this.DefaultBudget.Equals(input.DefaultBudget))
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
                if (this.Budgets != null)
                    hashCode = hashCode * 59 + this.Budgets.GetHashCode();
                if (this.DefaultBudget != null)
                    hashCode = hashCode * 59 + this.DefaultBudget.GetHashCode();
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

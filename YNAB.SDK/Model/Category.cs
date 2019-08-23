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
    /// Category
    /// </summary>
    [DataContract]
    public partial class Category :  IEquatable<Category>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Category() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="categoryGroupId">categoryGroupId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="hidden">Whether or not the category is hidden (required).</param>
        /// <param name="note">note (required).</param>
        /// <param name="budgeted">Budgeted amount in milliunits format (required).</param>
        /// <param name="activity">Activity amount in milliunits format (required).</param>
        /// <param name="balance">Balance in milliunits format (required).</param>
        /// <param name="goalTarget">The goal target amount in milliunits (required).</param>
        /// <param name="deleted">Whether or not the category has been deleted.  Deleted categories will only be included in delta requests. (required).</param>
        public Category(Guid id = default(Guid), Guid categoryGroupId = default(Guid), string name = default(string), bool hidden = default(bool), string note = default(string), long budgeted = default(long), long activity = default(long), long balance = default(long), long goalTarget = default(long), bool deleted = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Category and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "categoryGroupId" is required (not null)
            if (categoryGroupId == null)
            {
                throw new InvalidDataException("categoryGroupId is a required property for Category and cannot be null");
            }
            else
            {
                this.CategoryGroupId = categoryGroupId;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Category and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "hidden" is required (not null)
            if (hidden == null)
            {
                throw new InvalidDataException("hidden is a required property for Category and cannot be null");
            }
            else
            {
                this.Hidden = hidden;
            }

            // to ensure "note" is required (not null)
            if (note == null)
            {
                throw new InvalidDataException("note is a required property for Category and cannot be null");
            }
            else
            {
                this.Note = note;
            }

            // to ensure "budgeted" is required (not null)
            if (budgeted == null)
            {
                throw new InvalidDataException("budgeted is a required property for Category and cannot be null");
            }
            else
            {
                this.Budgeted = budgeted;
            }

            // to ensure "activity" is required (not null)
            if (activity == null)
            {
                throw new InvalidDataException("activity is a required property for Category and cannot be null");
            }
            else
            {
                this.Activity = activity;
            }

            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new InvalidDataException("balance is a required property for Category and cannot be null");
            }
            else
            {
                this.Balance = balance;
            }

            // to ensure "goalTarget" is required (not null)
            if (goalTarget == null)
            {
                throw new InvalidDataException("goalTarget is a required property for Category and cannot be null");
            }
            else
            {
                this.GoalTarget = goalTarget;
            }

            // to ensure "deleted" is required (not null)
            if (deleted == null)
            {
                throw new InvalidDataException("deleted is a required property for Category and cannot be null");
            }
            else
            {
                this.Deleted = deleted;
            }

        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets CategoryGroupId
        /// </summary>
        [DataMember(Name="category_group_id", EmitDefaultValue=false)]
        public Guid CategoryGroupId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether or not the category is hidden
        /// </summary>
        /// <value>Whether or not the category is hidden</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Budgeted amount in milliunits format
        /// </summary>
        /// <value>Budgeted amount in milliunits format</value>
        [DataMember(Name="budgeted", EmitDefaultValue=false)]
        public long Budgeted { get; set; }

        /// <summary>
        /// Activity amount in milliunits format
        /// </summary>
        /// <value>Activity amount in milliunits format</value>
        [DataMember(Name="activity", EmitDefaultValue=false)]
        public long Activity { get; set; }

        /// <summary>
        /// Balance in milliunits format
        /// </summary>
        /// <value>Balance in milliunits format</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public long Balance { get; set; }

        /// <summary>
        /// The goal target amount in milliunits
        /// </summary>
        /// <value>The goal target amount in milliunits</value>
        [DataMember(Name="goal_target", EmitDefaultValue=false)]
        public long GoalTarget { get; set; }

        /// <summary>
        /// Whether or not the category has been deleted.  Deleted categories will only be included in delta requests.
        /// </summary>
        /// <value>Whether or not the category has been deleted.  Deleted categories will only be included in delta requests.</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CategoryGroupId: ").Append(CategoryGroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Budgeted: ").Append(Budgeted).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  GoalTarget: ").Append(GoalTarget).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="input">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category input)
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
                    this.CategoryGroupId == input.CategoryGroupId ||
                    (this.CategoryGroupId != null &&
                    this.CategoryGroupId.Equals(input.CategoryGroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    this.Hidden.Equals(input.Hidden)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
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
                    this.Balance == input.Balance ||
                    this.Balance.Equals(input.Balance)
                ) && 
                (
                    this.GoalTarget == input.GoalTarget ||
                    this.GoalTarget.Equals(input.GoalTarget)
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
                if (this.CategoryGroupId != null)
                    hashCode = hashCode * 59 + this.CategoryGroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                hashCode = hashCode * 59 + this.Budgeted.GetHashCode();
                hashCode = hashCode * 59 + this.Activity.GetHashCode();
                hashCode = hashCode * 59 + this.Balance.GetHashCode();
                hashCode = hashCode * 59 + this.GoalTarget.GetHashCode();
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

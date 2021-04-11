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
    /// UpdateTransaction
    /// </summary>
    [DataContract(Name = "UpdateTransaction")]
    public partial class UpdateTransaction : IEquatable<UpdateTransaction>, IValidatableObject
    {
        /// <summary>
        /// The cleared status of the transaction
        /// </summary>
        /// <value>The cleared status of the transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClearedEnum
        {
            /// <summary>
            /// Enum Cleared for value: cleared
            /// </summary>
            [EnumMember(Value = "cleared")]
            Cleared = 1,

            /// <summary>
            /// Enum Uncleared for value: uncleared
            /// </summary>
            [EnumMember(Value = "uncleared")]
            Uncleared = 2,

            /// <summary>
            /// Enum Reconciled for value: reconciled
            /// </summary>
            [EnumMember(Value = "reconciled")]
            Reconciled = 3

        }


        /// <summary>
        /// The cleared status of the transaction
        /// </summary>
        /// <value>The cleared status of the transaction</value>
        [DataMember(Name = "cleared", EmitDefaultValue = false)]
        public ClearedEnum? Cleared { get; set; }
        /// <summary>
        /// The transaction flag
        /// </summary>
        /// <value>The transaction flag</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlagColorEnum
        {
            /// <summary>
            /// Enum Red for value: red
            /// </summary>
            [EnumMember(Value = "red")]
            Red = 1,

            /// <summary>
            /// Enum Orange for value: orange
            /// </summary>
            [EnumMember(Value = "orange")]
            Orange = 2,

            /// <summary>
            /// Enum Yellow for value: yellow
            /// </summary>
            [EnumMember(Value = "yellow")]
            Yellow = 3,

            /// <summary>
            /// Enum Green for value: green
            /// </summary>
            [EnumMember(Value = "green")]
            Green = 4,

            /// <summary>
            /// Enum Blue for value: blue
            /// </summary>
            [EnumMember(Value = "blue")]
            Blue = 5,

            /// <summary>
            /// Enum Purple for value: purple
            /// </summary>
            [EnumMember(Value = "purple")]
            Purple = 6

        }


        /// <summary>
        /// The transaction flag
        /// </summary>
        /// <value>The transaction flag</value>
        [DataMember(Name = "flag_color", EmitDefaultValue = false)]
        public FlagColorEnum? FlagColor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransaction" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="accountId">accountId (required).</param>
        /// <param name="date">The transaction date in ISO format (e.g. 2016-12-01).  Future dates (scheduled transactions) are not permitted.  Split transaction dates cannot be changed and if a different date is supplied it will be ignored. (required).</param>
        /// <param name="amount">The transaction amount in milliunits format.  Split transaction amounts cannot be changed and if a different amount is supplied it will be ignored. (required).</param>
        /// <param name="payeeId">The payee for the transaction.  To create a transfer between two accounts, use the account transfer payee pointing to the target account.  Account transfer payees are specified as &#x60;tranfer_payee_id&#x60; on the account resource..</param>
        /// <param name="payeeName">The payee name.  If a &#x60;payee_name&#x60; value is provided and &#x60;payee_id&#x60; has a null value, the &#x60;payee_name&#x60; value will be used to resolve the payee by either (1) a matching payee rename rule (only if &#x60;import_id&#x60; is also specified) or (2) a payee with the same name or (3) creation of a new payee..</param>
        /// <param name="categoryId">The category for the transaction.  To configure a split transaction, you can specify null for &#x60;category_id&#x60; and provide a &#x60;subtransactions&#x60; array as part of the transaction object.  If an existing transaction is a split, the &#x60;category_id&#x60; cannot be changed.  Credit Card Payment categories are not permitted and will be ignored if supplied..</param>
        /// <param name="memo">memo.</param>
        /// <param name="cleared">The cleared status of the transaction.</param>
        /// <param name="approved">Whether or not the transaction is approved.  If not supplied, transaction will be unapproved by default..</param>
        /// <param name="flagColor">The transaction flag.</param>
        /// <param name="importId">If specified, the new transaction will be assigned this &#x60;import_id&#x60; and considered \&quot;imported\&quot;.  We will also attempt to match this imported transaction to an existing \&quot;user-entered\&quot; transation on the same account, with the same amount, and with a date +/-10 days from the imported transaction date.&lt;br&gt;&lt;br&gt;Transactions imported through File Based Import or Direct Import (not through the API) are assigned an import_id in the format: &#39;YNAB:[milliunit_amount]:[iso_date]:[occurrence]&#39;. For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of &#39;YNAB:-294230:2015-12-30:1&#39;.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be &#39;YNAB:-294230:2015-12-30:2&#39;.  Using a consistent format will prevent duplicates through Direct Import and File Based Import.&lt;br&gt;&lt;br&gt;If import_id is omitted or specified as null, the transaction will be treated as a \&quot;user-entered\&quot; transaction. As such, it will be eligible to be matched against transactions later being imported (via DI, FBI, or API)..</param>
        /// <param name="subtransactions">An array of subtransactions to configure a transaction as a split.  Updating &#x60;subtransactions&#x60; on an existing split transaction is not supported..</param>
        public UpdateTransaction(string id = default(string), Guid accountId = default(Guid), DateTime date = default(DateTime), long amount = default(long), Guid payeeId = default(Guid), string payeeName = default(string), Guid categoryId = default(Guid), string memo = default(string), ClearedEnum? cleared = default(ClearedEnum?), bool approved = default(bool), FlagColorEnum? flagColor = default(FlagColorEnum?), string importId = default(string), List<SaveSubTransaction> subtransactions = default(List<SaveSubTransaction>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for UpdateTransaction and cannot be null");
            this.AccountId = accountId;
            this.Date = date;
            this.Amount = amount;
            this.PayeeId = payeeId;
            this.PayeeName = payeeName;
            this.CategoryId = categoryId;
            this.Memo = memo;
            this.Cleared = cleared;
            this.Approved = approved;
            this.FlagColor = flagColor;
            this.ImportId = importId;
            this.Subtransactions = subtransactions;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = false)]
        public Guid AccountId { get; set; }

        /// <summary>
        /// The transaction date in ISO format (e.g. 2016-12-01).  Future dates (scheduled transactions) are not permitted.  Split transaction dates cannot be changed and if a different date is supplied it will be ignored.
        /// </summary>
        /// <value>The transaction date in ISO format (e.g. 2016-12-01).  Future dates (scheduled transactions) are not permitted.  Split transaction dates cannot be changed and if a different date is supplied it will be ignored.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// The transaction amount in milliunits format.  Split transaction amounts cannot be changed and if a different amount is supplied it will be ignored.
        /// </summary>
        /// <value>The transaction amount in milliunits format.  Split transaction amounts cannot be changed and if a different amount is supplied it will be ignored.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public long Amount { get; set; }

        /// <summary>
        /// The payee for the transaction.  To create a transfer between two accounts, use the account transfer payee pointing to the target account.  Account transfer payees are specified as &#x60;tranfer_payee_id&#x60; on the account resource.
        /// </summary>
        /// <value>The payee for the transaction.  To create a transfer between two accounts, use the account transfer payee pointing to the target account.  Account transfer payees are specified as &#x60;tranfer_payee_id&#x60; on the account resource.</value>
        [DataMember(Name = "payee_id", EmitDefaultValue = false)]
        public Guid PayeeId { get; set; }

        /// <summary>
        /// The payee name.  If a &#x60;payee_name&#x60; value is provided and &#x60;payee_id&#x60; has a null value, the &#x60;payee_name&#x60; value will be used to resolve the payee by either (1) a matching payee rename rule (only if &#x60;import_id&#x60; is also specified) or (2) a payee with the same name or (3) creation of a new payee.
        /// </summary>
        /// <value>The payee name.  If a &#x60;payee_name&#x60; value is provided and &#x60;payee_id&#x60; has a null value, the &#x60;payee_name&#x60; value will be used to resolve the payee by either (1) a matching payee rename rule (only if &#x60;import_id&#x60; is also specified) or (2) a payee with the same name or (3) creation of a new payee.</value>
        [DataMember(Name = "payee_name", EmitDefaultValue = false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// The category for the transaction.  To configure a split transaction, you can specify null for &#x60;category_id&#x60; and provide a &#x60;subtransactions&#x60; array as part of the transaction object.  If an existing transaction is a split, the &#x60;category_id&#x60; cannot be changed.  Credit Card Payment categories are not permitted and will be ignored if supplied.
        /// </summary>
        /// <value>The category for the transaction.  To configure a split transaction, you can specify null for &#x60;category_id&#x60; and provide a &#x60;subtransactions&#x60; array as part of the transaction object.  If an existing transaction is a split, the &#x60;category_id&#x60; cannot be changed.  Credit Card Payment categories are not permitted and will be ignored if supplied.</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// Whether or not the transaction is approved.  If not supplied, transaction will be unapproved by default.
        /// </summary>
        /// <value>Whether or not the transaction is approved.  If not supplied, transaction will be unapproved by default.</value>
        [DataMember(Name = "approved", EmitDefaultValue = true)]
        public bool Approved { get; set; }

        /// <summary>
        /// If specified, the new transaction will be assigned this &#x60;import_id&#x60; and considered \&quot;imported\&quot;.  We will also attempt to match this imported transaction to an existing \&quot;user-entered\&quot; transation on the same account, with the same amount, and with a date +/-10 days from the imported transaction date.&lt;br&gt;&lt;br&gt;Transactions imported through File Based Import or Direct Import (not through the API) are assigned an import_id in the format: &#39;YNAB:[milliunit_amount]:[iso_date]:[occurrence]&#39;. For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of &#39;YNAB:-294230:2015-12-30:1&#39;.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be &#39;YNAB:-294230:2015-12-30:2&#39;.  Using a consistent format will prevent duplicates through Direct Import and File Based Import.&lt;br&gt;&lt;br&gt;If import_id is omitted or specified as null, the transaction will be treated as a \&quot;user-entered\&quot; transaction. As such, it will be eligible to be matched against transactions later being imported (via DI, FBI, or API).
        /// </summary>
        /// <value>If specified, the new transaction will be assigned this &#x60;import_id&#x60; and considered \&quot;imported\&quot;.  We will also attempt to match this imported transaction to an existing \&quot;user-entered\&quot; transation on the same account, with the same amount, and with a date +/-10 days from the imported transaction date.&lt;br&gt;&lt;br&gt;Transactions imported through File Based Import or Direct Import (not through the API) are assigned an import_id in the format: &#39;YNAB:[milliunit_amount]:[iso_date]:[occurrence]&#39;. For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of &#39;YNAB:-294230:2015-12-30:1&#39;.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be &#39;YNAB:-294230:2015-12-30:2&#39;.  Using a consistent format will prevent duplicates through Direct Import and File Based Import.&lt;br&gt;&lt;br&gt;If import_id is omitted or specified as null, the transaction will be treated as a \&quot;user-entered\&quot; transaction. As such, it will be eligible to be matched against transactions later being imported (via DI, FBI, or API).</value>
        [DataMember(Name = "import_id", EmitDefaultValue = false)]
        public string ImportId { get; set; }

        /// <summary>
        /// An array of subtransactions to configure a transaction as a split.  Updating &#x60;subtransactions&#x60; on an existing split transaction is not supported.
        /// </summary>
        /// <value>An array of subtransactions to configure a transaction as a split.  Updating &#x60;subtransactions&#x60; on an existing split transaction is not supported.</value>
        [DataMember(Name = "subtransactions", EmitDefaultValue = false)]
        public List<SaveSubTransaction> Subtransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  Cleared: ").Append(Cleared).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  FlagColor: ").Append(FlagColor).Append("\n");
            sb.Append("  ImportId: ").Append(ImportId).Append("\n");
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
            return this.Equals(input as UpdateTransaction);
        }

        /// <summary>
        /// Returns true if UpdateTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTransaction input)
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
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.PayeeId == input.PayeeId ||
                    (this.PayeeId != null &&
                    this.PayeeId.Equals(input.PayeeId))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.Cleared == input.Cleared ||
                    this.Cleared.Equals(input.Cleared)
                ) && 
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) && 
                (
                    this.FlagColor == input.FlagColor ||
                    this.FlagColor.Equals(input.FlagColor)
                ) && 
                (
                    this.ImportId == input.ImportId ||
                    (this.ImportId != null &&
                    this.ImportId.Equals(input.ImportId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.PayeeId != null)
                    hashCode = hashCode * 59 + this.PayeeId.GetHashCode();
                if (this.PayeeName != null)
                    hashCode = hashCode * 59 + this.PayeeName.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                hashCode = hashCode * 59 + this.Cleared.GetHashCode();
                hashCode = hashCode * 59 + this.Approved.GetHashCode();
                hashCode = hashCode * 59 + this.FlagColor.GetHashCode();
                if (this.ImportId != null)
                    hashCode = hashCode * 59 + this.ImportId.GetHashCode();
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
            // PayeeName (string) maxLength
            if(this.PayeeName != null && this.PayeeName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PayeeName, length must be less than 50.", new [] { "PayeeName" });
            }

            // Memo (string) maxLength
            if(this.Memo != null && this.Memo.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Memo, length must be less than 200.", new [] { "Memo" });
            }

            // ImportId (string) maxLength
            if(this.ImportId != null && this.ImportId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImportId, length must be less than 36.", new [] { "ImportId" });
            }

            yield break;
        }
    }

}

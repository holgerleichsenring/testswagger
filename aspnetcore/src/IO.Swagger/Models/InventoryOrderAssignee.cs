/*
 * Digitalization of Asset Counting Web Api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InventoryOrderAssignee : IEquatable<InventoryOrderAssignee>
    { 
        /// <summary>
        /// Gets or Sets InventoryOrderId
        /// </summary>
        [Required]
        [DataMember(Name="inventoryOrderId")]
        public int? InventoryOrderId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [Required]
        [DataMember(Name="assignee")]
        public string Assignee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryOrderAssignee {\n");
            sb.Append("  InventoryOrderId: ").Append(InventoryOrderId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InventoryOrderAssignee)obj);
        }

        /// <summary>
        /// Returns true if InventoryOrderAssignee instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryOrderAssignee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryOrderAssignee other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InventoryOrderId == other.InventoryOrderId ||
                    InventoryOrderId != null &&
                    InventoryOrderId.Equals(other.InventoryOrderId)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Assignee == other.Assignee ||
                    Assignee != null &&
                    Assignee.Equals(other.Assignee)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (InventoryOrderId != null)
                    hashCode = hashCode * 59 + InventoryOrderId.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Assignee != null)
                    hashCode = hashCode * 59 + Assignee.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InventoryOrderAssignee left, InventoryOrderAssignee right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InventoryOrderAssignee left, InventoryOrderAssignee right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

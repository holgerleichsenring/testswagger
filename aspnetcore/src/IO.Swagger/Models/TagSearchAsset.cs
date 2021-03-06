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
    public partial class TagSearchAsset : IEquatable<TagSearchAsset>
    { 
        /// <summary>
        /// Gets or Sets InventoryVariantName
        /// </summary>
        [DataMember(Name="inventoryVariantName")]
        public string InventoryVariantName { get; set; }

        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name="tagId")]
        public string TagId { get; set; }

        /// <summary>
        /// Gets or Sets AssetNumber
        /// </summary>
        [DataMember(Name="assetNumber")]
        public string AssetNumber { get; set; }

        /// <summary>
        /// Gets or Sets SubNumber
        /// </summary>
        [DataMember(Name="subNumber")]
        public string SubNumber { get; set; }

        /// <summary>
        /// Gets or Sets CompanyCode
        /// </summary>
        [DataMember(Name="companyCode")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagSearchAsset {\n");
            sb.Append("  InventoryVariantName: ").Append(InventoryVariantName).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  AssetNumber: ").Append(AssetNumber).Append("\n");
            sb.Append("  SubNumber: ").Append(SubNumber).Append("\n");
            sb.Append("  CompanyCode: ").Append(CompanyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TagSearchAsset)obj);
        }

        /// <summary>
        /// Returns true if TagSearchAsset instances are equal
        /// </summary>
        /// <param name="other">Instance of TagSearchAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagSearchAsset other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InventoryVariantName == other.InventoryVariantName ||
                    InventoryVariantName != null &&
                    InventoryVariantName.Equals(other.InventoryVariantName)
                ) && 
                (
                    TagId == other.TagId ||
                    TagId != null &&
                    TagId.Equals(other.TagId)
                ) && 
                (
                    AssetNumber == other.AssetNumber ||
                    AssetNumber != null &&
                    AssetNumber.Equals(other.AssetNumber)
                ) && 
                (
                    SubNumber == other.SubNumber ||
                    SubNumber != null &&
                    SubNumber.Equals(other.SubNumber)
                ) && 
                (
                    CompanyCode == other.CompanyCode ||
                    CompanyCode != null &&
                    CompanyCode.Equals(other.CompanyCode)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (InventoryVariantName != null)
                    hashCode = hashCode * 59 + InventoryVariantName.GetHashCode();
                    if (TagId != null)
                    hashCode = hashCode * 59 + TagId.GetHashCode();
                    if (AssetNumber != null)
                    hashCode = hashCode * 59 + AssetNumber.GetHashCode();
                    if (SubNumber != null)
                    hashCode = hashCode * 59 + SubNumber.GetHashCode();
                    if (CompanyCode != null)
                    hashCode = hashCode * 59 + CompanyCode.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TagSearchAsset left, TagSearchAsset right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TagSearchAsset left, TagSearchAsset right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

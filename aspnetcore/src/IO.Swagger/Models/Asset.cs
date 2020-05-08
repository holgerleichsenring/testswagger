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
    public partial class Asset : IEquatable<Asset>
    { 
        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name="tagId")]
        public string TagId { get; set; }

        /// <summary>
        /// Gets or Sets SecondTagId
        /// </summary>
        [DataMember(Name="secondTagId")]
        public string SecondTagId { get; set; }

        /// <summary>
        /// Gets or Sets IsUntaggable
        /// </summary>
        [DataMember(Name="isUntaggable")]
        public bool? IsUntaggable { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="lastModified")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets ShareTags
        /// </summary>
        [DataMember(Name="shareTags")]
        public bool? ShareTags { get; set; }

        /// <summary>
        /// Gets or Sets SapAsset
        /// </summary>
        [DataMember(Name="sapAsset")]
        public SapInventoryAsset SapAsset { get; set; }

        /// <summary>
        /// Gets or Sets AssetNumber
        /// </summary>
        [Required]
        [DataMember(Name="assetNumber")]
        public string AssetNumber { get; set; }

        /// <summary>
        /// Gets or Sets SubNumber
        /// </summary>
        [Required]
        [DataMember(Name="subNumber")]
        public string SubNumber { get; set; }

        /// <summary>
        /// Gets or Sets CompanyCode
        /// </summary>
        [Required]
        [DataMember(Name="companyCode")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  SecondTagId: ").Append(SecondTagId).Append("\n");
            sb.Append("  IsUntaggable: ").Append(IsUntaggable).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ShareTags: ").Append(ShareTags).Append("\n");
            sb.Append("  SapAsset: ").Append(SapAsset).Append("\n");
            sb.Append("  AssetNumber: ").Append(AssetNumber).Append("\n");
            sb.Append("  SubNumber: ").Append(SubNumber).Append("\n");
            sb.Append("  CompanyCode: ").Append(CompanyCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Asset)obj);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="other">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TagId == other.TagId ||
                    TagId != null &&
                    TagId.Equals(other.TagId)
                ) && 
                (
                    SecondTagId == other.SecondTagId ||
                    SecondTagId != null &&
                    SecondTagId.Equals(other.SecondTagId)
                ) && 
                (
                    IsUntaggable == other.IsUntaggable ||
                    IsUntaggable != null &&
                    IsUntaggable.Equals(other.IsUntaggable)
                ) && 
                (
                    Latitude == other.Latitude ||
                    Latitude != null &&
                    Latitude.Equals(other.Latitude)
                ) && 
                (
                    Longitude == other.Longitude ||
                    Longitude != null &&
                    Longitude.Equals(other.Longitude)
                ) && 
                (
                    LastModified == other.LastModified ||
                    LastModified != null &&
                    LastModified.Equals(other.LastModified)
                ) && 
                (
                    Created == other.Created ||
                    Created != null &&
                    Created.Equals(other.Created)
                ) && 
                (
                    Creator == other.Creator ||
                    Creator != null &&
                    Creator.Equals(other.Creator)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) && 
                (
                    ShareTags == other.ShareTags ||
                    ShareTags != null &&
                    ShareTags.Equals(other.ShareTags)
                ) && 
                (
                    SapAsset == other.SapAsset ||
                    SapAsset != null &&
                    SapAsset.Equals(other.SapAsset)
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
                    if (TagId != null)
                    hashCode = hashCode * 59 + TagId.GetHashCode();
                    if (SecondTagId != null)
                    hashCode = hashCode * 59 + SecondTagId.GetHashCode();
                    if (IsUntaggable != null)
                    hashCode = hashCode * 59 + IsUntaggable.GetHashCode();
                    if (Latitude != null)
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    if (Longitude != null)
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                    if (LastModified != null)
                    hashCode = hashCode * 59 + LastModified.GetHashCode();
                    if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                    if (Creator != null)
                    hashCode = hashCode * 59 + Creator.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (ShareTags != null)
                    hashCode = hashCode * 59 + ShareTags.GetHashCode();
                    if (SapAsset != null)
                    hashCode = hashCode * 59 + SapAsset.GetHashCode();
                    if (AssetNumber != null)
                    hashCode = hashCode * 59 + AssetNumber.GetHashCode();
                    if (SubNumber != null)
                    hashCode = hashCode * 59 + SubNumber.GetHashCode();
                    if (CompanyCode != null)
                    hashCode = hashCode * 59 + CompanyCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Asset left, Asset right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Asset left, Asset right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

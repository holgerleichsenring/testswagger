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
    public partial class AssetPutResource : IEquatable<AssetPutResource>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetPutResource {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  SecondTagId: ").Append(SecondTagId).Append("\n");
            sb.Append("  IsUntaggable: ").Append(IsUntaggable).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ShareTags: ").Append(ShareTags).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetPutResource)obj);
        }

        /// <summary>
        /// Returns true if AssetPutResource instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetPutResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetPutResource other)
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
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) && 
                (
                    ShareTags == other.ShareTags ||
                    ShareTags != null &&
                    ShareTags.Equals(other.ShareTags)
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
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (ShareTags != null)
                    hashCode = hashCode * 59 + ShareTags.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetPutResource left, AssetPutResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetPutResource left, AssetPutResource right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

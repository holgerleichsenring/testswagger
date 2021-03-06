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
    public partial class InventoryOrderAssetStatusPutResource : IEquatable<InventoryOrderAssetStatusPutResource>
    { 
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
        /// Gets or Sets Status
        /// </summary>
        
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum _0Enum for 0
            /// </summary>
            
            _0Enum = 0,
            
            /// <summary>
            /// Enum _1Enum for 1
            /// </summary>
            
            _1Enum = 1,
            
            /// <summary>
            /// Enum _2Enum for 2
            /// </summary>
            
            _2Enum = 2,
            
            /// <summary>
            /// Enum _3Enum for 3
            /// </summary>
            
            _3Enum = 3,
            
            /// <summary>
            /// Enum _4Enum for 4
            /// </summary>
            
            _4Enum = 4,
            
            /// <summary>
            /// Enum _5Enum for 5
            /// </summary>
            
            _5Enum = 5
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets Checked
        /// </summary>
        [DataMember(Name="checked")]
        public bool? Checked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryOrderAssetStatusPutResource {\n");
            sb.Append("  AssetNumber: ").Append(AssetNumber).Append("\n");
            sb.Append("  SubNumber: ").Append(SubNumber).Append("\n");
            sb.Append("  CompanyCode: ").Append(CompanyCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Checked: ").Append(Checked).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InventoryOrderAssetStatusPutResource)obj);
        }

        /// <summary>
        /// Returns true if InventoryOrderAssetStatusPutResource instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryOrderAssetStatusPutResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryOrderAssetStatusPutResource other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Checked == other.Checked ||
                    Checked != null &&
                    Checked.Equals(other.Checked)
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
                    if (AssetNumber != null)
                    hashCode = hashCode * 59 + AssetNumber.GetHashCode();
                    if (SubNumber != null)
                    hashCode = hashCode * 59 + SubNumber.GetHashCode();
                    if (CompanyCode != null)
                    hashCode = hashCode * 59 + CompanyCode.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Checked != null)
                    hashCode = hashCode * 59 + Checked.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InventoryOrderAssetStatusPutResource left, InventoryOrderAssetStatusPutResource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InventoryOrderAssetStatusPutResource left, InventoryOrderAssetStatusPutResource right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

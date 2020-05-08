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
    public partial class InventoryAssetFullTextAndPropertySearch : IEquatable<InventoryAssetFullTextAndPropertySearch>
    { 
        /// <summary>
        /// Gets or Sets SearchString
        /// </summary>
        [DataMember(Name="searchString")]
        public string SearchString { get; set; }

        /// <summary>
        /// Gets or Sets InventoryOrderId
        /// </summary>
        [Required]
        [DataMember(Name="inventoryOrderId")]
        public int? InventoryOrderId { get; set; }

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
        /// Gets or Sets SortingColumn
        /// </summary>
        [DataMember(Name="sortingColumn")]
        public string SortingColumn { get; set; }

        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name="tagId")]
        public string TagId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AssetNumber
        /// </summary>
        [DataMember(Name="assetNumber")]
        public string AssetNumber { get; set; }

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
        /// Gets or Sets AssetClass
        /// </summary>
        [DataMember(Name="assetClass")]
        public string AssetClass { get; set; }

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
        /// Gets or Sets InventoryNumber
        /// </summary>
        [DataMember(Name="inventoryNumber")]
        public string InventoryNumber { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Room
        /// </summary>
        [DataMember(Name="room")]
        public string Room { get; set; }

        /// <summary>
        /// Gets or Sets CostCenter
        /// </summary>
        [DataMember(Name="costCenter")]
        public string CostCenter { get; set; }

        /// <summary>
        /// Gets or Sets CapitalisationDate
        /// </summary>
        [DataMember(Name="capitalisationDate")]
        public DateTime? CapitalisationDate { get; set; }

        /// <summary>
        /// Gets or Sets LastInventoryDate
        /// </summary>
        [DataMember(Name="lastInventoryDate")]
        public DateTime? LastInventoryDate { get; set; }

        /// <summary>
        /// Gets or Sets AcquisitionValue
        /// </summary>
        [DataMember(Name="acquisitionValue")]
        public double? AcquisitionValue { get; set; }

        /// <summary>
        /// Gets or Sets AssetSuperNumber
        /// </summary>
        [DataMember(Name="assetSuperNumber")]
        public string AssetSuperNumber { get; set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or Sets TypeName
        /// </summary>
        [DataMember(Name="typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or Sets Plant
        /// </summary>
        [DataMember(Name="plant")]
        public string Plant { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets Untaggable
        /// </summary>
        [DataMember(Name="untaggable")]
        public bool? Untaggable { get; set; }

        /// <summary>
        /// Gets or Sets Untagged
        /// </summary>
        [DataMember(Name="untagged")]
        public bool? Untagged { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [Required]
        [DataMember(Name="page")]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [Required]
        [DataMember(Name="pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryAssetFullTextAndPropertySearch {\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  InventoryOrderId: ").Append(InventoryOrderId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SortingColumn: ").Append(SortingColumn).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AssetNumber: ").Append(AssetNumber).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  AssetClass: ").Append(AssetClass).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  SubNumber: ").Append(SubNumber).Append("\n");
            sb.Append("  CompanyCode: ").Append(CompanyCode).Append("\n");
            sb.Append("  InventoryNumber: ").Append(InventoryNumber).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Room: ").Append(Room).Append("\n");
            sb.Append("  CostCenter: ").Append(CostCenter).Append("\n");
            sb.Append("  CapitalisationDate: ").Append(CapitalisationDate).Append("\n");
            sb.Append("  LastInventoryDate: ").Append(LastInventoryDate).Append("\n");
            sb.Append("  AcquisitionValue: ").Append(AcquisitionValue).Append("\n");
            sb.Append("  AssetSuperNumber: ").Append(AssetSuperNumber).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  Plant: ").Append(Plant).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Untaggable: ").Append(Untaggable).Append("\n");
            sb.Append("  Untagged: ").Append(Untagged).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InventoryAssetFullTextAndPropertySearch)obj);
        }

        /// <summary>
        /// Returns true if InventoryAssetFullTextAndPropertySearch instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryAssetFullTextAndPropertySearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryAssetFullTextAndPropertySearch other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SearchString == other.SearchString ||
                    SearchString != null &&
                    SearchString.Equals(other.SearchString)
                ) && 
                (
                    InventoryOrderId == other.InventoryOrderId ||
                    InventoryOrderId != null &&
                    InventoryOrderId.Equals(other.InventoryOrderId)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    SortingColumn == other.SortingColumn ||
                    SortingColumn != null &&
                    SortingColumn.Equals(other.SortingColumn)
                ) && 
                (
                    TagId == other.TagId ||
                    TagId != null &&
                    TagId.Equals(other.TagId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    AssetNumber == other.AssetNumber ||
                    AssetNumber != null &&
                    AssetNumber.Equals(other.AssetNumber)
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
                    AssetClass == other.AssetClass ||
                    AssetClass != null &&
                    AssetClass.Equals(other.AssetClass)
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
                    InventoryNumber == other.InventoryNumber ||
                    InventoryNumber != null &&
                    InventoryNumber.Equals(other.InventoryNumber)
                ) && 
                (
                    SerialNumber == other.SerialNumber ||
                    SerialNumber != null &&
                    SerialNumber.Equals(other.SerialNumber)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    Room == other.Room ||
                    Room != null &&
                    Room.Equals(other.Room)
                ) && 
                (
                    CostCenter == other.CostCenter ||
                    CostCenter != null &&
                    CostCenter.Equals(other.CostCenter)
                ) && 
                (
                    CapitalisationDate == other.CapitalisationDate ||
                    CapitalisationDate != null &&
                    CapitalisationDate.Equals(other.CapitalisationDate)
                ) && 
                (
                    LastInventoryDate == other.LastInventoryDate ||
                    LastInventoryDate != null &&
                    LastInventoryDate.Equals(other.LastInventoryDate)
                ) && 
                (
                    AcquisitionValue == other.AcquisitionValue ||
                    AcquisitionValue != null &&
                    AcquisitionValue.Equals(other.AcquisitionValue)
                ) && 
                (
                    AssetSuperNumber == other.AssetSuperNumber ||
                    AssetSuperNumber != null &&
                    AssetSuperNumber.Equals(other.AssetSuperNumber)
                ) && 
                (
                    Vendor == other.Vendor ||
                    Vendor != null &&
                    Vendor.Equals(other.Vendor)
                ) && 
                (
                    TypeName == other.TypeName ||
                    TypeName != null &&
                    TypeName.Equals(other.TypeName)
                ) && 
                (
                    Plant == other.Plant ||
                    Plant != null &&
                    Plant.Equals(other.Plant)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    Unit == other.Unit ||
                    Unit != null &&
                    Unit.Equals(other.Unit)
                ) && 
                (
                    Untaggable == other.Untaggable ||
                    Untaggable != null &&
                    Untaggable.Equals(other.Untaggable)
                ) && 
                (
                    Untagged == other.Untagged ||
                    Untagged != null &&
                    Untagged.Equals(other.Untagged)
                ) && 
                (
                    Page == other.Page ||
                    Page != null &&
                    Page.Equals(other.Page)
                ) && 
                (
                    PageSize == other.PageSize ||
                    PageSize != null &&
                    PageSize.Equals(other.PageSize)
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
                    if (SearchString != null)
                    hashCode = hashCode * 59 + SearchString.GetHashCode();
                    if (InventoryOrderId != null)
                    hashCode = hashCode * 59 + InventoryOrderId.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (SortingColumn != null)
                    hashCode = hashCode * 59 + SortingColumn.GetHashCode();
                    if (TagId != null)
                    hashCode = hashCode * 59 + TagId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (AssetNumber != null)
                    hashCode = hashCode * 59 + AssetNumber.GetHashCode();
                    if (Latitude != null)
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    if (Longitude != null)
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                    if (AssetClass != null)
                    hashCode = hashCode * 59 + AssetClass.GetHashCode();
                    if (LastModified != null)
                    hashCode = hashCode * 59 + LastModified.GetHashCode();
                    if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                    if (Creator != null)
                    hashCode = hashCode * 59 + Creator.GetHashCode();
                    if (SubNumber != null)
                    hashCode = hashCode * 59 + SubNumber.GetHashCode();
                    if (CompanyCode != null)
                    hashCode = hashCode * 59 + CompanyCode.GetHashCode();
                    if (InventoryNumber != null)
                    hashCode = hashCode * 59 + InventoryNumber.GetHashCode();
                    if (SerialNumber != null)
                    hashCode = hashCode * 59 + SerialNumber.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (Room != null)
                    hashCode = hashCode * 59 + Room.GetHashCode();
                    if (CostCenter != null)
                    hashCode = hashCode * 59 + CostCenter.GetHashCode();
                    if (CapitalisationDate != null)
                    hashCode = hashCode * 59 + CapitalisationDate.GetHashCode();
                    if (LastInventoryDate != null)
                    hashCode = hashCode * 59 + LastInventoryDate.GetHashCode();
                    if (AcquisitionValue != null)
                    hashCode = hashCode * 59 + AcquisitionValue.GetHashCode();
                    if (AssetSuperNumber != null)
                    hashCode = hashCode * 59 + AssetSuperNumber.GetHashCode();
                    if (Vendor != null)
                    hashCode = hashCode * 59 + Vendor.GetHashCode();
                    if (TypeName != null)
                    hashCode = hashCode * 59 + TypeName.GetHashCode();
                    if (Plant != null)
                    hashCode = hashCode * 59 + Plant.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                    if (Untaggable != null)
                    hashCode = hashCode * 59 + Untaggable.GetHashCode();
                    if (Untagged != null)
                    hashCode = hashCode * 59 + Untagged.GetHashCode();
                    if (Page != null)
                    hashCode = hashCode * 59 + Page.GetHashCode();
                    if (PageSize != null)
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InventoryAssetFullTextAndPropertySearch left, InventoryAssetFullTextAndPropertySearch right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InventoryAssetFullTextAndPropertySearch left, InventoryAssetFullTextAndPropertySearch right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}

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
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class InventoryAssetsByStatusDefaultApiController : ControllerBase
    { 
        /// <summary>
        /// Gets the InventoryOrderAsset with status default specified by id.  This query must be paged. If page and pageSize are omitted,  there will be a HTTP 400 in return.
        /// </summary>
        
        /// <param name="inventoryId">The inventoryOrderId to filter by Status default.</param>
        /// <param name="sortingColumn">define the columns by which the list will be sorted. Find the list of possible columns via AssetSortingColumnsController</param>
        /// <param name="page">define the page that this query will return</param>
        /// <param name="pageSize">define the number of items each page will contain if records are available</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/inventoryassets/bystatusdefault")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Get")]
        [SwaggerResponse(statusCode: 200, type: typeof(PagedResultInventoryOrderAsset), description: "Success")]
        public virtual IActionResult Get([FromQuery]int? inventoryId, [FromQuery]string sortingColumn, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PagedResultInventoryOrderAsset));

            string exampleJson = null;
            exampleJson = "{\n  \"pageCount\" : 6,\n  \"lastRowOnPage\" : 2,\n  \"pageSize\" : 1,\n  \"firstRowOnPage\" : 5,\n  \"rowCount\" : 5,\n  \"currentPage\" : 0,\n  \"results\" : [ {\n    \"companyCode\" : \"companyCode\",\n    \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"commentCostCenter\" : \"commentCostCenter\",\n    \"inventoryOrderId\" : 0,\n    \"subNumber\" : \"subNumber\",\n    \"commentLocation\" : \"commentLocation\",\n    \"assetNumber\" : \"assetNumber\",\n    \"changedBy\" : \"changedBy\",\n    \"checked\" : true,\n    \"commentPlant\" : \"commentPlant\",\n    \"lastModified\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"commentOther\" : \"commentOther\",\n    \"asset\" : {\n      \"companyCode\" : \"companyCode\",\n      \"creator\" : \"creator\",\n      \"sapAsset\" : {\n        \"companyCode\" : \"companyCode\",\n        \"serialNumber\" : \"serialNumber\",\n        \"quantity\" : 5.962133916683182,\n        \"costCenter\" : \"costCenter\",\n        \"capitalisationDate\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"deactivatedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"typeName\" : \"typeName\",\n        \"description\" : \"description\",\n        \"acquisitionValue\" : 1.4658129805029452,\n        \"assetClass\" : \"assetClass\",\n        \"room\" : \"room\",\n        \"subNumber\" : \"subNumber\",\n        \"inventoryNumber\" : \"inventoryNumber\",\n        \"unit\" : \"unit\",\n        \"assetNumber\" : \"assetNumber\",\n        \"isDeactivated\" : true,\n        \"vendor\" : \"vendor\",\n        \"plant\" : \"plant\",\n        \"location\" : \"location\",\n        \"assetSuperNumber\" : \"assetSuperNumber\",\n        \"lastInventoryDate\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"companyCodeCurrency\" : \"companyCodeCurrency\"\n      },\n      \"tagId\" : \"tagId\",\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"latitude\" : 0.8008281904610115,\n      \"shareTags\" : true,\n      \"isUntaggable\" : true,\n      \"subNumber\" : \"subNumber\",\n      \"secondTagId\" : \"secondTagId\",\n      \"assetNumber\" : \"assetNumber\",\n      \"comment\" : \"comment\",\n      \"lastModified\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"longitude\" : 6.027456183070403\n    },\n    \"status\" : 6\n  }, {\n    \"companyCode\" : \"companyCode\",\n    \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"commentCostCenter\" : \"commentCostCenter\",\n    \"inventoryOrderId\" : 0,\n    \"subNumber\" : \"subNumber\",\n    \"commentLocation\" : \"commentLocation\",\n    \"assetNumber\" : \"assetNumber\",\n    \"changedBy\" : \"changedBy\",\n    \"checked\" : true,\n    \"commentPlant\" : \"commentPlant\",\n    \"lastModified\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"commentOther\" : \"commentOther\",\n    \"asset\" : {\n      \"companyCode\" : \"companyCode\",\n      \"creator\" : \"creator\",\n      \"sapAsset\" : {\n        \"companyCode\" : \"companyCode\",\n        \"serialNumber\" : \"serialNumber\",\n        \"quantity\" : 5.962133916683182,\n        \"costCenter\" : \"costCenter\",\n        \"capitalisationDate\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"deactivatedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"typeName\" : \"typeName\",\n        \"description\" : \"description\",\n        \"acquisitionValue\" : 1.4658129805029452,\n        \"assetClass\" : \"assetClass\",\n        \"room\" : \"room\",\n        \"subNumber\" : \"subNumber\",\n        \"inventoryNumber\" : \"inventoryNumber\",\n        \"unit\" : \"unit\",\n        \"assetNumber\" : \"assetNumber\",\n        \"isDeactivated\" : true,\n        \"vendor\" : \"vendor\",\n        \"plant\" : \"plant\",\n        \"location\" : \"location\",\n        \"assetSuperNumber\" : \"assetSuperNumber\",\n        \"lastInventoryDate\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"companyCodeCurrency\" : \"companyCodeCurrency\"\n      },\n      \"tagId\" : \"tagId\",\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"latitude\" : 0.8008281904610115,\n      \"shareTags\" : true,\n      \"isUntaggable\" : true,\n      \"subNumber\" : \"subNumber\",\n      \"secondTagId\" : \"secondTagId\",\n      \"assetNumber\" : \"assetNumber\",\n      \"comment\" : \"comment\",\n      \"lastModified\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"longitude\" : 6.027456183070403\n    },\n    \"status\" : 6\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PagedResultInventoryOrderAsset>(exampleJson)
            : default(PagedResultInventoryOrderAsset);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}

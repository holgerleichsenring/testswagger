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
    public class InventoryAssetsControllerV2ApiController : ControllerBase
    { 
        /// <summary>
        /// Gets the InventoryOrderAsset with status default specified by id.  This query must be paged. If page and pageSize are omitted,  there will be a HTTP 400 in return.
        /// </summary>
        
        /// <param name="inventoryid">The inventoryOrderId to filter by Status default.</param>
        /// <param name="sortingColumn">define the columns by which the list will be sorted. Find the list of possible columns via AssetSortingColumnsController</param>
        /// <param name="page">define the page that this query will return</param>
        /// <param name="pageSize">define the number of items each page will contain if records are available</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/v2/inventories/{inventoryid}/assets/bystatusdefault")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Get")]
        [SwaggerResponse(statusCode: 200, type: typeof(PagedResultInventoryOrderAssetResource), description: "Success")]
        public virtual IActionResult Get([FromRoute][Required]int? inventoryid, [FromQuery]string sortingColumn, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PagedResultInventoryOrderAssetResource));

            string exampleJson = null;
            exampleJson = "{\n  \"pageCount\" : 5,\n  \"lastRowOnPage\" : 9,\n  \"pageSize\" : 5,\n  \"firstRowOnPage\" : 7,\n  \"rowCount\" : 2,\n  \"currentPage\" : 1,\n  \"results\" : [ {\n    \"commentLocation\" : \"commentLocation\",\n    \"commentCostCenter\" : \"commentCostCenter\",\n    \"checked\" : true,\n    \"commentPlant\" : \"commentPlant\",\n    \"commentOther\" : \"commentOther\",\n    \"asset\" : {\n      \"tagId\" : \"tagId\",\n      \"capitalisationDate\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"deactivatedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"typeName\" : \"typeName\",\n      \"description\" : \"description\",\n      \"acquisitionValue\" : 0.8008281904610115,\n      \"assetClass\" : \"assetClass\",\n      \"isUntaggable\" : true,\n      \"inventoryNumber\" : \"inventoryNumber\",\n      \"assetNumber\" : \"assetNumber\",\n      \"isDeactivated\" : true,\n      \"vendor\" : \"vendor\",\n      \"lastInventoryDate\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"companyCodeCurrency\" : \"companyCodeCurrency\",\n      \"companyCode\" : \"companyCode\",\n      \"creator\" : \"creator\",\n      \"serialNumber\" : \"serialNumber\",\n      \"quantity\" : 6.027456183070403,\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"costCenter\" : \"costCenter\",\n      \"shareTags\" : true,\n      \"subNumber\" : \"subNumber\",\n      \"room\" : \"room\",\n      \"secondTagId\" : \"secondTagId\",\n      \"unit\" : \"unit\",\n      \"plant\" : \"plant\",\n      \"location\" : \"location\",\n      \"comment\" : \"comment\",\n      \"lastModified\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"assetSuperNumber\" : \"assetSuperNumber\"\n    },\n    \"inventoryOrderId\" : 0,\n    \"status\" : 6\n  }, {\n    \"commentLocation\" : \"commentLocation\",\n    \"commentCostCenter\" : \"commentCostCenter\",\n    \"checked\" : true,\n    \"commentPlant\" : \"commentPlant\",\n    \"commentOther\" : \"commentOther\",\n    \"asset\" : {\n      \"tagId\" : \"tagId\",\n      \"capitalisationDate\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"deactivatedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"typeName\" : \"typeName\",\n      \"description\" : \"description\",\n      \"acquisitionValue\" : 0.8008281904610115,\n      \"assetClass\" : \"assetClass\",\n      \"isUntaggable\" : true,\n      \"inventoryNumber\" : \"inventoryNumber\",\n      \"assetNumber\" : \"assetNumber\",\n      \"isDeactivated\" : true,\n      \"vendor\" : \"vendor\",\n      \"lastInventoryDate\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"companyCodeCurrency\" : \"companyCodeCurrency\",\n      \"companyCode\" : \"companyCode\",\n      \"creator\" : \"creator\",\n      \"serialNumber\" : \"serialNumber\",\n      \"quantity\" : 6.027456183070403,\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"costCenter\" : \"costCenter\",\n      \"shareTags\" : true,\n      \"subNumber\" : \"subNumber\",\n      \"room\" : \"room\",\n      \"secondTagId\" : \"secondTagId\",\n      \"unit\" : \"unit\",\n      \"plant\" : \"plant\",\n      \"location\" : \"location\",\n      \"comment\" : \"comment\",\n      \"lastModified\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"assetSuperNumber\" : \"assetSuperNumber\"\n    },\n    \"inventoryOrderId\" : 0,\n    \"status\" : 6\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PagedResultInventoryOrderAssetResource>(exampleJson)
            : default(PagedResultInventoryOrderAssetResource);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets the InventoryOrderAssets with status different than default specified by id.  This query must be paged. If page and pageSize are omitted,  there will be a HTTP 400 in return.
        /// </summary>
        
        /// <param name="inventoryid">The inventoryOrderId to filter by Status active, missing or broken.</param>
        /// <param name="page">define the page that this query will return</param>
        /// <param name="pageSize">define the number of items each page will contain if records are available</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/v2/inventories/{inventoryid}/assets/bystatusother")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Get_0")]
        [SwaggerResponse(statusCode: 200, type: typeof(PagedResultInventoryOrderAssetResource), description: "Success")]
        public virtual IActionResult Get_0([FromRoute][Required]int? inventoryid, [FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PagedResultInventoryOrderAssetResource));

            string exampleJson = null;
            exampleJson = "{\n  \"pageCount\" : 5,\n  \"lastRowOnPage\" : 9,\n  \"pageSize\" : 5,\n  \"firstRowOnPage\" : 7,\n  \"rowCount\" : 2,\n  \"currentPage\" : 1,\n  \"results\" : [ {\n    \"commentLocation\" : \"commentLocation\",\n    \"commentCostCenter\" : \"commentCostCenter\",\n    \"checked\" : true,\n    \"commentPlant\" : \"commentPlant\",\n    \"commentOther\" : \"commentOther\",\n    \"asset\" : {\n      \"tagId\" : \"tagId\",\n      \"capitalisationDate\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"deactivatedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"typeName\" : \"typeName\",\n      \"description\" : \"description\",\n      \"acquisitionValue\" : 0.8008281904610115,\n      \"assetClass\" : \"assetClass\",\n      \"isUntaggable\" : true,\n      \"inventoryNumber\" : \"inventoryNumber\",\n      \"assetNumber\" : \"assetNumber\",\n      \"isDeactivated\" : true,\n      \"vendor\" : \"vendor\",\n      \"lastInventoryDate\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"companyCodeCurrency\" : \"companyCodeCurrency\",\n      \"companyCode\" : \"companyCode\",\n      \"creator\" : \"creator\",\n      \"serialNumber\" : \"serialNumber\",\n      \"quantity\" : 6.027456183070403,\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"costCenter\" : \"costCenter\",\n      \"shareTags\" : true,\n      \"subNumber\" : \"subNumber\",\n      \"room\" : \"room\",\n      \"secondTagId\" : \"secondTagId\",\n      \"unit\" : \"unit\",\n      \"plant\" : \"plant\",\n      \"location\" : \"location\",\n      \"comment\" : \"comment\",\n      \"lastModified\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"assetSuperNumber\" : \"assetSuperNumber\"\n    },\n    \"inventoryOrderId\" : 0,\n    \"status\" : 6\n  }, {\n    \"commentLocation\" : \"commentLocation\",\n    \"commentCostCenter\" : \"commentCostCenter\",\n    \"checked\" : true,\n    \"commentPlant\" : \"commentPlant\",\n    \"commentOther\" : \"commentOther\",\n    \"asset\" : {\n      \"tagId\" : \"tagId\",\n      \"capitalisationDate\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"deactivatedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"typeName\" : \"typeName\",\n      \"description\" : \"description\",\n      \"acquisitionValue\" : 0.8008281904610115,\n      \"assetClass\" : \"assetClass\",\n      \"isUntaggable\" : true,\n      \"inventoryNumber\" : \"inventoryNumber\",\n      \"assetNumber\" : \"assetNumber\",\n      \"isDeactivated\" : true,\n      \"vendor\" : \"vendor\",\n      \"lastInventoryDate\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"companyCodeCurrency\" : \"companyCodeCurrency\",\n      \"companyCode\" : \"companyCode\",\n      \"creator\" : \"creator\",\n      \"serialNumber\" : \"serialNumber\",\n      \"quantity\" : 6.027456183070403,\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"costCenter\" : \"costCenter\",\n      \"shareTags\" : true,\n      \"subNumber\" : \"subNumber\",\n      \"room\" : \"room\",\n      \"secondTagId\" : \"secondTagId\",\n      \"unit\" : \"unit\",\n      \"plant\" : \"plant\",\n      \"location\" : \"location\",\n      \"comment\" : \"comment\",\n      \"lastModified\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"assetSuperNumber\" : \"assetSuperNumber\"\n    },\n    \"inventoryOrderId\" : 0,\n    \"status\" : 6\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PagedResultInventoryOrderAssetResource>(exampleJson)
            : default(PagedResultInventoryOrderAssetResource);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update one or multiple InventoryOrderAsset instances.
        /// </summary>
        
        /// <param name="inventoryid">The affected InventoryOrderId.</param>
        /// <param name="inventoryOrderAssets">Instances of InventoryOrderAssets to update</param>
        /// <response code="204">Success</response>
        [HttpPut]
        [Route("/api/v2/inventories/{inventoryid}/assets")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Update")]
        public virtual IActionResult Update([FromRoute][Required]int? inventoryid, [FromBody]List<InventoryOrderAssetPutResource> inventoryOrderAssets)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates status for multiple assets of one InventoryOrder.
        /// </summary>
        
        /// <param name="inventoryid">The InventoryOrderId to be updated.</param>
        /// <param name="inventoryOrderAssetStatuses">Array of assets with status</param>
        /// <response code="204">Success</response>
        [HttpPut]
        [Route("/api/v2/inventories/{inventoryid}/assetstatuses")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("UpdateStatusAndChecked")]
        public virtual IActionResult UpdateStatusAndChecked([FromRoute][Required]int? inventoryid, [FromBody]List<InventoryOrderAssetStatusPutResource> inventoryOrderAssetStatuses)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);


            throw new NotImplementedException();
        }
    }
}

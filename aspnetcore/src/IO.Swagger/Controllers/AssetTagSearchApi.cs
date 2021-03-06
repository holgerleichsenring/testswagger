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
    public class AssetTagSearchApiController : ControllerBase
    { 
        /// <summary>
        /// Allows for searching assets via tags
        /// </summary>
        
        /// <param name="tagSearch">Query parameters for searching and paging</param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/assets/search/bytags")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Post")]
        [SwaggerResponse(statusCode: 200, type: typeof(TagSearchResult), description: "Success")]
        public virtual IActionResult Post([FromBody]TagSearch tagSearch)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TagSearchResult));

            string exampleJson = null;
            exampleJson = "{\n  \"validAssets\" : [ {\n    \"companyCode\" : \"companyCode\",\n    \"assetNumber\" : \"assetNumber\",\n    \"tagId\" : \"tagId\",\n    \"inventoryVariantName\" : \"inventoryVariantName\",\n    \"description\" : \"description\",\n    \"subNumber\" : \"subNumber\"\n  }, {\n    \"companyCode\" : \"companyCode\",\n    \"assetNumber\" : \"assetNumber\",\n    \"tagId\" : \"tagId\",\n    \"inventoryVariantName\" : \"inventoryVariantName\",\n    \"description\" : \"description\",\n    \"subNumber\" : \"subNumber\"\n  } ],\n  \"remainingTags\" : [ {\n    \"isValid\" : true,\n    \"inUse\" : true,\n    \"tag\" : \"tag\"\n  }, {\n    \"isValid\" : true,\n    \"inUse\" : true,\n    \"tag\" : \"tag\"\n  } ],\n  \"invalidAssets\" : [ {\n    \"companyCode\" : \"companyCode\",\n    \"assetNumber\" : \"assetNumber\",\n    \"tagId\" : \"tagId\",\n    \"inventoryVariantName\" : \"inventoryVariantName\",\n    \"description\" : \"description\",\n    \"subNumber\" : \"subNumber\"\n  }, {\n    \"companyCode\" : \"companyCode\",\n    \"assetNumber\" : \"assetNumber\",\n    \"tagId\" : \"tagId\",\n    \"inventoryVariantName\" : \"inventoryVariantName\",\n    \"description\" : \"description\",\n    \"subNumber\" : \"subNumber\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TagSearchResult>(exampleJson)
            : default(TagSearchResult);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}

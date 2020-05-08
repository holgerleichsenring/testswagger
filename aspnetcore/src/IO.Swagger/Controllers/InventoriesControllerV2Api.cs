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
    public class InventoriesControllerV2ApiController : ControllerBase
    { 
        /// <summary>
        /// Creates an InventoryOrder instance.
        /// </summary>
        
        /// <param name="inventoryOrderCreation">Defines the inventory order to be created and the inventory variant that is used to populate assets.</param>
        /// <response code="201">Success</response>
        [HttpPost]
        [Route("/api/v2/inventories")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Create")]
        [SwaggerResponse(statusCode: 201, type: typeof(InventoryOrder), description: "Success")]
        public virtual IActionResult Create([FromBody]InventoryOrderCreation inventoryOrderCreation)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(InventoryOrder));

            string exampleJson = null;
            exampleJson = "{\n  \"creator\" : \"creator\",\n  \"reportDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"hasOnlyUntaggedAssets\" : true,\n  \"inventoryVariantName\" : \"inventoryVariantName\",\n  \"description\" : \"description\",\n  \"assignees\" : [ {\n    \"id\" : \"id\",\n    \"assignee\" : \"assignee\",\n    \"inventoryOrderId\" : 6\n  }, {\n    \"id\" : \"id\",\n    \"assignee\" : \"assignee\",\n    \"inventoryOrderId\" : 6\n  } ],\n  \"id\" : 0,\n  \"status\" : 1\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InventoryOrder>(exampleJson)
            : default(InventoryOrder);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates InventoryOrder instances.
        /// </summary>
        
        /// <param name="inventoryOrders">The inventoryOrders to be updated.</param>
        /// <response code="204">Success</response>
        [HttpPut]
        [Route("/api/v2/inventories")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Updates")]
        public virtual IActionResult Updates([FromBody]List<InventoryOrderPutResource> inventoryOrders)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);


            throw new NotImplementedException();
        }
    }
}
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
    public class VendorsApiController : ControllerBase
    { 
        /// <summary>
        /// Returns list of Vendors. This query can be paged. If page and pageSize are omitted,  the full list is going to be returned. When pageSize and page specified,  pageCount and currentPage will be returned on first call.
        /// </summary>
        
        /// <param name="page">define the page that this query will return</param>
        /// <param name="pageSize">define the number of items each page will contain if records are available</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/vendors")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("Get")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<string>), description: "Success")]
        public virtual IActionResult Get([FromQuery]int? page, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<string>));

            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
            : default(List<string>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}

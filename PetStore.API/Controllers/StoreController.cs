/*
 * Swagger Petstore
 *
 * This is a sample server Petstore server.  You can find out more about     Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).      For this sample, you can use the api key `special-key` to test the authorization     filters.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PetStore.API.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace PetStore.API.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class StoreApiController : ControllerBase
    { 
        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors</remarks>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpDelete]
        [Route("/v2/store/order/{orderId}")]
        
        [SwaggerOperation("DeleteOrder")]
        public virtual IActionResult DeleteOrder([FromRoute][Required]long? orderId)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>Returns a map of status codes to quantities</remarks>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("/v2/store/inventory")]
        [Authorize]
        
        [SwaggerOperation("GetInventory")]
        [SwaggerResponse(statusCode: 200, type: typeof(Dictionary<string, int?>), description: "successful operation")]
        public virtual IActionResult GetInventory()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Dictionary<string, int?>));

            string exampleJson = null;
            exampleJson = "{\n  \"key\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Dictionary<string, int?>>(exampleJson)
            : default(Dictionary<string, int?>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions</remarks>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpGet]
        [Route("/v2/store/order/{orderId}")]
        
        [SwaggerOperation("GetOrderById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "successful operation")]
        public virtual IActionResult GetOrderById([FromRoute][Required][Range(1, 10)]long? orderId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Order));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "<Order>\n  <id>123456789</id>\n  <petId>123456789</petId>\n  <quantity>123</quantity>\n  <shipDate>2000-01-23T04:56:07.000Z</shipDate>\n  <status>aeiou</status>\n  <complete>true</complete>\n</Order>";
            exampleJson = "{\n  \"petId\" : 6,\n  \"quantity\" : 1,\n  \"id\" : 0,\n  \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"complete\" : false,\n  \"status\" : \"placed\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Order>(exampleJson)
            : default(Order);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Place an order for a pet
        /// </summary>
        
        /// <param name="body">order placed for purchasing the pet</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid Order</response>
        [HttpPost]
        [Route("/v2/store/order")]
        
        [SwaggerOperation("PlaceOrder")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "successful operation")]
        public virtual IActionResult PlaceOrder([FromBody]Order body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Order));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            string exampleJson = null;
            exampleJson = "<Order>\n  <id>123456789</id>\n  <petId>123456789</petId>\n  <quantity>123</quantity>\n  <shipDate>2000-01-23T04:56:07.000Z</shipDate>\n  <status>aeiou</status>\n  <complete>true</complete>\n</Order>";
            exampleJson = "{\n  \"petId\" : 6,\n  \"quantity\" : 1,\n  \"id\" : 0,\n  \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"complete\" : false,\n  \"status\" : \"placed\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Order>(exampleJson)
            : default(Order);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}

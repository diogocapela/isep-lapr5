/* 
 * Master Data Factory (MDF) - API
 *
 * Rest API for MDF Master Data Factory
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using factory.api.client.Client;
using factory.api.client.Api;
using factory.api.client.Model;

namespace factory.api.client.Test
{
    /// <summary>
    ///  Class for testing ProductionLinesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductionLinesApiTests : IDisposable
    {
        private ProductionLinesApi instance;

        public ProductionLinesApiTests()
        {
            instance = new ProductionLinesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductionLinesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductionLinesApi
            //Assert.IsType(typeof(ProductionLinesApi), instance, "instance is a ProductionLinesApi");
        }

        
        /// <summary>
        /// Test ProductionLinesDelete
        /// </summary>
        [Fact]
        public void ProductionLinesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.ProductionLinesDelete(id);
            
        }
        
        /// <summary>
        /// Test ProductionLinesGetProductionLine
        /// </summary>
        [Fact]
        public void ProductionLinesGetProductionLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.ProductionLinesGetProductionLine(id);
            
        }
        
        /// <summary>
        /// Test ProductionLinesGetProductionLines
        /// </summary>
        [Fact]
        public void ProductionLinesGetProductionLinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //instance.ProductionLinesGetProductionLines(offset, limit);
            
        }
        
        /// <summary>
        /// Test ProductionLinesPost
        /// </summary>
        [Fact]
        public void ProductionLinesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InProductionLineDTO inProductionLineDTO = null;
            //instance.ProductionLinesPost(inProductionLineDTO);
            
        }
        
        /// <summary>
        /// Test ProductionLinesPut
        /// </summary>
        [Fact]
        public void ProductionLinesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //InProductionLineDTO inProductionLineDTO = null;
            //instance.ProductionLinesPut(id, inProductionLineDTO);
            
        }
        
    }

}
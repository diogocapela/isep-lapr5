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
    ///  Class for testing MachinesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MachinesApiTests : IDisposable
    {
        private MachinesApi instance;

        public MachinesApiTests()
        {
            instance = new MachinesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MachinesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MachinesApi
            //Assert.IsType(typeof(MachinesApi), instance, "instance is a MachinesApi");
        }

        
        /// <summary>
        /// Test MachinesCreate
        /// </summary>
        [Fact]
        public void MachinesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InMachineDTO inMachineDTO = null;
            //instance.MachinesCreate(inMachineDTO);
            
        }
        
        /// <summary>
        /// Test MachinesDelete
        /// </summary>
        [Fact]
        public void MachinesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.MachinesDelete(id);
            //Assert.IsType<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test MachinesGetMachine
        /// </summary>
        [Fact]
        public void MachinesGetMachineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.MachinesGetMachine(id);
            
        }
        
        /// <summary>
        /// Test MachinesGetMachines
        /// </summary>
        [Fact]
        public void MachinesGetMachinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string machineTypeName = null;
            //int? offset = null;
            //int? limit = null;
            //instance.MachinesGetMachines(machineTypeName, offset, limit);
            
        }
        
        /// <summary>
        /// Test MachinesPut
        /// </summary>
        [Fact]
        public void MachinesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //InMachineDTO inMachineDTO = null;
            //var response = instance.MachinesPut(id, inMachineDTO);
            //Assert.IsType<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
    }

}

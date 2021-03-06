/* 
 * videoapi
 *
 * The video APIs help you convert, encode, and transcode videos.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.VideoAndMediaServices.Client;
using Cloudmersive.APIClient.NET.VideoAndMediaServices.Api;

namespace Cloudmersive.APIClient.NET.VideoAndMediaServices.Test
{
    /// <summary>
    ///  Class for testing AudioApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AudioApiTests
    {
        private AudioApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AudioApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AudioApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AudioApi
            //Assert.IsInstanceOfType(typeof(AudioApi), instance, "instance is a AudioApi");
        }

        
        /// <summary>
        /// Test AudioConvertToAac
        /// </summary>
        [Test]
        public void AudioConvertToAacTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string fileUrl = null;
            //int? bitRate = null;
            //var response = instance.AudioConvertToAac(inputFile, fileUrl, bitRate);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test AudioConvertToM4a
        /// </summary>
        [Test]
        public void AudioConvertToM4aTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string fileUrl = null;
            //int? bitRate = null;
            //var response = instance.AudioConvertToM4a(inputFile, fileUrl, bitRate);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test AudioConvertToMp3
        /// </summary>
        [Test]
        public void AudioConvertToMp3Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string fileUrl = null;
            //int? bitRate = null;
            //var response = instance.AudioConvertToMp3(inputFile, fileUrl, bitRate);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test AudioConvertToWav
        /// </summary>
        [Test]
        public void AudioConvertToWavTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string fileUrl = null;
            //decimal? sampleRate = null;
            //var response = instance.AudioConvertToWav(inputFile, fileUrl, sampleRate);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}

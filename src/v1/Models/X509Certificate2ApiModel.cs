// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.OpcUa.Api.Vault.v1.Models
{
    using Newtonsoft.Json;
    using System.Linq;
    /// <summary>
    /// 
    /// </summary>
    public partial class X509Certificate2ApiModel
    {
        /// <summary>
        /// Initializes a new instance of the X509Certificate2ApiModel class.
        /// </summary>
        public X509Certificate2ApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X509Certificate2ApiModel class.
        /// </summary>
        public X509Certificate2ApiModel(string subject = default(string), string thumbprint = default(string), string serialNumber = default(string), System.DateTime? notBefore = default(System.DateTime?), System.DateTime? notAfter = default(System.DateTime?), string certificate = default(string))
        {
            Subject = subject;
            Thumbprint = thumbprint;
            SerialNumber = serialNumber;
            NotBefore = notBefore;
            NotAfter = notAfter;
            Certificate = certificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notBefore")]
        public System.DateTime? NotBefore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notAfter")]
        public System.DateTime? NotAfter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string Certificate { get; set; }

    }
}
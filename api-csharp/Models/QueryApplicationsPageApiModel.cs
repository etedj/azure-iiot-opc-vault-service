// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.OpcUa.Api.Vault.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class QueryApplicationsPageApiModel
    {
        /// <summary>
        /// Initializes a new instance of the QueryApplicationsPageApiModel
        /// class.
        /// </summary>
        public QueryApplicationsPageApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryApplicationsPageApiModel
        /// class.
        /// </summary>
        public QueryApplicationsPageApiModel(string applicationName = default(string), string applicationUri = default(string), int? applicationType = default(int?), string productUri = default(string), IList<string> serverCapabilities = default(IList<string>), string nextPageLink = default(string), int? maxRecordsToReturn = default(int?))
        {
            ApplicationName = applicationName;
            ApplicationUri = applicationUri;
            ApplicationType = applicationType;
            ProductUri = productUri;
            ServerCapabilities = serverCapabilities;
            NextPageLink = nextPageLink;
            MaxRecordsToReturn = maxRecordsToReturn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ApplicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ApplicationUri")]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ApplicationType")]
        public int? ApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductUri")]
        public string ProductUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServerCapabilities")]
        public IList<string> ServerCapabilities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NextPageLink")]
        public string NextPageLink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxRecordsToReturn")]
        public int? MaxRecordsToReturn { get; set; }

    }
}

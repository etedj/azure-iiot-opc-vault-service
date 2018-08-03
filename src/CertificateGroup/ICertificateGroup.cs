﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------


using Microsoft.Azure.IIoT.OpcUa.Services.GdsVault.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Microsoft.Azure.IIoT.OpcUa.Services.GdsVault
{
    public interface ICertificateGroup
    {
        Task<string[]> GetCertificateGroupIds();
        Task<Opc.Ua.Gds.Server.CertificateGroupConfiguration> GetCertificateGroupConfiguration(string id);
        Task<Opc.Ua.Gds.Server.CertificateGroupConfigurationCollection> GetCertificateGroupConfigurationCollection();
        Task<X509Certificate2Collection> GetCACertificateChainAsync(string id);
        Task<IList<Opc.Ua.X509CRL>> GetCACrlChainAsync(string id);
        Task<KeyVaultTrustListModel> GetTrustListAsync(string id);

        Task<X509Certificate2> SigningRequestAsync(
            string id,
            string applicationUri,
            byte[] certificateRequest
            );
        Task<Opc.Ua.X509CRL> RevokeCertificateAsync(
            string id,
            X509Certificate2 certificate
            );
        Task<X509Certificate2> CreateCACertificateAsync(
            string id
            );
        Task<Opc.Ua.Gds.Server.X509Certificate2KeyPair> NewKeyPairRequestAsync(
            string id,
            string applicationUri,
            string subjectName,
            string[] domainNames,
            string privateKeyFormat,
            string privateKeyPassword
            );
    }
}
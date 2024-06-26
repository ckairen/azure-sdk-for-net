// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The CSPM P1 for GCP offering. </summary>
    public partial class DefenderCspmGcpOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of <see cref="DefenderCspmGcpOffering"/>. </summary>
        public DefenderCspmGcpOffering()
        {
            OfferingType = OfferingType.DefenderCspmGcp;
        }

        /// <summary> Initializes a new instance of <see cref="DefenderCspmGcpOffering"/>. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="ciemDiscovery"> GCP Defenders CSPM Cloud infrastructure entitlement management (CIEM) discovery offering configurations. </param>
        /// <param name="vmScanners"> The Microsoft Defender for Server VM scanning configuration. </param>
        /// <param name="dataSensitivityDiscovery"> The Microsoft Defender Data Sensitivity discovery configuration. </param>
        /// <param name="mdcContainersImageAssessment"> The Microsoft Defender Container image assessment configuration. </param>
        /// <param name="mdcContainersAgentlessDiscoveryK8S"> The Microsoft Defender Container agentless discovery configuration. </param>
        internal DefenderCspmGcpOffering(OfferingType offeringType, string description, IDictionary<string, BinaryData> serializedAdditionalRawData, DefenderCspmGcpOfferingCiemDiscovery ciemDiscovery, DefenderCspmGcpOfferingVmScanners vmScanners, DefenderCspmGcpOfferingDataSensitivityDiscovery dataSensitivityDiscovery, DefenderCspmGcpOfferingMdcContainersImageAssessment mdcContainersImageAssessment, DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S mdcContainersAgentlessDiscoveryK8S) : base(offeringType, description, serializedAdditionalRawData)
        {
            CiemDiscovery = ciemDiscovery;
            VmScanners = vmScanners;
            DataSensitivityDiscovery = dataSensitivityDiscovery;
            MdcContainersImageAssessment = mdcContainersImageAssessment;
            MdcContainersAgentlessDiscoveryK8S = mdcContainersAgentlessDiscoveryK8S;
            OfferingType = offeringType;
        }

        /// <summary> GCP Defenders CSPM Cloud infrastructure entitlement management (CIEM) discovery offering configurations. </summary>
        public DefenderCspmGcpOfferingCiemDiscovery CiemDiscovery { get; set; }
        /// <summary> The Microsoft Defender for Server VM scanning configuration. </summary>
        public DefenderCspmGcpOfferingVmScanners VmScanners { get; set; }
        /// <summary> The Microsoft Defender Data Sensitivity discovery configuration. </summary>
        public DefenderCspmGcpOfferingDataSensitivityDiscovery DataSensitivityDiscovery { get; set; }
        /// <summary> The Microsoft Defender Container image assessment configuration. </summary>
        public DefenderCspmGcpOfferingMdcContainersImageAssessment MdcContainersImageAssessment { get; set; }
        /// <summary> The Microsoft Defender Container agentless discovery configuration. </summary>
        public DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S MdcContainersAgentlessDiscoveryK8S { get; set; }
    }
}

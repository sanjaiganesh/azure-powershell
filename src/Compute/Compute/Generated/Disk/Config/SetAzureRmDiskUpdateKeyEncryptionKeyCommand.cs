//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DiskUpdateKeyEncryptionKey", SupportsShouldProcess = true)]
    [OutputType(typeof(PSDiskUpdate))]
    public partial class SetAzureRmDiskUpdateKeyEncryptionKeyCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSDiskUpdate DiskUpdate { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string KeyUrl { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string SourceVaultId { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("DiskUpdate", "Set"))
            {
                Run();
            }
        }

        private void Run()
        {
            // EncryptionSettingsCollection
            if (this.DiskUpdate.EncryptionSettingsCollection == null)
            {
                this.DiskUpdate.EncryptionSettingsCollection = new EncryptionSettingsCollection();
            }

            // EncryptionSettings
            if (this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings == null)
            {
                this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings = new List<EncryptionSettingsElement>();
            }

            if (this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings.Count == 0)
            {
                var vEncryptionSettings = new EncryptionSettingsElement();
                this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings.Add(vEncryptionSettings);
            }

            if (this.IsParameterBound(c => c.KeyUrl))
            {
                // KeyEncryptionKey
                if (this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey == null)
                {
                    this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey = new KeyVaultAndKeyReference();
                }
                this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey.KeyUrl = this.KeyUrl;
            }

            if (this.IsParameterBound(c => c.SourceVaultId))
            {
                // KeyEncryptionKey
                if (this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey == null)
                {
                    this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey = new KeyVaultAndKeyReference();
                }
                // SourceVault
                if (this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey.SourceVault == null)
                {
                    this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey.SourceVault = new SourceVault();
                }
                this.DiskUpdate.EncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey.SourceVault.Id = this.SourceVaultId;
            }

            WriteObject(this.DiskUpdate);
        }
    }
}

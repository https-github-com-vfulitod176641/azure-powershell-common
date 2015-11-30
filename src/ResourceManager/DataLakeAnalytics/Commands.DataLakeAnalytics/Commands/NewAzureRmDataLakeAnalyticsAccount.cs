﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using Hyak.Common;
using Microsoft.Azure.Commands.DataLakeAnalytics.Models;
using Microsoft.Azure.Commands.DataLakeAnalytics.Properties;
using Microsoft.Azure.Management.DataLake.Analytics.Models;

namespace Microsoft.Azure.Commands.DataLakeAnalytics
{
    [Cmdlet(VerbsCommon.New, "AzureRmDataLakeAnalyticsAccount"), OutputType(typeof (DataLakeAnalyticsAccount))]
    public class NewAzureDataLakeAnalyticsAccount : DataLakeAnalyticsCmdletBase
    {
        [Parameter(ValueFromPipelineByPropertyName = true, Position = 0, Mandatory = true,
            HelpMessage = "Name of resource group under which you want to create the account.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 1, Mandatory = true,
            HelpMessage = "Name of the account to create.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 2, Mandatory = true,
            HelpMessage = "Azure region where the account should be created.")]
        [ValidateNotNullOrEmpty]
        [ValidateSet("North Central US", "South Central US", "Central US", "West Europe", "North Europe", "West US",
            "East US",
            "East US 2", "Japan East", "Japan West", "Brazil South", "Southeast Asia", "East Asia", "Australia East",
            "Australia Southeast", IgnoreCase = true)]
        public string Location { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 3, Mandatory = true,
            HelpMessage = "The default storage account name to use. This must be a Data Lake storage account.")]
        [ValidateNotNull]
        public string DefaultDataLakeStore { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 4, Mandatory = false,
            HelpMessage = "A string,string dictionary of tags associated with this account")]
        [ValidateNotNull]
        public Hashtable[] Tags { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                if (DataLakeAnalyticsClient.GetAccount(ResourceGroupName, Name) != null)
                {
                    throw new CloudException(string.Format(Resources.DataLakeAnalyticsAccountExists, Name));
                }
            }
            catch (CloudException ex)
            {
                if (ex.Error != null && !string.IsNullOrEmpty(ex.Error.Code) && ex.Error.Code == "ResourceNotFound" ||
                    ex.Message.Contains("ResourceNotFound"))
                {
                    // account does not exists so go ahead and create one
                }
                else if (ex.Error != null && !string.IsNullOrEmpty(ex.Error.Code) &&
                         ex.Error.Code == "ResourceGroupNotFound" || ex.Message.Contains("ResourceGroupNotFound"))
                {
                    // resource group not found, let create throw error don't throw from here
                }
                else
                {
                    // all other exceptions should be thrown
                    throw;
                }
            }

            var defaultStorage = new DataLakeStoreAccount
            {
                Name = DefaultDataLakeStore
            };

            WriteObject(DataLakeAnalyticsClient.CreateOrUpdateAccount(ResourceGroupName, Name, Location, defaultStorage,
                customTags: Tags));
        }
    }
}
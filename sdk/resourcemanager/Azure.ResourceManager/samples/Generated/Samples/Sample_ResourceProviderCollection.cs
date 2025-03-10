// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_ResourceProviderCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetProvider()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-09-01/examples/GetProvider.json
            // this example is just showing the usage of "Providers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ResourceProviderResource
            ResourceProviderCollection collection = subscription.GetResourceProviders();

            // invoke the operation
            string resourceProviderNamespace = "Microsoft.TestRP1";
            ResourceProviderResource result = await collection.GetAsync(resourceProviderNamespace);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceProviderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetProviders()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-09-01/examples/GetProviders.json
            // this example is just showing the usage of "Providers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ResourceProviderResource
            ResourceProviderCollection collection = subscription.GetResourceProviders();

            // invoke the operation and iterate over the result
            await foreach (ResourceProviderResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ResourceProviderData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetProvider()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-09-01/examples/GetProvider.json
            // this example is just showing the usage of "Providers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ResourceProviderResource
            ResourceProviderCollection collection = subscription.GetResourceProviders();

            // invoke the operation
            string resourceProviderNamespace = "Microsoft.TestRP1";
            bool result = await collection.ExistsAsync(resourceProviderNamespace);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetProvider()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-09-01/examples/GetProvider.json
            // this example is just showing the usage of "Providers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscription = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ResourceProviderResource
            ResourceProviderCollection collection = subscription.GetResourceProviders();

            // invoke the operation
            string resourceProviderNamespace = "Microsoft.TestRP1";
            NullableResponse<ResourceProviderResource> response = await collection.GetIfExistsAsync(resourceProviderNamespace);
            ResourceProviderResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ResourceProviderData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

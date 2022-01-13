// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of VCenter and their operations over its parent. </summary>
    public partial class VCenterCollection : ArmCollection, IEnumerable<VCenter>, IAsyncEnumerable<VCenter>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VCentersRestOperations _vCentersRestClient;

        /// <summary> Initializes a new instance of the <see cref="VCenterCollection"/> class for mocking. </summary>
        protected VCenterCollection()
        {
        }

        /// <summary> Initializes a new instance of VCenterCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VCenterCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _vCentersRestClient = new VCentersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Create
        /// <summary> Create Or Update vCenter. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual VCenterCreateOperation CreateOrUpdate(string vcenterName, VCenterData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vCentersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, body, cancellationToken);
                var operation = new VCenterCreateOperation(Parent, _clientDiagnostics, Pipeline, _vCentersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, body).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Create
        /// <summary> Create Or Update vCenter. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public async virtual Task<VCenterCreateOperation> CreateOrUpdateAsync(string vcenterName, VCenterData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vCentersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, body, cancellationToken).ConfigureAwait(false);
                var operation = new VCenterCreateOperation(Parent, _clientDiagnostics, Pipeline, _vCentersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, body).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Get
        /// <summary> Implements vCenter GET method. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual Response<VCenter> Get(string vcenterName, CancellationToken cancellationToken = default)
        {
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.Get");
            scope.Start();
            try
            {
                var response = _vCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VCenter(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Get
        /// <summary> Implements vCenter GET method. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public async virtual Task<Response<VCenter>> GetAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.Get");
            scope.Start();
            try
            {
                var response = await _vCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VCenter(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual Response<VCenter> GetIfExists(string vcenterName, CancellationToken cancellationToken = default)
        {
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VCenter>(null, response.GetRawResponse())
                    : Response.FromValue(new VCenter(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public async virtual Task<Response<VCenter>> GetIfExistsAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _vCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VCenter>(null, response.GetRawResponse())
                    : Response.FromValue(new VCenter(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual Response<bool> Exists(string vcenterName, CancellationToken cancellationToken = default)
        {
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vcenterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            if (vcenterName == null)
            {
                throw new ArgumentNullException(nameof(vcenterName));
            }

            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vcenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_ListByResourceGroup
        /// <summary> List of vCenters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VCenter" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VCenter> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VCenter> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vCentersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VCenter> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vCentersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_ListByResourceGroup
        /// <summary> List of vCenters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VCenter" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VCenter> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VCenter>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vCentersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VCenter>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vCentersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenter(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VCenter" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VCenter.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VCenter" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VCenterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VCenter.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VCenter> IEnumerable<VCenter>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VCenter> IAsyncEnumerable<VCenter>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VCenter, VCenterData> Construct() { }
    }
}

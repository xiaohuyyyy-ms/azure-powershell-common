// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights_2018_04_04
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PolicyEvents.
    /// </summary>
    public static partial class PolicyEventsExtensions
    {
            /// <summary>
            /// Queries policy events for the resources under the management group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// Management group name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static PolicyEventsQueryResults ListQueryResultsForManagementGroup(this IPolicyEvents operations, string managementGroupName, QueryOptions queryOptions = default(QueryOptions))
            {
                return operations.ListQueryResultsForManagementGroupAsync(managementGroupName, queryOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries policy events for the resources under the management group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupName'>
            /// Management group name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyEventsQueryResults> ListQueryResultsForManagementGroupAsync(this IPolicyEvents operations, string managementGroupName, QueryOptions queryOptions = default(QueryOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListQueryResultsForManagementGroupWithHttpMessagesAsync(managementGroupName, queryOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queries policy events for the resources under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static PolicyEventsQueryResults ListQueryResultsForSubscription(this IPolicyEvents operations, string subscriptionId, QueryOptions queryOptions = default(QueryOptions))
            {
                return operations.ListQueryResultsForSubscriptionAsync(subscriptionId, queryOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries policy events for the resources under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyEventsQueryResults> ListQueryResultsForSubscriptionAsync(this IPolicyEvents operations, string subscriptionId, QueryOptions queryOptions = default(QueryOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListQueryResultsForSubscriptionWithHttpMessagesAsync(subscriptionId, queryOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queries policy events for the resources under the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static PolicyEventsQueryResults ListQueryResultsForResourceGroup(this IPolicyEvents operations, string subscriptionId, string resourceGroupName, QueryOptions queryOptions = default(QueryOptions))
            {
                return operations.ListQueryResultsForResourceGroupAsync(subscriptionId, resourceGroupName, queryOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries policy events for the resources under the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyEventsQueryResults> ListQueryResultsForResourceGroupAsync(this IPolicyEvents operations, string subscriptionId, string resourceGroupName, QueryOptions queryOptions = default(QueryOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListQueryResultsForResourceGroupWithHttpMessagesAsync(subscriptionId, resourceGroupName, queryOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queries policy events for the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Resource ID.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static PolicyEventsQueryResults ListQueryResultsForResource(this IPolicyEvents operations, string resourceId, QueryOptions queryOptions = default(QueryOptions))
            {
                return operations.ListQueryResultsForResourceAsync(resourceId, queryOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries policy events for the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// Resource ID.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyEventsQueryResults> ListQueryResultsForResourceAsync(this IPolicyEvents operations, string resourceId, QueryOptions queryOptions = default(QueryOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListQueryResultsForResourceWithHttpMessagesAsync(resourceId, queryOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queries policy events for the subscription level policy set definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='policySetDefinitionName'>
            /// Policy set definition name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static PolicyEventsQueryResults ListQueryResultsForPolicySetDefinition(this IPolicyEvents operations, string subscriptionId, string policySetDefinitionName, QueryOptions queryOptions = default(QueryOptions))
            {
                return operations.ListQueryResultsForPolicySetDefinitionAsync(subscriptionId, policySetDefinitionName, queryOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries policy events for the subscription level policy set definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='policySetDefinitionName'>
            /// Policy set definition name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyEventsQueryResults> ListQueryResultsForPolicySetDefinitionAsync(this IPolicyEvents operations, string subscriptionId, string policySetDefinitionName, QueryOptions queryOptions = default(QueryOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListQueryResultsForPolicySetDefinitionWithHttpMessagesAsync(subscriptionId, policySetDefinitionName, queryOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queries policy events for the subscription level policy definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// Policy definition name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static PolicyEventsQueryResults ListQueryResultsForPolicyDefinition(this IPolicyEvents operations, string subscriptionId, string policyDefinitionName, QueryOptions queryOptions = default(QueryOptions))
            {
                return operations.ListQueryResultsForPolicyDefinitionAsync(subscriptionId, policyDefinitionName, queryOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries policy events for the subscription level policy definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// Policy definition name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyEventsQueryResults> ListQueryResultsForPolicyDefinitionAsync(this IPolicyEvents operations, string subscriptionId, string policyDefinitionName, QueryOptions queryOptions = default(QueryOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListQueryResultsForPolicyDefinitionWithHttpMessagesAsync(subscriptionId, policyDefinitionName, queryOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queries policy events for the subscription level policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static PolicyEventsQueryResults ListQueryResultsForSubscriptionLevelPolicyAssignment(this IPolicyEvents operations, string subscriptionId, string policyAssignmentName, QueryOptions queryOptions = default(QueryOptions))
            {
                return operations.ListQueryResultsForSubscriptionLevelPolicyAssignmentAsync(subscriptionId, policyAssignmentName, queryOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries policy events for the subscription level policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyEventsQueryResults> ListQueryResultsForSubscriptionLevelPolicyAssignmentAsync(this IPolicyEvents operations, string subscriptionId, string policyAssignmentName, QueryOptions queryOptions = default(QueryOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListQueryResultsForSubscriptionLevelPolicyAssignmentWithHttpMessagesAsync(subscriptionId, policyAssignmentName, queryOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queries policy events for the resource group level policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static PolicyEventsQueryResults ListQueryResultsForResourceGroupLevelPolicyAssignment(this IPolicyEvents operations, string subscriptionId, string resourceGroupName, string policyAssignmentName, QueryOptions queryOptions = default(QueryOptions))
            {
                return operations.ListQueryResultsForResourceGroupLevelPolicyAssignmentAsync(subscriptionId, resourceGroupName, policyAssignmentName, queryOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Queries policy events for the resource group level policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Microsoft Azure subscription ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='queryOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyEventsQueryResults> ListQueryResultsForResourceGroupLevelPolicyAssignmentAsync(this IPolicyEvents operations, string subscriptionId, string resourceGroupName, string policyAssignmentName, QueryOptions queryOptions = default(QueryOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListQueryResultsForResourceGroupLevelPolicyAssignmentWithHttpMessagesAsync(subscriptionId, resourceGroupName, policyAssignmentName, queryOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets OData metadata XML document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// A valid scope, i.e. management group, subscription, resource group, or
            /// resource ID. Scope used has no effect on metadata returned.
            /// </param>
            public static string GetMetadata(this IPolicyEvents operations, string scope)
            {
                return operations.GetMetadataAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets OData metadata XML document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// A valid scope, i.e. management group, subscription, resource group, or
            /// resource ID. Scope used has no effect on metadata returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetMetadataAsync(this IPolicyEvents operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMetadataWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

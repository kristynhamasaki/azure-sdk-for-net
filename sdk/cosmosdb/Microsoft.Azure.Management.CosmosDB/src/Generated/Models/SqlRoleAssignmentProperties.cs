// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role Assignment Properties.
    /// </summary>
    public partial class SqlRoleAssignmentProperties : IResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlRoleAssignmentProperties
        /// class.
        /// </summary>
        public SqlRoleAssignmentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlRoleAssignmentProperties
        /// class.
        /// </summary>
        /// <param name="roleDefinitionId">The unique identifier for the
        /// associated Role Definition.</param>
        /// <param name="scope">The data plane resource path for which access
        /// is being granted through this Role Assignment.</param>
        /// <param name="principalId">The unique identifier for the associated
        /// AAD principal in the AAD graph to which access is being granted
        /// through this Role Assignment. Tenant ID for the principal is
        /// inferred using the tenant associated with the subscription.</param>
        public SqlRoleAssignmentProperties(string roleDefinitionId = default(string), string scope = default(string), string principalId = default(string))
        {
            RoleDefinitionId = roleDefinitionId;
            Scope = scope;
            PrincipalId = principalId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique identifier for the associated Role
        /// Definition.
        /// </summary>
        [JsonProperty(PropertyName = "roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the data plane resource path for which access is being
        /// granted through this Role Assignment.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the associated AAD principal
        /// in the AAD graph to which access is being granted through this Role
        /// Assignment. Tenant ID for the principal is inferred using the
        /// tenant associated with the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

    }
}

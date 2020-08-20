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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties to update or create an Azure Cosmos DB Role Definition.
    /// </summary>
    public partial class SqlRoleDefinitionProperties : IResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlRoleDefinitionProperties
        /// class.
        /// </summary>
        public SqlRoleDefinitionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlRoleDefinitionProperties
        /// class.
        /// </summary>
        /// <param name="roleName">A user-friendly name for the Role
        /// Definition. Must be unique for the database account.</param>
        /// <param name="type">Indicates whether the Role Definition was
        /// built-in or user created. Possible values include: 'BuiltInRole',
        /// 'CustomRole'</param>
        /// <param name="assignableScopes">A set of fully qualified Scopes at
        /// or below which Role Assignments may be created using this Role
        /// Definition. This will allow application of this Role Definition on
        /// the entire database account or any underlying Database /
        /// Collection. Must have at least one element. Scopes higher than
        /// Database account are not enforceable as assignable Scopes. Note
        /// that resources referenced in assignable Scopes need not
        /// exist.</param>
        /// <param name="permissions">The set of operations allowed through
        /// this Role Definition.</param>
        public SqlRoleDefinitionProperties(string roleName = default(string), RoleDefinitionType? type = default(RoleDefinitionType?), IList<string> assignableScopes = default(IList<string>), IList<Permission> permissions = default(IList<Permission>))
        {
            RoleName = roleName;
            Type = type;
            AssignableScopes = assignableScopes;
            Permissions = permissions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a user-friendly name for the Role Definition. Must be
        /// unique for the database account.
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the Role Definition was built-in or
        /// user created. Possible values include: 'BuiltInRole', 'CustomRole'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public RoleDefinitionType? Type { get; set; }

        /// <summary>
        /// Gets or sets a set of fully qualified Scopes at or below which Role
        /// Assignments may be created using this Role Definition. This will
        /// allow application of this Role Definition on the entire database
        /// account or any underlying Database / Collection. Must have at least
        /// one element. Scopes higher than Database account are not
        /// enforceable as assignable Scopes. Note that resources referenced in
        /// assignable Scopes need not exist.
        /// </summary>
        [JsonProperty(PropertyName = "assignableScopes")]
        public IList<string> AssignableScopes { get; set; }

        /// <summary>
        /// Gets or sets the set of operations allowed through this Role
        /// Definition.
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public IList<Permission> Permissions { get; set; }

    }
}

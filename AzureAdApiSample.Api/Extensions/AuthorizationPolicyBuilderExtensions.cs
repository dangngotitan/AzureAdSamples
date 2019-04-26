﻿using AzureAdApiSample.Api.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace AzureAdApiSample.Api.Extensions
{
    public static class AuthorizationPolicyBuilderExtensions
    {
        public static void RequirePermissions(
            this AuthorizationPolicyBuilder builder,
            string[] delegated,
            string[] application = null,
            string[] userRoles = null)
        {
            builder.RequireAuthenticatedUser();
            builder.Requirements.Add(new PermissionRequirement
            {
                DelegatedPermissions = delegated,
                ApplicationPermissions = application ?? new string[0],
                UserRoles = userRoles ?? new string[0]
            });
        }
    }
}

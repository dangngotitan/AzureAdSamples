﻿using Microsoft.AspNetCore.Authorization;

namespace AzureAdApiSample.Api.Authorization
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public string[] DelegatedPermissions { get; set; }
        public string[] ApplicationPermissions { get; set; }
        public string[] UserRoles { get;  set; }
    }
}
﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591


namespace IdentityServer4.EntityFramework.Entities
{
    public class PersistedGrant
    {
        public required string Key { get; set; }
        public required string Type { get; set; }
        public string? SubjectId { get; set; }
        public string? SessionId { get; set; }
        public required string ClientId { get; set; }
        public string? Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? Expiration { get; set; }
        public DateTime? ConsumedTime { get; set; }
        public required string Data { get; set; }
    }
}
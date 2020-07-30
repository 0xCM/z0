//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
            
    public sealed class CacheOptions
    {
        public bool CacheTypes { get; set; } = true;
    
        public bool CacheFields { get; set; } = true;
    
        public bool CacheMethods { get; set; } = true;
    
        public StringCaching CacheTypeNames { get; set; } 
            = StringCaching.Cache;

        public StringCaching CacheFieldNames { get; set; } 
            = StringCaching.Cache;

        public StringCaching CacheMethodNames { get; set; } 
            = StringCaching.Cache;
    }
}
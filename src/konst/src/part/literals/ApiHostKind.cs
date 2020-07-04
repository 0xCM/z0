//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    [Flags]
    public enum ApiHostKind
    {
        None = 0,

        Direct = 1,

        Generic = 2,

        DirectAndGeneric = Direct | Generic
    }    
}
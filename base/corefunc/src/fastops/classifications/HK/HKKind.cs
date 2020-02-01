//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// Defines classification of higher-kinded things
    /// </summary>
    [Flags]
    public enum HKKind : ulong
    {
        None =0,
        
        Type = Pow2.T00,

        Func = Pow2.T01,

    }

}
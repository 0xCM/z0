//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Identifies operations that accept one or more blocks and computes a result that is stored in a caller-supplied target block
    /// </summary>
    public class BlockedOpAttribute : OpAttribute
    {
        public BlockedOpAttribute()
            : base()
        {

        }
    }
}
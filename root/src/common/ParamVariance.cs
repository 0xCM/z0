//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static RootShare;

    public enum ParamVariance
    {
        None = 0, 

        In = 1,

        Out = 2,

        Ref = 3
    }

    partial class RootKindExtensions
    {

        [MethodImpl(Inline)]
        public static bool IsSome(this ParamVariance src)        
            => src != ParamVariance.None;
    }

}
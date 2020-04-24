//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class VSvcHosts
    {
        public readonly struct Ones128<T> : ISVPatternSource128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke() => gvec.vones<T>(w128);            
        }

        public readonly struct Ones256<T> : ISVPatternSource256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke() => gvec.vones<T>(w256);
        }
    }
}
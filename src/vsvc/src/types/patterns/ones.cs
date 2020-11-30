//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;
    using static SFx;

    partial class VServices
    {
        public readonly struct Ones128<T> : SFx.IEmitter128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke()
                => gvec.vones<T>(w128);
        }

        public readonly struct Ones256<T> : SFx.IEmitter256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke()
                => gvec.vones<T>(w256);
        }
    }
}
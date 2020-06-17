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

    partial class VSvcHosts
    {
        public readonly struct Units128<T> : IEmitter128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke() => Data.vunits(Kinds.vk128<T>());            
        }

        public readonly struct Units256<T> : IEmitter256<T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public Vector256<T> Invoke() => Data.vunits<T>(Kinds.vk256<T>());
        }
    }
}
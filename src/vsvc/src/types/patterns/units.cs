//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    using K = VK;

    partial class VServices
    {
        public readonly struct Units128<T> : SFx.IEmitter128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke()
                => gcpu.vunits(K.vk128<T>());
        }

        public readonly struct Units256<T> : SFx.IEmitter256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke()
                => gcpu.vunits<T>(K.vk256<T>());
        }
    }
}
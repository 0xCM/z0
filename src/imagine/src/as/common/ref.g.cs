//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct As
    {

        [MethodImpl(Inline)]
        public static unsafe ref T @ref<S,T>(S* pSrc)            
            where S : unmanaged
                => ref @as<S,T>(ref @ref<S>(pSrc));
    }
}
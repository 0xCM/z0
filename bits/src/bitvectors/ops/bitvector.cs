//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;

    public static partial class bitvector
    {
        [MethodImpl(Inline)]
        public static BitVector<T> generic<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static BitVector<T> generic<T>(T init)
            where T : unmanaged
                => BitVector<T>.From(init);

    }

}
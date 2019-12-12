//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static partial class BitMatrix
    {        

        [MethodImpl(Inline)]
        public static BitGridLayout layout<N,T>(N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGridSpec(bitsize<T>(), (int)n.NatValue,(int)n.NatValue).CalcLayout<T>();

    }

}
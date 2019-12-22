//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                

        [MethodImpl(Inline)]
        public static bit testz(ulong a, ulong b)
            => dinx.vtestz(CpuVector.broadcast(n128,a), CpuVector.broadcast(n128,b));

        [MethodImpl(Inline)]
        public static bit testc(ulong a, ulong b)
            => dinx.vtestc(CpuVector.broadcast(n128,a), CpuVector.broadcast(n128,b));

        [MethodImpl(Inline)]
        public static bit testc(ulong a)
            => dinx.vtestc(CpuVector.broadcast(n128,a));

    }

}
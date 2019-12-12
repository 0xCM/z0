//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;

    using static zfunc;    

    partial class inxoc
    {
        public static Vector128<uint> vcompact(Vector128<ulong> x0, Vector128<ulong> x1, out Vector128<uint> dst)
            => dinx.vcompact(x0,x1, out dst);

        public static UInt128 clmul(ulong x, ulong y)
            => Cl.clmul(x,y);

        public static ref UInt128 clmul(ulong x, ulong y, ref UInt128 dst)
            => ref Cl.clmul(x,y, ref dst);

        public static ulong clmulr8u(ulong a, ulong b, ulong poly)
            => Cl.clmulr8u(a,b,poly);


        
    }
}
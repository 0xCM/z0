//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIulong
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;    

    public static partial class loc
    {
        public static Vector256<ulong> one_v256x64u(Vector256<ulong> a)
            => CpuLogic256.one<ulong>();

        public static Vector256<ulong> zero_v256x64u(Vector256<ulong> a)
            => Vec256Pattern.zeroes<ulong>();



        // a ? (b nor c) : (b xor c)
        public static Vector256<ulong> f16_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => CpuLogic256.f16(a,b,c);
 
        public static Vector256<ulong> f17_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => CpuLogic256.f17(a,b,c);

        public static Vector256<ulong> f18_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => CpuLogic256.f18(a,b,c);

        public static Vector256<ulong> f19_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => CpuLogic256.f19(a,b,c);

        public static Vector256<ulong> f1a_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => CpuLogic256.f1a(a,b,c);

        public static Vector256<ulong> f1b_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => CpuLogic256.f1b(a,b,c);

        public static Vector256<ulong> f97_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
            => CpuLogic256.f97(a,b,c);

    }

}
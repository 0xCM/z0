//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIulong
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    public static partial class loc
    {
        public static Vec128<ulong> one_v128x64u()
            => CpuLogic128.one<ulong>();

        public static Vec128<ulong> zero_v128x64u(Vec128<ulong> a)
            => Vec128Pattern.zeroes<ulong>();




 
        public static Vector128<ulong> f17_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => CpuLogic128.f17(a,b,c);

        public static Vector128<ulong> f18_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => CpuLogic128.f18(a,b,c);

        public static Vector128<ulong> f19_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => CpuLogic128.f19(a,b,c);

        public static Vector128<ulong> f1a_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => CpuLogic128.f1a(a,b,c);

        public static Vector128<ulong> f1b_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => CpuLogic128.f1b(a,b,c);

        public static Vector128<ulong> f97_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
            => CpuLogic128.f97(a,b,c);

    }

}
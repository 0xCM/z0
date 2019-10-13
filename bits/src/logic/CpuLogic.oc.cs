//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIulong
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    public static partial class loc
    {
        public static Vec128<ulong> xor1_v128x64u(Vec128<ulong> a)
            => CpuLogic.xor1(a);

        // a ? b : c
        public static Vec128<ulong> select_v128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic.select(a,b,c);

        // a nor (b or c)
        public static Vec128<ulong> f01_64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic.f01(a,b,c);

        // c and (b nor a)
        public static Vec128<ulong> f02_64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic.f02(a,b,c);
 
         // b nor a
        public static Vec128<ulong> f03_64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic.f03(a,b,c);

    }

}
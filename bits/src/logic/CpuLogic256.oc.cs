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
        public static Vec256<ulong> one_v256x64u(Vec256<ulong> a)
            => CpuLogic256.one<ulong>();

        public static Vec256<ulong> zero_v256x64u(Vec256<ulong> a)
            => Vec256Pattern.zeroes<ulong>();

        public static Vec256<ulong> not_v256x64u(Vec256<ulong> a)
            => CpuLogic256.not(a);

        public static Vec256<ulong> xor1_v256x64u(Vec256<ulong> a)
            => CpuLogic256.xor1(a);

        public static Vec256<ulong> and_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
            => CpuLogic256.and(a,b);

        public static Vec256<ulong> nand_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
            => CpuLogic256.nand(a,b);

        public static Vec256<ulong> or_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
            => CpuLogic256.or(a,b);

        public static Vec256<ulong> nor_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
            => CpuLogic256.nor(a,b);

        public static Vec256<ulong> xor_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
            => CpuLogic256.xor(a,b);

        public static Vec256<ulong> xnor_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
            => CpuLogic256.xnor(a,b);

        // a ? b : c
        public static Vec256<ulong> select_v256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.select(a,b,c);

        // a nor (b or c)
        public static Vec256<ulong> f01_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f01(a,b,c);

        // c and (b nor a)
        public static Vec256<ulong> f02_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f02(a,b,c);
 
         // b nor a
        public static Vec256<ulong> f03_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f03(a,b,c);

        // b and (a nor c)
        public static Vec256<ulong> f04_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f04(a,b,c);

        // c nor a
        public static Vec256<ulong> f05_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f05(a,b,c);

        // not a and (b xor c)
        public static Vec256<ulong> f06_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f06(a,b,c);

        // not a and (b xor c)
        public static Vec256<ulong> f07_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f07(a,b,c);

        // (not a and b) and c
        public static Vec256<ulong> f08_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f08(a,b,c);

        // a nor (b xor c)
        public static Vec256<ulong> f09_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f09(a,b,c);

        // c and (not a)
        public static Vec256<ulong> f0a_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f0a(a,b,c);

        // not a and ((b xor 1) or c)
        public static Vec256<ulong> f0b_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f0b(a,b,c);

        // b and (not a)
        public static Vec256<ulong> f0c_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f0c(a,b,c);

        // not (A) and (B or (C xor 1))
        public static Vec256<ulong> f0d_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f0d(a,b,c);

        // not a and (b or c)
        public static Vec256<ulong> f0e_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f0e(a,b,c);

        // not a
        public static Vec256<ulong> f0f_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f0f(a,b,c);

        // a and (b nor c)
        public static Vec256<ulong> f10_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f10(a,b,c);
        
        // a and (b nor c)
        public static Vec256<ulong> f11_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f11(a,b,c);
        
        // not b and (a xor c) 
        public static Vec256<ulong> f12_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f12(a,b,c);

        public static Vec256<ulong> f13_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f13(a,b,c);

        public static Vec256<ulong> f14_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f14(a,b,c);

        public static Vec256<ulong> f15_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f15(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static Vec256<ulong> f16_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f16(a,b,c);
 
        public static Vec256<ulong> f17_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f17(a,b,c);

        public static Vec256<ulong> f18_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f18(a,b,c);

        public static Vec256<ulong> f19_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f19(a,b,c);

        public static Vec256<ulong> f1a_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f1a(a,b,c);

        public static Vec256<ulong> f1b_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f1b(a,b,c);

        public static Vec256<ulong> f97_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
            => CpuLogic256.f97(a,b,c);

    }

}
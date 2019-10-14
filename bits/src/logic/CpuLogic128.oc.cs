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
        public static Vec128<ulong> one_v128x64u(Vec128<ulong> a)
            => CpuLogic128.one<ulong>();

        public static Vec128<ulong> zero_v128x64u(Vec128<ulong> a)
            => Vec128Pattern.zeroes<ulong>();

        public static Vec128<ulong> not_v128x64u(Vec128<ulong> a)
            => CpuLogic128.not(a);

        public static Vec128<ulong> xor1_v128x64u(Vec128<ulong> a)
            => CpuLogic128.xor1(a);

        public static Vec128<ulong> and_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
            => CpuLogic128.and(a,b);

        public static Vec128<ulong> nand_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
            => CpuLogic128.nand(a,b);

        public static Vec128<ulong> or_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
            => CpuLogic128.or(a,b);

        public static Vec128<ulong> nor_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
            => CpuLogic128.nor(a,b);

        public static Vec128<ulong> xor_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
            => CpuLogic128.xor(a,b);

        public static Vec128<ulong> xnor_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
            => CpuLogic128.xnor(a,b);


        // a ? b : c
        public static Vec128<ulong> select_v128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.select(a,b,c);

        // a nor (b or c)
        public static Vec128<ulong> f01_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f01(a,b,c);

        // c and (b nor a)
        public static Vec128<ulong> f02_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f02(a,b,c);
 
         // b nor a
        public static Vec128<ulong> f03_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f03(a,b,c);

        // b and (a nor c)
        public static Vec128<ulong> f04_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f04(a,b,c);

        // c nor a
        public static Vec128<ulong> f05_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f05(a,b,c);

        // not a and (b xor c)
        public static Vec128<ulong> f06_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f06(a,b,c);

        // not a and (b xor c)
        public static Vec128<ulong> f07_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f07(a,b,c);

        // (not a and b) and c
        public static Vec128<ulong> f08_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f08(a,b,c);

        // a nor (b xor c)
        public static Vec128<ulong> f09_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f09(a,b,c);

        // c and (not a)
        public static Vec128<ulong> f0a_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f0a(a,b,c);

        // not a and ((b xor 1) or c)
        public static Vec128<ulong> f0b_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f0b(a,b,c);

        // b and (not a)
        public static Vec128<ulong> f0c_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f0c(a,b,c);

        // not (A) and (B or (C xor 1))
        public static Vec128<ulong> f0d_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f0d(a,b,c);

        // not a and (b or c)
        public static Vec128<ulong> f0e_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f0e(a,b,c);

        // not a
        public static Vec128<ulong> f0f_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f0f(a,b,c);

        // a and (b nor c)
        public static Vec128<ulong> f10_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f10(a,b,c);
        
        // a and (b nor c)
        public static Vec128<ulong> f11_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f11(a,b,c);
        
        // not b and (a xor c) 
        public static Vec128<ulong> f12_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f12(a,b,c);

        public static Vec128<ulong> f13_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f13(a,b,c);

        public static Vec128<ulong> f14_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f14(a,b,c);

        public static Vec128<ulong> f15_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f15(a,b,c);

        // a ? (b nor c) : (b xor c)
        public static Vec128<ulong> f16_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f16(a,b,c);
 
        public static Vec128<ulong> f17_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f17(a,b,c);

        public static Vec128<ulong> f18_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f18(a,b,c);

        public static Vec128<ulong> f19_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f19(a,b,c);

        public static Vec128<ulong> f1a_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f1a(a,b,c);

        public static Vec128<ulong> f1b_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f1b(a,b,c);

        public static Vec128<ulong> f97_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
            => CpuLogic128.f97(a,b,c);

    }

}
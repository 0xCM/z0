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

    partial class inxvoc
    {
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vadd_d128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => dinx.vadd(lhs,rhs);


        [MethodImpl(Inline)]
        public static Vector128<sbyte> vadd_g128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs) 
            => ginx.vadd(lhs, rhs);
            
        [MethodImpl(Inline)]
        public static Vector128<byte> vadd_g128x8u(Vector128<byte> lhs, Vector128<byte> rhs)
            => ginx.vadd(lhs, rhs);

        public static Vector128<short> vadd_g128x16i(Vector128<short> lhs, Vector128<short> rhs)
            => ginx.vadd(lhs, rhs);

        public static Vector128<ushort> vadd_g128x16u(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => ginx.vadd(lhs, rhs);

        public static Vector128<int> vadd_g128x32i(Vector128<int> lhs,Vector128<int> rhs)
            => ginx.vadd(lhs, rhs);
        public static Vector128<uint> vadd_g128x32u(Vector128<uint> lhs, Vector128<uint> rhs)
            => ginx.vadd(lhs, rhs);

        public static Vector128<long> vadd_g128x64i(Vector128<long> lhs, Vector128<long> rhs)
            => ginx.vadd(lhs, rhs);

        public static Vector128<ulong> vadd_g128x64u(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => ginx.vadd(lhs, rhs);

        public static Vector128<float> vadd_g128x32f(Vector128<float> lhs, Vector128<float> rhs)
            => ginx.vadd(lhs, rhs);

        public static Vector128<double> vadd_g128x64f(Vector128<double> lhs, Vector128<double> rhs)
            => ginx.vadd(lhs, rhs);

        
    }
}
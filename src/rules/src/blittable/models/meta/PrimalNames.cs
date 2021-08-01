//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using static core;

    [ApiComplete]
    public readonly struct PrimalNames
    {
        const string U2 = "u0u1u2u3u4u5u6u7u8";

        const string U3 = "u16u32u64";

        const string U4 = "u128u256u512";

        public static name64 u0 => segment(U2,0*2,2);

        public static name64 u1 => segment(U2,1*2,2);

        public static name64 u2 => segment(U2,2*2,2);

        public static name64 u3 => segment(U2,3*2,2);

        public static name64 u4 => segment(U2,4*2,2);

        public static name64 u5 => segment(U2,5*2,2);

        public static name64 u6 => segment(U2,6*2,2);

        public static name64 u7 => segment(U2,7*2,2);

        public static name64 u8 => segment(U2,8*2,2);

        public static name64 u16 => segment(U3,0*3,3);

        public static name64 u32 => segment(U3,1*3,3);

        public static name64 u64 => segment(U3,2*3,3);

        public static name64 u128 => segment(U4,0*4,4);

        public static name128 u256 => segment(U4,1*4,4);

        public static name128 u512 => segment(U4,2*4,4);
    }
}
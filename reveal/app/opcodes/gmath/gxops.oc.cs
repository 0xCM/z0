//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    


    [OpCodeProvider]
    public static class gxops
    {
     
        public static Span<uint> and_32u_span(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
            => GX.and<uint>().Invoke(lhs,rhs,dst);

        public static Span<uint> nand_32u_span(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
            => GX.nand<uint>().Invoke(lhs,rhs,dst);


        public static Span<ulong> select_64u_span(ReadOnlySpan<ulong> a, ReadOnlySpan<ulong> b, ReadOnlySpan<ulong> c, Span<ulong> dst)
            => GX.select<ulong>().Invoke(a,b,c,dst);

        public static uint bl_and32(uint a, uint b)
            => GX.bitlogic<uint>().and(a,b);

        public static uint logic_machine(uint a, uint b)
        {
            var m = LogicMachine.Create(GX.bitlogic<uint>(),z32);
            return m.xor(m.and(a,b),b);
        }

        public static Vector128<uint> vlogic_machine(Vector128<uint> a, Vector128<uint> b)
        {
            var m = LogicMachine.Create(VX.vbitlogic(n128,z32),a);
            return m.xor(m.and(a,b),b);
        }

        public static bit eq_d16u(ushort a, ushort b)
            => math.eq(a,b);

        public static bit eq_g16u(ushort a, ushort b)
            => gmath.eq(a,b);

        public static bit eq_o16u(ushort a, ushort b)
            => GX.eq<ushort>().Invoke(a,b);

        public static string eq_moniker()
            => GX.eq<ushort>().Moniker;
                     
        const string name = "thename";

        public static string the_name()
            => name;

    }

}
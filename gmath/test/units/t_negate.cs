//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    using D = GDel;

    public class t_negate : UnitTest<t_add>
    {
        public void negate_basecase()
        {
            var x1 = 128ul;
            var y1 = 18446744073709551488;
            var z1 = gmath.negate(x1);
            Claim.eq(y1,z1);            

            var x2 = 128u;
            var y2 = 4294967168u;
            var z2 = gmath.negate(x2);
            Claim.eq(y2,z2);            

            var x3 = (ushort)128;
            var y3 = (ushort)65408;
            var z3 = gmath.negate(x3);
            Claim.eq(y3,z3);            

            var x4 = (byte)128;
            var y4 = (byte)128;
            var z4 = gmath.negate(x4);
            Claim.eq(y4,z4);            

        }

        public void negate_8i()
            => opcheck(x => (sbyte)-x, D.negate<sbyte>());

        public void negate_8u()
            => opcheck(math.negate, D.negate<byte>());

        public void negate_16i()
            => opcheck(x => (short)-x, D.negate<short>());

        public void negate_16u()
            => VerifyOp(math.negate, D.negate<ushort>());

        public void negate_32i()
            => opcheck(x => -x, D.negate<int>());

        public void negate_32u()
            => opcheck(math.negate, D.negate<uint>());

        public void negate_64i()
            => opcheck(x => -x, D.negate<long>());

        public void negate_64u()
            => opcheck(math.negate, D.negate<ulong>());

        public void negate_32f()
            => opcheck(x => -x, D.negate<float>());
     
        public void negate_64f()
            => opcheck(x => -x, D.negate<double>());              
    }
}
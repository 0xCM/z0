//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class t_sra : t_bitcore<t_sra>
    {
        public void bs_sra_8i_check()
            => bs_sra_check<sbyte>();

        public void bs_sra_8u_check()
            => bs_sra_check<byte>();

        public void bs_sra_16i_check()
            => bs_sra_check<short>();

        public void bs_sra_16u_check()
            => bs_sra_check<ushort>();

        public void bs_sra_32i_check()
            => bs_sra_check<int>();

        public void bs_sra_32u_check()
            => bs_sra_check<uint>();

        public void bs_sra_64i_check()
            => bs_sra_check<long>();

        public void bs_sra_64u_check()
            => bs_sra_check<ulong>();

        public void sb_sal_8i()
        {
            var src = Random.Array<sbyte>(RepCount);
            var offset = Random.Array(RepCount, Interval.closed((byte)0, (byte)bitwidth<sbyte>()));
            iteri(RepCount, i => Claim.eq((sbyte)(src[i] << offset[i]), gmath.sal(src[i], offset[i])));
        }

        public void sb_sal_8u()
        {
            var src = Random.Array<byte>(RepCount);
            var offset = Random.Array(RepCount, Interval.closed((byte)0, (byte)bitwidth<byte>()));
            iteri(RepCount,
                i => CheckPrimal.eq((byte)(src[i] << offset[i]), gmath.sal(src[i], offset[i])));
        }

        public void sb_sra_8i()
        {
            var src = Random.Array<sbyte>(RepCount);
            var offset = Random.Array(RepCount, Interval.closed((byte)0, (byte)bitwidth<sbyte>()));
            iteri(RepCount, i => Claim.eq((sbyte)(src[i] >> offset[i]), gmath.sra(src[i], offset[i])));
        }

        public void sb_sal_32i()
        {
            var src = Random.Array<int>(RepCount);
            var offset = Random.Array(RepCount, Interval.closed((byte)0, (byte)bitwidth<int>()));
            iteri(RepCount, i => Claim.eq(src[i] << offset[i], gmath.sal(src[i], offset[i])));
        }

        public void sb_sra_32i()
        {
            var src = Random.Array<int>(RepCount);
            var offset = Random.Array(RepCount, Interval.closed((byte)0, (byte)bitwidth<int>()));
            iteri(RepCount, i => Claim.eq(src[i] >> offset[i], gmath.sra(src[i], offset[i])));
        }

        public void sb_sal_64i()
        {
            var src = Random.Array<long>(RepCount);
            var offset = Random.Array(RepCount, Interval.closed((byte)0, (byte)bitwidth<ulong>()));
            iteri(RepCount, i => Claim.eq(src[i] << offset[i], gmath.sal(src[i], offset[i])));
        }

        public void sb_sra_64i()
        {
            var src = Random.Array<long>(RepCount);
            var offset = Random.Array(RepCount, Interval.closed((byte)0, (byte)bitwidth<long>()));
            iteri(RepCount, i => Claim.eq(src[i] >> offset[i], gmath.sra(src[i], offset[i])));
        }

        protected void bs_sra_check<T>()
            where T : unmanaged
        {

            var signed = NumericKinds.signed<T>();
            BitSize bitsize = bitwidth<T>();
            var bs10 = BitString.parse("1" + Arrays.replicate('0', bitsize - 1).Concat());
            var x10 = bs10.TakeScalar<T>();
            var bs11 = BitString.parse("11" + Arrays.replicate('0', bitsize - 2).Concat());
            var x11 = bs11.TakeScalar<T>();
            var bs01 = BitString.parse("01" + Arrays.replicate('0', bitsize - 2).Concat());
            var x01 = bs01.TakeScalar<T>();
            var y = gmath.sra(x10, 1);
            if(signed)
                Claim.eq(x11, y);
            else
                Claim.eq(x01, y);
        }
    }
}

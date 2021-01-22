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

    public class t_gather : t_bitcore<t_gather>
    {
        public void gather_masks()
        {
            var m2 = BitMasks.Literals.Lsb32x8x1;
            var x2 = BitMasks.gather(UInt32.MaxValue, m2);
            var y2 = BitMasks.scatter(x2, m2).ToBitVector32();
            var bv = m2.ToBitVector32();

            Claim.eq(y2.Scalar, bv.Scalar);
            for(var i=0; i<y2.Width; i++)
                Claim.eq(y2[i], i % 8 == 0 ? bit.On : bit.Off);
        }

        public void gather_8()
            => gather_check<byte>();

        public void gather_16()
            => gather_check<ushort>();

        public void gather_32()
            => gather_check<uint>();

        public void gather_64()
            => gather_check<ulong>();

        void gather_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                Claim.eq(RefOps.gather(src, mask), gbits.gather(src, mask));
            }
        }
    }
}
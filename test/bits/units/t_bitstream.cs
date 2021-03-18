//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class t_bitstream : t_bits<t_bitstream>
    {
        public void check_singletons()
        {
            check_singletons<byte>();
            check_singletons<ushort>();
            check_singletons<uint>();
            check_singletons<ulong>();
        }

        void check_singletons<T>()
            where T : unmanaged
        {
            var formatter = BitFormatter.create<T>();
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.Next<T>();
                var bits = bit.unpack(a);
                var s1 = bits.FormatList();
                var s2 = formatter.Format(a);
                Claim.ClaimEq(s1,s1);
            }
        }
    }
}
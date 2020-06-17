//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    using static Konst;
    using static Memories;

    public sealed class t_bitstream : UnitTest<t_bitstream>
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
            var formatter =  Formatters.bits<T>();
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.Next<T>();
                var bits = BitStream.from(a);
                var s1 = bits.Format();
                var s2 = formatter.Format(a);
                Claim.eq(s1,s1);
            }
        }
    }
}
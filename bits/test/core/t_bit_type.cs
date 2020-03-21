//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_bit_type : t_bitcore<t_bit_type>
    {
        static bit On = bit.On;
        
        static bit Off = bit.Off;

        public void sb_bit_convert()
        {            
            Claim.eq((byte)0, (byte)Off);
            Claim.eq((byte)1, (byte)On);

            Claim.eq((ushort)0, (ushort)Off);
            Claim.eq((ushort)1, (ushort)On);

            Claim.eq(0u, (uint)Off);
            Claim.eq(1u, (uint)On);

            Claim.eq(0ul, (ulong)Off);
            Claim.eq(1ul, (ulong)On);

        }

        public void sb_bit_parse()
        {            
            //parse
            Claim.eq(Off, bit.Parse('0'));
            Claim.eq(On, bit.Parse('1'));
        }

        public void sb_bit_not()
        {
            Claim.eq(On, ~ Off);
            Claim.eq(Off, ~ On);
        }

        public void sb_bit_and()
        {
            Claim.eq(On, On & On);
            Claim.eq(Off, On & Off);
            Claim.eq(Off, Off & On);
            Claim.eq(Off, Off & Off);
        }

        public void bit_or()
        {
            Claim.eq(On, Off | On);
            Claim.eq(On, On | Off);
            Claim.eq(Off, Off | Off);
            Claim.eq(On, On | On);
        } 

        public void bit_xor()
        {
            Claim.eq(On, Off ^ On);
            Claim.eq(On, On ^ Off);
            Claim.eq(Off, Off ^ Off);
            Claim.eq(Off, On ^ On);
        }
    }
}

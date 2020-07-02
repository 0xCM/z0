//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class t_bit_type : t_bitcore<t_bit_type>
    {
        static bit On = bit.On;
        
        static bit Off = bit.Off;

        public void sb_bit_convert()
        {            
            Claim.Eq((byte)0, (byte)Off);
            Claim.Eq((byte)1, (byte)On);

            Claim.Eq((ushort)0, (ushort)Off);
            Claim.Eq((ushort)1, (ushort)On);

            Claim.Eq(0u, (uint)Off);
            Claim.Eq(1u, (uint)On);

            Claim.Eq(0ul, (ulong)Off);
            Claim.Eq(1ul, (ulong)On);

        }

        public void sb_bit_parse()
        {            
            //parse
            Claim.Eq(Off, bit.Parse('0'));
            Claim.Eq(On, bit.Parse('1'));
        }

        public void sb_bit_not()
        {
            Claim.Eq(On, ~ Off);
            Claim.Eq(Off, ~ On);
        }

        public void sb_bit_and()
        {
            Claim.Eq(On, On & On);
            Claim.Eq(Off, On & Off);
            Claim.Eq(Off, Off & On);
            Claim.Eq(Off, Off & Off);
        }

        public void bit_or()
        {
            Claim.Eq(On, Off | On);
            Claim.Eq(On, On | Off);
            Claim.Eq(Off, Off | Off);
            Claim.Eq(On, On | On);
        } 

        public void bit_xor()
        {
            Claim.Eq(On, Off ^ On);
            Claim.Eq(On, On ^ Off);
            Claim.Eq(Off, Off ^ Off);
            Claim.Eq(Off, On ^ On);
        }
    }
}

//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static BitLogicSpec;



    public class t_probes : UnitTest<t_probes>
    {
        static BitVector<uint> M1 = 0xFFFFFFFF;

        // Enables the least significant bit of each 8-bit segment
        static BitVector<uint> MA = 0x01010101;

        // Enables the most significant bit of each 8-bit segment
        static BitVector<uint> MB = 0x80808080;

        // Create an alternating bit pattern 0101...01
        static BitVector<uint> MC = 0x55555555;

        // Create an alternating bit pattern 1010...10
        static BitVector<uint> MD = 0xAAAAAAAA;

        public void probe_select()
        {
            var a = BitVector.from(n8,0b10101010);
            var b = BitVector.from(n8,0b10101010);
            var c = BitVector.from(n8,0b01010101);
            var d = BitVector.from(n8,0b11111111);
            var z = BitVector.select(a,b,c);
            Claim.eq(z,d);
        }

    }

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bc_literal : t_bc<t_bc_literal>
    {

        public void nbc_literal_40x64()
        {
            var n = n40;      
            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;     
            var bvz = BitCells.literal(z,n);
            Span<byte> xSrc =  BitConvert.GetBytes(z);
            var bvx = BitCells.literals(xSrc.Slice(0,5).ToArray());
            Claim.eq(gbits.pop(z), bvz.Pop());
            Claim.eq(gbits.pop(z), bvx.Pop());

            for(var i=0; i<n; i++)
                Claim.eq(bvz[i], bvx[i]);
        }

        public void nbc_literal_12x32()
        {
            var bv = BitCells.literal(0b101110001110u, n12);
            Claim.eq(bv[0], Bit.Off);
            Claim.eq(bv[1], Bit.On);
            Claim.eq(bv[11], Bit.On);
        }
    }
}

//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Gone;

    public class t_vlut : UnitTest<t_vlut>
    {     
        public void lut16_rep_check()
        {
            var n = n128;

            var src = Blocks.single<byte>(n);
            for(var i=0; i<src.BlockLength; i++)
                src[i] = (byte)i;
                        
            var table = LUT.define(src);
            for(var i=0; i< table.Count; i++)
                Claim.eq(table[i], (byte)i);

            var x = Data.vincrements<byte>(n);
            Claim.veq(x,table.Data);   

            var items = gvec.vinc<byte>(n, 64);
            var selected = dvec.vshuf16x8(items, table);
            Claim.veq(items,selected);
        }

        public void lut32_rep_check()
        {
            var n = n256;

            var src = Blocks.single<byte>(n);
            for(var i=0; i<src.BlockLength; i++)
                src[i] = (byte)i;
                        
            var table = LUT.define(src);
            for(var i=0; i< table.Count; i++)
                Claim.eq(table[i], (byte)i);

            var x = Data.vincrements<byte>(n);
            Claim.veq(x,table.Data);   

            var items = gvec.vinc<byte>(n, 64);
            var selected = dvec.vshuf32x8(items, table);
            Claim.veq(items,selected);

        }
    }
}

//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vlut : UnitTest<t_vlut>
    {     
        public void lut16_rep_check()
        {
            var n = n128;

            var src = DataBlocks.single<byte>(n);
            for(var i=0; i<src.BlockLength; i++)
                src[i] = (byte)i;
                        
            var table = LUT.define(src);
            for(var i=0; i< table.Count; i++)
                Claim.eq(table[i], (byte)i);


            var x = VPattern.vincrements<byte>(n);
            Claim.eq(x,table.Data);   

            var items = VPattern.vincrements<byte>(n, 64);
            var selected = dinx.vshuf16x8(items, table);
            Claim.eq(items,selected);

        }

        public void lut32_rep_check()
        {
            var n = n256;

            var src = DataBlocks.single<byte>(n);
            for(var i=0; i<src.BlockLength; i++)
                src[i] = (byte)i;
                        
            var table = LUT.define(src);
            for(var i=0; i< table.Count; i++)
                Claim.eq(table[i], (byte)i);

            var x = VPattern.vincrements<byte>(n);
            Claim.eq(x,table.Data);   

            var items = VPattern.vincrements<byte>(n, 64);
            var selected = dinx.vshuf32x8(items, table);
            Claim.eq(items,selected);

        }
    }
}
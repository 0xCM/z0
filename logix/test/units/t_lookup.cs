
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
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_lookup : UnitTest<t_lookup>
    {
        public void lut16_rep_check()
        {
            var nLut = n16;
            var nVec = n128;

            Span<byte> src = stackalloc byte[nLut];
            for(var i=0; i<src.Length; i++)
                src[i] = (byte)i;
                        
            var table = Lookup.From(nLut, src);
            for(var i=0; i< nLut; i++)
                Claim.eq(table[(LookupSlot)i], (LookupKey)i);

            var dst = table.Bytes;
            for(var i=0; i<src.Length; i++)                   
                Claim.eq(src[i], dst[i]);

            var x = ginx.vincrements<byte>(nVec);
            var y = table.Vector;
            Claim.eq(x,y);   

            var items = ginx.vincrements<byte>(nVec, 64);
            var selected = dinx.vshuffle(items, x);
            Claim.eq(items,selected);

        }

        public void lut32_rep_check()
        {
            var nLut = n32;
            var nVec = n256;

            Span<byte> src = stackalloc byte[nLut];
            for(var i=0; i < nLut; i++)
                src[i] = (byte)i;
                        
            var table = Lookup.From(nLut, src);
            var dst = table.Bytes;
            for(var i=0; i < nLut; i++)                   
                Claim.eq(src[i], dst[i]);

            var x = ginx.vincrements<byte>(nVec);
            var y = table.Vector;
            Claim.eq(x,y);   

            var items = ginx.vincrements<byte>(nVec, 64);
            var selected = dinx.vshuffle(items, x);
            Claim.eq(items,selected);


        }

    }


}



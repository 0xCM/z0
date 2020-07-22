
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;

    public class t_vlut : t_inx<t_vlut>
    {     
        public void lut16_rep_check()
        {
            var w = w128;

            var src = V0.vincrements<byte>(w);
            var lut = VLut.init(src);

            var content = gvec.vinc<byte>(w, 64);
            var selected =  VLut.select(lut,content); //dvec.vshuf16x8(items, table);
            Claim.veq(content, selected);
        }

        public void lut32_rep_check()
        {
            var w = w256;

            var src = V0.vincrements<byte>(w);
            var lut = VLut.init(src);

            var content = gvec.vinc<byte>(w, 64);
            var selected =  VLut.select(lut,content); //dvec.vshuf32x8(items, table);
            Claim.veq(content, selected);
        }
    }
}
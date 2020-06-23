//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public sealed class t_mask_capture : t_asm<t_mask_capture>
    {    
        public void asci_render()
        {
            var src = Random.Bytes(8).ToSpan();
            var actual = asci.render(Konst.base2, src).Reverse().ToString();
            var expect = src.ToBitSpan().Format();
            ClaimPrimal.eq(expect,actual);

        }

        public void capture_natural_masks()
        {
            using var hexout = HexWriter();
            using var asmout = AsmWriter();


            foreach(var src in MaskCases.NaturalClosures)
            {
                var captured = AsmCheck.Capture(src.Identify(), src).Require();                                
                hexout.Write(captured.HostedBits);
                asmout.WriteAsm(AsmCheck.Decoder.Decode(captured).Require());
            }    
        }

    }
}
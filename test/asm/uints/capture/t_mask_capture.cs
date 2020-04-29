//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;


    public sealed class t_mask_capture : t_asm<t_mask_capture>
    {    

        public void capture_natural_masks()
        {
            using var hexout = HexWriter();
            using var asmout = AsmWriter();


            foreach(var src in MaskCases.NaturalClosures)
            {
                var captured = AsmCheck.Capture(src.Identify(), src).Require();                                
                hexout.WriteHex(captured.Code);
                asmout.WriteAsm(AsmCheck.Decoder.Decode(captured).Require());
            }    
        }

        public void capture_numeric_masks()
        {
            using var hexout = HexWriter();
            using var asmout = AsmWriter();

            var methods = 
                from def in MaskCases.NumericMethodDefs
                from closure in def.MakeGenericMethods(MaskCases.NumericArgs)
                select closure;

            foreach(var src in methods)
            {
                var captured = AsmCheck.Capture(src.Identify(), src).Require();                                
                hexout.WriteHex(captured.Code);
                asmout.WriteAsm(AsmCheck.Decoder.Decode(captured).Require());
            }    
        }
    }
}
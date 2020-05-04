//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    
    using static Seed;
    using static Memories;

    public readonly struct UriBitsDecoder : IUriBitsDecoder
    {        
        public static IUriBitsDecoder Service => default(UriBitsDecoder);
                    
        public IEnumerable<AsmInstructions> Decode(IEnumerable<UriBits> bits)
        {
            var decoder = Capture.Services.AsmDecoder();
            foreach(var op in bits)
            {
                var decoded = decoder.Decode(op);
                if(decoded)
                    yield return decoded.Value;
            }            
        }
    }
}
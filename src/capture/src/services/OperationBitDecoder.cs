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

    public readonly struct OperationBitDecoder : IOperationBitDecoder
    {        
        public static IOperationBitDecoder Service => default(OperationBitDecoder);

        IAsmFunctionDecoder Decoder => AsmWorkflows.Stateless.AsmDecoder();
        
        public Option<AsmInstructionList> Decode(OperationBits src)
            => Decoder.Decode(src);
            
        public IEnumerable<AsmInstructionList> Decode(IEnumerable<OperationBits> operations)
        {
            var decoder = Decoder;
            foreach(var op in operations)
            {
                var decoded = decoder.Decode(op);
                if(decoded)
                    yield return decoded.Value;
            }            
        }
    }
}
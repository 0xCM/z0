//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Konst;

    public readonly struct AsmDecoderProxy : IAsmDecoder
    {
        readonly IAsmDecoder Decoder;

        public static AsmDecoderProxy Service
        {
             [MethodImpl(Inline)]
             get => new AsmDecoderProxy(AsmRoutineDecoder.Default);
        }        
        
        [MethodImpl(Inline)]
        internal AsmDecoderProxy(IAsmDecoder service)
            => Decoder = service; 

        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        public Option<AsmRoutine> Decode(CapturedCode src)
            => Decoder.Decode(src);       

        /// <summary>
        /// Decodes a function for a parsed extract
        /// </summary>
        /// <param name="src">The source data</param>
        public Option<AsmRoutine> Decode(ParsedExtraction src)
            => Decoder.Decode(src);       

        public Option<AsmInstructions> Decode(IdentifiedCode src)
            => Decoder.Decode(src);       

        public Option<AsmRoutine> Decode(ParsedExtraction src, Action<Instruction> f)
            => Decoder.Decode(src,f);       
        
        public Option<AsmFxList> Decode(LocatedCode src, Action<Instruction> f)                      
            => Decoder.Decode(src,f);       
        
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public Option<AsmFxList> Decode(LocatedCode src)
            => Decoder.Decode(src);       
    }
}
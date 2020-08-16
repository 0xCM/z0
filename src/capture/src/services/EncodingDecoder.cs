//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Konst;

    public readonly struct EncodingDecoder : IAsmRoutineDecoder
    {
        readonly IAsmRoutineDecoder AsmDecoder;

        public static EncodingDecoder Service
        {
             [MethodImpl(Inline)]
             get => new EncodingDecoder(AsmRoutineDecoder.Default);
        }        
        
        [MethodImpl(Inline)]
        internal EncodingDecoder(IAsmRoutineDecoder service)
            => AsmDecoder = service; 

        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        public Option<AsmRoutine> Decode(CapturedCode src)
            => AsmDecoder.Decode(src);       

        /// <summary>
        /// Decodes a fucntion for a parsed extract
        /// </summary>
        /// <param name="src">The source data</param>
        public Option<AsmRoutine> Decode(ParsedExtraction src)
            => AsmDecoder.Decode(src);       

        public Option<AsmInstructions> Decode(IdentifiedCode src)
            => AsmDecoder.Decode(src);       

        public Option<AsmRoutine> Decode(ParsedExtraction src, Action<Instruction> f)
            => AsmDecoder.Decode(src,f);       
        
        public Option<AsmFxList> Decode(LocatedCode src, Action<Instruction> f)                      
            => AsmDecoder.Decode(src,f);       
        
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public Option<AsmFxList> Decode(LocatedCode src)
            => AsmDecoder.Decode(src);       
    }
}
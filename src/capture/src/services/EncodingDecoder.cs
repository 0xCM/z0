//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Konst;

    public readonly struct EncodingDecoder : IAsmFunctionDecoder
    {
        readonly IAsmFunctionDecoder AsmDecoder;

        public static EncodingDecoder Service
        {
             [MethodImpl(Inline)]
             get => new EncodingDecoder(AsmFunctionDecoder.Default);
        }        
        
        [MethodImpl(Inline)]
        internal EncodingDecoder(IAsmFunctionDecoder service)
            => AsmDecoder = service; 

        /// <summary>
        /// Decodes a function from member capture data
        /// </summary>
        /// <param name="src">The source data</param>
        public Option<AsmFunction> Decode(CapturedCode src)
            => AsmDecoder.Decode(src);       

        /// <summary>
        /// Decodes a fucntion for a parsed extract
        /// </summary>
        /// <param name="src">The source data</param>
        public Option<AsmFunction> Decode(ParsedExtract src)
            => AsmDecoder.Decode(src);       

        public Option<AsmInstructions> Decode(IdentifiedCode src)
            => AsmDecoder.Decode(src);       

        public Option<AsmFunction> Decode(ParsedExtract src, Action<Instruction> f)
            => AsmDecoder.Decode(src,f);       
        
        public Option<AsmInstructionList> Decode(LocatedCode src, Action<Instruction> f)                      
            => AsmDecoder.Decode(src,f);       
        
        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public Option<AsmInstructionList> Decode(LocatedCode src)
            => AsmDecoder.Decode(src);       
    }
}
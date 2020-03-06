//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using Z0.Asm;
    
    using static Root;    

    public readonly struct AsmInstructionDecoder : IAsmInstructionDecoder
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static AsmInstructionDecoder Create(IAsmContext context)
            => new AsmInstructionDecoder(context);

        [MethodImpl(Inline)]
        AsmInstructionDecoder(IAsmContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        [MethodImpl(Inline)]
        public Option<AsmInstructionList> DecodeInstructions(AsmCode src)
            => Context.DecodeInstructions(src);

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        [MethodImpl(Inline)]
        public Option<AsmInstructionList> DecodeInstructions(MemoryExtract src)        
            => Context.DecodeInstructions(src);
    }
}
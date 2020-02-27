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

    readonly struct AsmDecoder : IAsmDecoder
    {
        public IAsmContext Context {get;}

        readonly bool EmitCil;

        [MethodImpl(Inline)]
        public static IAsmDecoder Create(IAsmContext context, bool emitcil = true)
            => new AsmDecoder(context, emitcil);

        [MethodImpl(Inline)]
        AsmDecoder(IAsmContext context, bool cil)
        {
            this.Context = context;
            this.EmitCil = cil;
        }

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public AsmInstructionList DecodeInstructions(AsmCode src)
            => Context.InstructionDecoder().DecodeInstructions(src);

        public AsmFunction DecodeFunction(ParsedEncoding parsed)
            => Context.FunctionDecoder().DecodeFunction(parsed);

        /// <summary>
        /// Decodes a function from a native capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        public AsmFunction DecodeFunction(CapturedMember src, bool emitcil = true)
            => Context.FunctionDecoder().DecodeFunction(src, emitcil);
    }
}
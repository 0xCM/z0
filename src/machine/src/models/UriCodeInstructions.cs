//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    /// <summary>
    /// Parirs a uri code block with instructions decoded from the block
    /// </summary>         
    public readonly struct UriCodeInstructions 
    {
        public static UriCodeInstructions Empty => Create(UriCode.Empty, Control.array<UriCodeInstruction>());

        public UriCode Code {get;}

        public UriCodeInstruction[] Instructions {get;}

        [MethodImpl(Inline)]
        public static UriCodeInstructions Create(UriCode code, UriCodeInstruction[] src)
            => new UriCodeInstructions(code,src);
        
        public int TotalCount { [MethodImpl(Inline)] get => Instructions.Length; }

        [MethodImpl(Inline)]        
        public UriCodeInstructions(UriCode code, UriCodeInstruction[] inxs)
        {
            Code = code;
            Instructions = inxs;
        }
    }
}
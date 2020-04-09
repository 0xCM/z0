//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmInstructionSource : IAsmInstructionSource
    {
        [MethodImpl(Inline)]
        public static IAsmInstructionSource From(Func<IEnumerable<AsmInstructionList>> f)
            => new AsmInstructionSource(f);
        
        [MethodImpl(Inline)]
        AsmInstructionSource(Func<IEnumerable<AsmInstructionList>> f)
        {
            this.Producer = f;
        }

        readonly Func<IEnumerable<AsmInstructionList>> Producer;

        public IEnumerable<AsmInstructionList> Instructions 
            => Producer();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.AsmSpecs;

    using static zfunc;

    public readonly struct AsmInstructionSource : IAsmInstructionSource
    {
        [MethodImpl(Inline)]
        public static IAsmInstructionSource FromProducer(Func<IEnumerable<AsmInstructionList>> f)
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
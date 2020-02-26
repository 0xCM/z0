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

    using Z0.Asm;

    using static Root;

    readonly struct CilFunctionEmitter : ICilFunctionEmitter
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static ICilFunctionEmitter Create(IAsmContext context)
            => new CilFunctionEmitter(context);

        [MethodImpl(Inline)]
        CilFunctionEmitter(IAsmContext context)
        {
            this.Context = context;
        }

        public Option<Exception> EmitCil(IEnumerable<AsmFunction> functions, FilePath dst)
            => Context.CilWriter(dst).WriteCil(functions);
    }
}

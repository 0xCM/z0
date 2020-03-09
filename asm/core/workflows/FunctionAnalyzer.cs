//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

   public readonly struct FunctionAnalyzer<R> : IFunctionAnalyzer<R>
        where R : IAnalysis
    {
        readonly Func<AsmFunction,R> F;        

        [MethodImpl(Inline)]
        public static FunctionAnalyzer<R> Create(Func<AsmFunction,R> f)
            => new FunctionAnalyzer<R>(f);

        internal FunctionAnalyzer(Func<AsmFunction,R> f)
        {
            this.F = f;
        }

        [MethodImpl(Inline)]
        public R Analyze(in AsmFunction f)
            => F(f);
    }    
}
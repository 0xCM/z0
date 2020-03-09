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

    using S = AsmFunction;

    public static class FunctionAnalyzer
    {
        /// <summary>
        /// Creates a function anylzer predicated on an analysis function
        /// </summary>
        /// <param name="f">The analysis function</param>
        /// <typeparam name="R">The analysis type</typeparam>
        [MethodImpl(Inline)]
        public static IFunctionAnalyzer<R> Create<R>(Func<S,R> f)
            where R : IAnalysis
                => FunctionAnalyzer<R>.Create(f);

        /// <summary>
        /// Creates the default function anylzer
        /// </summary>
        [MethodImpl(Inline)]
        public static IAnalyzer<S,DefaultAnalysis> Create()
            => default(DefaultAnalyzer);

        public readonly struct DefaultAnalysis : IAnalysis
        {
            [MethodImpl(Inline)]
            public static DefaultAnalysis Define(int instructions)
                => new DefaultAnalysis(instructions);

            [MethodImpl(Inline)]
            DefaultAnalysis(int instructions)
            {
                this.InstructionCount = instructions;
            }

            public readonly int InstructionCount;
        }

        readonly struct DefaultAnalyzer : IAnalyzer<DefaultAnalyzer, S, DefaultAnalysis>
        {
            public DefaultAnalysis Analyze(in S src)
            {
                return DefaultAnalysis.Define(src.InstructionCount);
            }
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    public readonly struct RunnerContext : IRunnerContext
    {
        public PartId[] Parts {get;}

        [MethodImpl(Inline)]
        public static IRunnerContext Create(IAsmContext root, PartId[] parts)
            => new RunnerContext(root, parts);

        public IAsmContext AsmContext {get;}        

        public IAppMsgSink AppMsgSink 
            => AsmContext;
                        
        [MethodImpl(Inline)]
        RunnerContext(IAsmContext root, PartId[] parts)
        {
            AsmContext = root;
            Parts = parts;
        }        
    }
}
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

    public readonly struct CommandProcessor<P,C,S> : ICommandProcessor<CommandProcessor<P,C,S>, C, S>
        where P : unmanaged, ICommandProcessor
        where C : unmanaged, IOperands
        where S : ICommandProcessorState<C,S>
    {
        [MethodImpl(Inline)]
        public static implicit operator CommandProcessor<C,S>(CommandProcessor<P,C,S> src)
            => new CommandProcessor<C,S>();

        [MethodImpl(Inline)]
        public void Process(in C cmd, ref S state)
            => Generalized.Process(cmd,ref state);

        [MethodImpl(Inline)]
        public void Process(IOperands cmd, ref S state)
            => Generalized.Process(cmd, ref state);

        CommandProcessor<C,S> Generalized
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}
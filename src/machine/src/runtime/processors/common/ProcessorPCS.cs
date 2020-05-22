//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct Processor<P,C,S> : IProcessor<Processor<P,C,S>, C, S>
        where P : unmanaged, IProcessor
        where C : unmanaged, ICommand
        where S : IProcessState<C,S>
    {
        [MethodImpl(Inline)]
        public static implicit operator Processor<C,S>(Processor<P,C,S> src)
            => new Processor<C,S>();

        [MethodImpl(Inline)]
        public void Process(in C cmd, ref S state)
            => Generalized.Process(cmd,ref state);

        [MethodImpl(Inline)]
        public void Process(ICommand cmd, ref S state)
            => Generalized.Process(cmd, ref state);

        Processor<C,S> Generalized
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}
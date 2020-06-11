//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    public readonly struct Processor<P,C,S> : IProcessor<Processor<P,C,S>, C, S>
        where P : unmanaged, IProcessor
        where C : unmanaged, ICmd
        where S : IProcessState<C,S>
    {
        [MethodImpl(Inline)]
        public static implicit operator Processor<C,S>(Processor<P,C,S> src)
            => new Processor<C,S>();

        [MethodImpl(Inline)]
        public void Process(in C cmd, ref S state)
            => Generalized.Process(cmd,ref state);

        [MethodImpl(Inline)]
        public void Process(ICmd cmd, ref S state)
            => Generalized.Process(cmd, ref state);

        Processor<C,S> Generalized
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;
    using static z;

    public interface IDfaStates<Q,I,S> : IIndex<I,S>
        where Q : struct, IIndex<S>
        where I : unmanaged
        where S : struct, IDfaState<S>
    {

    }

    public interface IDfaStates<Q,S> : IDfaStates<Q,ushort,S>
        where Q : struct, IIndex<S>
        where S : struct, IDfaState<S>
    {

    }

    public interface IDfaState<S>
        where S : struct
    {

    }

    public interface IDfaState<H,S> : IDfaState<S>
        where H : struct, IDfaState<H,S>
        where S : struct
    {

    }

    public readonly struct DfaState<S> : IDfaState<DfaState<S>,S>
        where S : struct
    {

    }

    public readonly struct DfaStates<S> : IDfaStates<DfaStates<S>,ushort,S>
        where S : struct, IDfaState<S>
    {
        readonly S[] States;

        [MethodImpl(Inline)]
        public DfaStates(S[] states)
            => States = states;

        public ref S this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref States[z.u32(index)];
        }

        public S[] Storage
        {
            [MethodImpl(Inline)]
            get => States;
        }

        public Span<S> Terms
        {
            [MethodImpl(Inline)]
            get => States;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)States.Length;
        }
    }

}
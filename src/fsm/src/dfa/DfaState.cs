//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IDfaState<S>
        where S : IEquatable<S>
    {
        S Value {get;}
    }

    public readonly struct DfaState<S> : IDfaState<S>
        where S : IEquatable<S>
    {
        public S Value {get;}

        [MethodImpl(Inline)]
        public DfaState(S value)
        {
            Value = value;
        }
    }

    public readonly struct DfaStates<S> : IIndex<ushort,DfaState<S>>
        where S : IEquatable<S>
    {
        readonly Index<DfaState<S>> States;

        [MethodImpl(Inline)]
        public DfaStates(DfaState<S>[] states)
            => States = states;

        public ref DfaState<S> this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref States[z.u32(index)];
        }

        public DfaState<S>[] Storage
        {
            [MethodImpl(Inline)]
            get => States;
        }

        public ReadOnlySpan<DfaState<S>> View
        {
            [MethodImpl(Inline)]
            get => States.View;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)States.Length;
        }
    }
}
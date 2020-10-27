//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct GenericState
    {
        public readonly byte State;

        public const byte NonGeneric = 0;

        public const byte Generic = 1;

        [MethodImpl(Inline)]
        public static bool operator ==(GenericState g1, GenericState g2)
            => g1.State == g2.State;

        [MethodImpl(Inline)]
        public static bool operator !=(GenericState g1, GenericState g2)
            => g1.State != g2.State;

        [MethodImpl(Inline)]
        public static implicit operator bool(GenericState src)
            => src.State != 0;

        [MethodImpl(Inline)]
        public static implicit operator GenericState(byte src)
            => new GenericState(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(GenericState src)
            => src.State;

        [MethodImpl(Inline)]
        public static implicit operator GenericState(bool src)
            => new GenericState(src ? (byte)1 : (byte)0);

        [MethodImpl(Inline)]
        public GenericState(byte state)
            => State = state;

        [MethodImpl(Inline)]
        public bool IsGeneric()
            => State == GenericState.Generic;

        public override int GetHashCode()
            => State.GetHashCode();

        public override bool Equals(object src)
            => src is GenericState p && p.State == State;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct GenericPartition
    {   
        public readonly byte State;

        public const byte NonGeneric = 0;
        
        public const byte Generic = 1;

        [MethodImpl(Inline)]
        public static bool operator ==(GenericPartition g1, GenericPartition g2)
            => g1.State == g2.State;

        [MethodImpl(Inline)]
        public static bool operator !=(GenericPartition g1, GenericPartition g2)
            => g1.State != g2.State;

        [MethodImpl(Inline)]
        public static implicit operator bool(GenericPartition src)
            => src.State != 0;

        [MethodImpl(Inline)]
        public static implicit operator GenericPartition(byte src)
            => new GenericPartition(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(GenericPartition src)
            => src.State;

        [MethodImpl(Inline)]
        public static implicit operator GenericPartition(bool src)
            => new GenericPartition(src ? (byte)1 : (byte)0);

        [MethodImpl(Inline)]
        GenericPartition(byte state)
        {
            this.State = state;
        }

        [MethodImpl(Inline)]
        public bool IsGeneric()
            => State == GenericPartition.Generic;

        public override int GetHashCode()
            => State.GetHashCode();
        
        public override bool Equals(object src)
            => src is GenericPartition p && p.State == State;
    }
}
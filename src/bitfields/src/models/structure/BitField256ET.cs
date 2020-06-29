//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;    
    using static Memories;

    public struct BitField256<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        internal Vector256<T> State;

        internal readonly BitFieldSpec256<E> Spec;

        [MethodImpl(Inline)]
        internal BitField256(BitFieldSpec256<E> spec, Vector256<T> state)
        {
            this.Spec = spec;
            this.State = state;
        }

        [MethodImpl(Inline)]
        internal BitField256(BitFieldSpec256<E> spec)
        {
            this.Spec = spec;
            this.State = default;
        }
        
        public T this[E index]
        {
            [MethodImpl(Inline)]
            get => BitFields.read(this,index);
        }
    }
}
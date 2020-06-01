//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;    
    using static Memories;

    public struct BitField256<F,T>
        where T : unmanaged
        where F : unmanaged, Enum
    {
        internal Vector256<T> State;

        internal readonly BitFieldSpec256<F> Spec;

        [MethodImpl(Inline)]
        internal BitField256(BitFieldSpec256<F> spec, Vector256<T> state)
        {
            this.Spec = spec;
            this.State = state;
        }

        [MethodImpl(Inline)]
        internal BitField256(BitFieldSpec256<F> spec)
        {
            this.Spec = spec;
            this.State = default;
        }
        
        public T this[F index]
        {
            [MethodImpl(Inline)]
            get => BitFields.read(this,index);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
        
    public readonly struct nonzero<T>  : INonZero<nonzero<T>,T>, IEquatable<T>
        where T : unmanaged
    {
        public readonly T Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator nonzero<T>(T src)
            => new nonzero<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(nonzero<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public nonzero(T value)
        {
            this.Value = gmath.zclear(value);
        }

        [MethodImpl(Inline)]
        public bool Equals(nonzero<T> src)
            => gmath.eq(Value, src.Value);

        [MethodImpl(Inline)]
        public bool Equals(T src)
            => gmath.eq(Value, src);
    }
}
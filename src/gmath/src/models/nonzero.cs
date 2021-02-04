//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Nonzero<T> : INonZero<Nonzero<T>,T>, IEquatable<T>
        where T : unmanaged
    {
        public readonly T Value {get;}

        [MethodImpl(Inline)]
        public Nonzero(T value)
        {
            Value = gmath.nonz(value) ? value : Numeric.ones<T>();
        }

        [MethodImpl(Inline)]
        public bool Equals(Nonzero<T> src)
            => gmath.eq(Value, src.Value);

        [MethodImpl(Inline)]
        public bool Equals(T src)
            => gmath.eq(Value, src);

        [MethodImpl(Inline)]
        public static implicit operator Nonzero<T>(T src)
            => new Nonzero<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Nonzero<T> src)
            => src.Value;
    }
}
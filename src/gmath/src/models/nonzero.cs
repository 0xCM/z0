//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public static class nonzero
    {
        /// <summary>
        /// Manufactures a numeric proxy defined over the punctured domain T / {0}. If a
        /// zero value is supplied, it is replaced with -1
        /// </summary>
        /// <param name="value">The nonzero value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static Nonzero<T> create<T>(T value)
            where T : unmanaged
                => new Nonzero<T>(value);
    }

    public readonly struct Nonzero<T>  : INonZero<Nonzero<T>,T>, IEquatable<T>
        where T : unmanaged
    {
        public readonly T Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator Nonzero<T>(T src)
            => new Nonzero<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Nonzero<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public Nonzero(T value)
        {
            Value =  root.require(gmath.nonz(value), value, () => "Nonzero it must be");
        }

        [MethodImpl(Inline)]
        public bool Equals(Nonzero<T> src)
            => gmath.eq(Value, src.Value);

        [MethodImpl(Inline)]
        public bool Equals(T src)
            => gmath.eq(Value, src);
    }
}
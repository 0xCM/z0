//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
        
    public static class nonzero
    {
        /// <summary>
        /// Manufactures a numeric proxy defined over the punctured domain T / {0}. If a
        /// zero value is supplied, it is replaced with -1
        /// </summary>
        /// <param name="value">The nonzero value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static nonzero<T> create<T>(T value)
            where T : unmanaged
                => new nonzero<T>(value);

    }

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
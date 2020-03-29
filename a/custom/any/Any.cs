//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Core;

    /// <summary>
    /// A generic variant
    /// </summary>
    public readonly struct Any<T> : IAny<Any<T>>, IEquatable<Any<T>>
    {
        public readonly T Contained;

        [MethodImpl(Inline)]
        public static Any<T> From<S>(in S src)
            => new Any<T>(Unsafe.As<S,T>(ref Unsafe.AsRef(src)));
        
        public static bool operator ==(Any<T> x, Any<T> y)
            => x.Equals(y);

        public static bool operator !=(Any<T> x, Any<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator Any<T>(T src)
            => new Any<T>();

        [MethodImpl(Inline)]
        public static implicit operator T(Any<T> src)
            => src.Contained;

        [MethodImpl(Inline)]
        public Any(T src)
            => this.Contained = src;
        
        [MethodImpl(Inline)]
        public Any<S> As<S>()
            => new Any<S>(Unsafe.As<T,S>(ref Unsafe.AsRef(in Contained)));

        public string Format()
            => Contained?.ToString() ?? string.Empty;
        
        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Contained?.GetHashCode() ?? 0;

        public bool Equals(Any<T> src)
            => Contained?.Equals(src.Contained) ?? false;

        public override bool Equals(object src)
            => src is Any<T> a && Equals(a);         
    }
}
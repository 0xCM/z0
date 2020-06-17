//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// A parametric T-equatable value
    /// </summary>
    public readonly struct Any<T> : IAny<Any<T>,T>
        where T : struct, IEquatable<T>
    {
        public readonly T Value;
        
        [MethodImpl(Inline)]
        public static Any<T> From<S>(in S src)
            => new Any<T>(Unsafe.As<S,T>(ref Unsafe.AsRef(src)));
        
        [MethodImpl(Inline)]
        public static bool operator ==(Any<T> x, Any<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Any<T> x, Any<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator Any<T>(T src)
            => new Any<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Any<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public Any(T src)
            => Value = src;
        
        public T Content
        {
            [MethodImpl(Inline)]
            get => Value;
        }

        [MethodImpl(Inline)]
        public Any<S> As<S>()
            where S : struct, IEquatable<S>
                => new Any<S>(Unsafe.As<T,S>(ref Unsafe.AsRef(in Value)));

        [MethodImpl(Inline)]
        public bool Equals(T src)
            => Value.Equals(src);

        [MethodImpl(Inline)]
        public bool Equals(Any<T> src)
            => Value.Equals(src.Value);

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();
        
        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object src)
            => src is Any<T> a && Equals(a);         
    }
}
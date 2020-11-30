//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    public readonly struct GtEq<T> : IFunc<T,T,bool>
    {
        readonly Func<T,T,bool> F;

        [MethodImpl(Inline)]
        public static implicit operator Func<T,T,bool>(GtEq<T> src)
            => src.F;

        [MethodImpl(Inline)]
        public static implicit operator MethodInfo(GtEq<T> src)
            => src.F.Method;

        [MethodImpl(Inline)]
        internal GtEq(Func<T,T,bool> f)
            => F = f;

        [MethodImpl(Inline)]
        public bool Invoke(T x, T y)
            => F(x, y);
    }
}
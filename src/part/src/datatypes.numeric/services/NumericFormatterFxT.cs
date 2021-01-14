//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NumericFormatterFx<T> : INumericFormatter<T>
        where T : unmanaged
    {
        readonly Func<T,string> F;

        readonly Func<T,NumericBaseKind,string> G;

        [MethodImpl(Inline)]
        public NumericFormatterFx(Func<T,string> f, Func<T,NumericBaseKind,string> g)
        {
            F = f;
            G = g;
        }

        [MethodImpl(Inline)]
        public NumericFormatterFx(Func<T,NumericBaseKind,string> g)
        {
            F = (t => g(t,NumericBaseKind.Base10));
            G = g;
        }

        [MethodImpl(Inline)]
        public string Format(T src, NumericBaseKind @base)
            => G(src, @base);

        [MethodImpl(Inline)]
        public string Format(T src)
            => F(src);

        [MethodImpl(Inline)]
        public NumericFormatter<T> Concretize()
            => new NumericFormatter<T>(this);
    }
}
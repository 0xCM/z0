//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NumericFormatter<F,T> : INumericFormatter<F,T>
        where T : unmanaged
        where F : struct, INumericFormatter<F,T>
    {
        readonly F Formatter;

        [MethodImpl(Inline)]
        public NumericFormatter(F formatter)
            => Formatter = formatter;

        [MethodImpl(Inline)]
        public string Format(T src, NumericBaseKind @base)
            => Formatter.Format(src, @base);

        [MethodImpl(Inline)]
        public NumericFormatter<F,T> Concretize()
            => this;

        [MethodImpl(Inline)]
        public NumericFormatter<S> As<S>()
            where S : unmanaged
                => new NumericFormatter<T>(this).As<S>();
    }
}
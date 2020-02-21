//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public static class NumericFormatter
    {
        [MethodImpl(Inline)]
        public static INumericFormatter<T> from<T>(Func<T,string> f, Func<T,NumericBase,string> g)
            where T : unmanaged
                => new FunctionalNumericFormatter<T>(f,g);

        [MethodImpl(Inline)]
        public static INumericFormatter<T> from<T>(Func<T,NumericBase,string> g)
            where T : unmanaged
                => new FunctionalNumericFormatter<T>(g);
    }

    public readonly struct NumericFormatter<T> : INumericFormatter<T>
        where T : unmanaged
    {
        readonly INumericFormatter<T> Formatter;

        [MethodImpl(Inline)]
        public NumericFormatter(INumericFormatter<T> formatter)
            => Formatter = formatter;

        [MethodImpl(Inline)]
        public string Format(T src, NumericBase @base)
            => Formatter.Format(src, @base);
        
        [MethodImpl(Inline)]
        public NumericFormatter<F> As<F>()
            where F : unmanaged
            => new NumericFormatter<F>(this as INumericFormatter<F>);

        [MethodImpl(Inline)]
        public NumericFormatter<T> Concretize()
            => this;
    }

    public readonly struct NumericFormatter<F,T> : INumericFormatter<F,T>
        where T : unmanaged
        where F : struct, INumericFormatter<F,T>
    {
        readonly F Formatter;

        [MethodImpl(Inline)]
        public NumericFormatter(F formatter)
            => Formatter = formatter;

        [MethodImpl(Inline)]
        public string Format(T src, NumericBase @base)
            => Formatter.Format(src, @base);

        [MethodImpl(Inline)]
        public NumericFormatter<F, T> Concretize()
            => this;

        [MethodImpl(Inline)]
        public NumericFormatter<S> As<S>()
            where S : unmanaged
            => new NumericFormatter<T>(this).As<S>();        
    }
    
    readonly struct FunctionalNumericFormatter<T> : INumericFormatter<T>
        where T : unmanaged
    {
        readonly Func<T,string> F;        

        readonly Func<T,NumericBase,string> G;        

        [MethodImpl(Inline)]
        internal FunctionalNumericFormatter(Func<T,string> f, Func<T,NumericBase,string> g)
        {
            this.F = f;
            this.G = g;
        }

        [MethodImpl(Inline)]
        internal FunctionalNumericFormatter(Func<T,NumericBase,string> g)
        {
            this.F = (t => g(t,NumericBase.Decimal));
            this.G = g;
        }

        [MethodImpl(Inline)]
        public string Format(T src, NumericBase @base)
            => G(src, @base);

        [MethodImpl(Inline)]
        public string Format(T src)
            => F(src);

        [MethodImpl(Inline)]
        public NumericFormatter<T> Concretize()
            => new NumericFormatter<T>(this);
    }
}
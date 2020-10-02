//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct NumericFormatter<T> : INumericFormatter<T>
        where T : unmanaged
    {
        readonly INumericFormatter<T> Formatter;

        [MethodImpl(Inline)]
        public NumericFormatter(INumericFormatter<T> formatter)
            => Formatter = formatter;

        [MethodImpl(Inline)]
        public string Format(T src, NumericBaseKind @base)
            => Formatter.Format(src, @base);
        
        [MethodImpl(Inline)]
        public NumericFormatter<F> As<F>()
            where F : unmanaged
            => new NumericFormatter<F>(this as INumericFormatter<F>);

        [MethodImpl(Inline)]
        public NumericFormatter<T> Concretize()
            => this;
    }
    
    readonly struct FunctionalNumericFormatter<T> : INumericFormatter<T>
        where T : unmanaged
    {
        readonly Func<T,string> F;        

        readonly Func<T,NumericBaseKind,string> G;        

        [MethodImpl(Inline)]
        internal FunctionalNumericFormatter(Func<T,string> f, Func<T,NumericBaseKind,string> g)
        {
            this.F = f;
            this.G = g;
        }

        [MethodImpl(Inline)]
        internal FunctionalNumericFormatter(Func<T,NumericBaseKind,string> g)
        {
            this.F = (t => g(t,NumericBaseKind.Base10));
            this.G = g;
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
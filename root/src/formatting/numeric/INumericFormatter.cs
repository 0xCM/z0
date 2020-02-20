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

    public interface INumericFormatter : IFormatter
    {
        
    }

    public interface INumericFormatter<T> : INumericFormatter, IFormatter<T>
    {
        string Format(T src, NumericBase @base);

        NumericFormatter<T> Concretize();

        [MethodImpl(Inline)]
        string IFormatter<T>.Format(T src)
            => Format(src, NumericBase.Decimal);        
    }

    public interface INumericFormatter<F,T> : INumericFormatter<T>
        where F : struct, INumericFormatter<F,T>
    {
        [MethodImpl(Inline)]
        new NumericFormatter<F,T> Concretize()
            => new NumericFormatter<F,T>(default(F));
        
        [MethodImpl(Inline)]
        NumericFormatter<T> INumericFormatter<T>.Concretize()
            => Concretize().As<T>();
    }
}
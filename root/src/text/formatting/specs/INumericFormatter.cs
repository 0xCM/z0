//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
 
    public interface INumericFormatter : IFormatter
    {
        
    }


    public interface INumericFormatter<T> : INumericFormatter, IFormatter<T>
        where T : unmanaged
    {
        string Format(T src, NumericBase @base);

        NumericFormatter<T> Concretize();

        string IFormatter<T>.Format(T src)
            => Format(src, NumericBase.Decimal);        
    }

    public interface INumericFormatter<F,T> : INumericFormatter<T>
        where F : struct, INumericFormatter<F,T>
        where T : unmanaged
    {
        new NumericFormatter<F,T> Concretize()
            => new NumericFormatter<F,T>(default(F));
        
        NumericFormatter<T> INumericFormatter<T>.Concretize()
            => Concretize().As<T>();
    }
}
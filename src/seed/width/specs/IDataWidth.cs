//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IDataWidth : IBitWidth, ITypedLiteral<DataWidth,uint>, ITextual
    {
        DataWidth DataWidth {get;}   

        DataWidth ITypedLiteral<DataWidth>.Class => DataWidth;

        uint IBitWidth.BitWidth => (uint)DataWidth;

        uint ITypedLiteral<DataWidth,uint>.Value => BitWidth;

        string ITypedLiteral<DataWidth>.Name => DataWidth.FormatName();

        string ITextual.Format() => DataWidth.FormatValue();
    }

    public interface IDataWidth<F> : IDataWidth, ITypedLiteral<F,DataWidth,uint>, IEquatable<F>
        where F : struct, IDataWidth<F>
    {        
        DataWidth IDataWidth.DataWidth => (DataWidth)Widths.data<F>();        

        bool IEquatable<F>.Equals(F src) => src.BitWidth == BitWidth;        
    }
}
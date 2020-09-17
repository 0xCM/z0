//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDataWidth : IBitWidth, ITypedLiteral<DataWidth,uint>, ITextual, IIdentified<string>
    {
        DataWidth DataWidth {get;}

        string IIdentified<string>.Id
            => $"{DataWidth}";

        TypeSignKind TypeSign
            => TypeSignKind.Unsigned;

        DataWidth ITypedLiteral<DataWidth>.Class
            => DataWidth;

        uint IBitWidth.BitWidth
            => (uint)DataWidth;

        uint ITypedLiteral<DataWidth,uint>.Value
            => BitWidth;

        string ITypedLiteral<DataWidth>.Name
            => DataWidth.FormatName();

        string ITextual.Format()
            => DataWidth.FormatValue();
    }

    public interface IDataWidth<W> : IDataWidth, ITypedLiteral<W,DataWidth,uint>, IEquatable<W>
        where W : struct, IDataWidth<W>
    {

    }
}
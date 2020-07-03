//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IDataWidth : IBitWidth, ITypedLiteral<DataWidth,uint>, ITextual
    {
        DataWidth DataWidth {get;}   

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
}
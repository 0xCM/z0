//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITypeWidth : IDataWidth
    {
        /// <summary>
        /// Refines the specificity of the class specifier
        /// </summary>
        TypeWidth TypeWidth {get;}

        // TypeWidth ITypedLiteral<TypeWidth>.Class
        //     => TypeWidth;

        // uint ITypedLiteral<TypeWidth,uint>.Value
        //     => BitWidth;

        // string ITypedLiteral<TypeWidth>.Name
        //     => TypeWidth.FormatName();
    }

    public interface ITypeWidth<W> : ITypeWidth, IDataWidth<W>
        where W : struct, ITypeWidth<W>
    {

    }
}
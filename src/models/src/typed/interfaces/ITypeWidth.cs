//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ITypeWidth : IDataWidth, ITypedLiteral<TypeWidth,uint>
    {
        /// <summary>
        /// Refines the specificity of the class specifier
        /// </summary>
        TypeWidth TypeWidth {get;}

        TypeWidth ITypedLiteral<TypeWidth>.Class 
            => TypeWidth;

        uint ITypedLiteral<TypeWidth,uint>.Value 
            => BitWidth;

        string ITypedLiteral<TypeWidth>.Name 
            => TypeWidth.FormatName();        
    }

}
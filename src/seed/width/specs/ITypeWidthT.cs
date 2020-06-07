//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITypeWidth<F> : ITypeWidth, IDataWidth<F>, ITypedLiteral<F,TypeWidth,uint>
        where F : struct, ITypeWidth<F>
    {        
        TypeWidth ITypeWidth.TypeWidth => Widths.type<F>();        
    }    
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TTypeWidth<F> : ITypeWidth, TDataWidth<F>, ITypedLiteral<F,TypeWidth,uint>
        where F : struct, TTypeWidth<F>
    {        
        TypeWidth ITypeWidth.TypeWidth 
            => Widths.type<F>();        
    }    
}
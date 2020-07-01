//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IFixedWidth<F> : IFixedWidth, ITypeWidth<F>, ITypedLiteral<F,FixedWidth,uint>
        where F : struct, IFixedWidth<F>
    {     
        FixedWidth IFixedWidth.FixedWidth 
            => Widths.tfixed<F>();               
    }

    public interface IFixedWidth<F,W> : IFixedWidth<F>
        where F : struct, IFixedWidth<F,W>
        where W : struct, IFixedWidth
    {

    }
}
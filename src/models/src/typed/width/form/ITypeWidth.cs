//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITypeWidth<W> : ITypeWidth, TDataWidth<W>, ITypedLiteral<W,TypeWidth,uint>
        where W : struct, ITypeWidth<W>
    {

    }
}
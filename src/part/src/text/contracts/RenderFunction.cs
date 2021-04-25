//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public delegate string FormatFunction<T>(T src);

    public delegate void RenderFunction<T>(in T src, ITextBuffer dst);
}
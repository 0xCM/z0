//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public delegate Outcome ParseFunction<T>(string src, out T dst);

    public delegate Outcome ParseFunction<S,T>(in S src, out T dst);

    public delegate string FormatFunction<T>(T src);

    public delegate void RenderFunction<T>(in T src, ITextBuffer dst);
}
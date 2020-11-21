//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate void RenderFunction<S,T>(in S src, IRenderBuffer<T> dst);


    [Free]
    public delegate void TextRenderFunction<S>(in S src, ITextBuffer dst);
}
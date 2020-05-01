//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public delegate string FormatRender<T>(T src);

    public delegate string FormatRender<C,T>(T src, in C config)
        where C : struct;
}
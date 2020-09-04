//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ILineFormatter<T> : IFormatter<T>
    {
        string[] FormatLines(T src);
    }
}
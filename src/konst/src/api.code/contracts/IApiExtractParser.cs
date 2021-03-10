//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiExtractParser
    {
        Outcome Parse(string src, out ApiExtractBlock dst);
    }
}
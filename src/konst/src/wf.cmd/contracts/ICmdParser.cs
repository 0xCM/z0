//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICmdParser : IWfService
    {
        Outcome Parse(CmdLine src, out CmdSpec dst);

        Outcome Parse(ReadOnlySpan<char> src, out ArgPrefix dst);
    }
}
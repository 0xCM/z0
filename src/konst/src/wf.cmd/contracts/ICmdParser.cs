//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public interface ICmdParser : IWfService
    {
        bool Parse(CmdLine src, out CmdSpec dst);

        bool Parse(ReadOnlySpan<char> src, out ArgPrefix dst);
    }
}
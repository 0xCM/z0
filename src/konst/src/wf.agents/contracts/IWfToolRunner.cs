//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TextRules;
    using static memory;

    public interface IWfToolRunner : IWfService
    {
        Outcome<TextLines> Run(CmdLine cmd);

        Index<CmdTypeInfo> Intrinsics();
    }
}
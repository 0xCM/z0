// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost(ApiNames.CmdPatterns, true)]
    public readonly struct CmdPatterns
    {
        public const string DefaultArgDelimiter = "--";

        public const string DefaultCmdType = "exe";
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct ToolInfo
    {
        public string HostName;

        public string RuntimeName;

        public string FlagPrefix;

        public string ArgSpecifier;

        public byte MaxVarCount;

        public string[] FlagNames;
    }
}
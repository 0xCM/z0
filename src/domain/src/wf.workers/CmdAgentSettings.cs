//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public enum CmdAgentKind : byte
    {
        CmdExe = 1,

        Bash = 2,

        Custom = 4
    }

    public struct CmdAgentSettings
    {
        public CmdAgentKind AgentKind;

        public FS.FilePath Path;
    }
}
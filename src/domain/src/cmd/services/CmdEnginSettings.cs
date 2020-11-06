//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public enum CmdEngineKind : byte
    {
        CmdExe = 1,

        Bash = 2,

        Custom = 4
    }

    public struct CmdEngineSettings
    {
        public CmdEngineKind EngineKind;

        public FS.FilePath Path;
    }
}
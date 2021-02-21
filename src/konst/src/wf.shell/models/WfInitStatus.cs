//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct WfInitStatus
    {
        public Timestamp StartTS;

        public Duration PathConfigTime;

        public Duration InitConfigTime;

        public Duration ShellCreateTime;

        public Timestamp FinishTS;

        public PartId Controller;

        public string[] Args;

        public FS.FilePath AppConfigPath;

        public PartId[] Parts;

    }
}
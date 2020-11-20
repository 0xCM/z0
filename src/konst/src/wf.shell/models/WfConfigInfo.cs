//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct WfConfigInfo
    {
        public PartId Controller;

        public string[] Args;

        public FS.FilePath AppConfigPath;

        public PartId[] Parts;

        public WfLogConfig LogConfig;
    }
}
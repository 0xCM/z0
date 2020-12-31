//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct JsonDepsModel
    {
        public struct RuntimeFileInfo
        {
            public FS.FilePath Path;

            public string AssemblyVersion;

            public string FileVersion;
        }
    }
}
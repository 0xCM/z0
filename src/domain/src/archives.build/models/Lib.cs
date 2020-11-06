//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct JsonDeps
    {
        public struct Library
        {
            public string Type;

            public string Name;

            public string Version;

            public string Hash;

            public IndexedView<LibDependency> Dependencies;

            public bool Serviceable;

            public FS.FilePath Path;

            public string HashPath;

            public string RuntimeStoreManifestName;
        }
    }
}
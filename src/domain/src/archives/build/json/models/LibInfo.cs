//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    partial struct JsonDeps
    {
        public struct Lib
        {
            public string Type;

            public string Name;

            public string Version;

            public string Hash;

            public IndexedView<LibDependency> Dependencies;

            public bool Serviceable;

            public string Path;

            public string HashPath;

            public string RuntimeStoreManifestName;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Toolset : IIdentified<utf8>
    {
        public utf8 Id {get;}

        public FS.FolderPath Location {get;}

        [MethodImpl(Inline)]
        public Toolset(string name, FS.FolderPath root)
        {
            Id = name;
            Location = root;
        }
    }
}
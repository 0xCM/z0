//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Toolset
    {
        public Name Name {get;}

        public FS.FolderPath Location {get;}

        [MethodImpl(Inline)]
        public Toolset(Name name, FS.FolderPath root)
        {
            Name = name;
            Location = root;
        }
    }
}
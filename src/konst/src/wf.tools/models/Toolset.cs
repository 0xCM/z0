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

    public readonly struct Toolset : IIdentified<string>
    {
        public string Id {get;}

        public FS.FolderPath Location {get;}

        [MethodImpl(Inline)]
        public Toolset(string name, FS.FolderPath root)
        {
            Id = name;
            Location = root;
        }

        [MethodImpl(Inline)]
        public static implicit operator Toolset(KeyedValue<string,FS.FolderPath> src)
            => new Toolset(src.Key, src.Value);
    }
}
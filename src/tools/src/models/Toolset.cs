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
    
    public readonly struct Toolset : IIdentified<ToolsetId>
    {
        public ToolsetId Id {get;}

        public FS.FolderPath Location {get;}

        [MethodImpl(Inline)]
        public Toolset(ToolsetId name, FS.FolderPath root)
        {
            Id = name;
            Location = root;
        }

        [MethodImpl(Inline)]
        public static implicit operator Toolset(KeyedValue<ToolsetId,FS.FolderPath> src)
            => new Toolset(src.Key, src.Value);
    }
}
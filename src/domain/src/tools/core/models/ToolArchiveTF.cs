//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolArchive<T,F>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        public ToolId Id {get;}

        public FS.FolderPath ToolOutput {get;}

        public IExtensionMap<F> Map {get;}

        readonly F[] Flags;

        [MethodImpl(Inline)]
        public ToolArchive(ToolId id, FS.FolderPath root, F[] flags)
        {
            Id = id;
            ToolOutput = root;
            Flags = flags;
            Map = new ExtensionMap<F>(flags);
        }

        public ToolArchive(ToolId id, FS.FolderPath root, F[] flags, IExtensionMap<F> map)
        {
            Id = id;
            ToolOutput = root;
            Map = map;
            Flags = flags;
       }
    }
}
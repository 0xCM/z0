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
        public CmdToolId Id {get;}

        public FS.FolderPath ToolOutput {get;}

        public IExtensionMap<F> Map {get;}

        readonly F[] Flags;

        [MethodImpl(Inline)]
        public ToolArchive(CmdToolId id, FS.FolderPath root)
        {
            Id = id;
            ToolOutput = root;
            Map = new ExtensionMap<F>(0);
            Flags = Enums.literals<F>();
        }

        public ToolArchive(CmdToolId id, FS.FolderPath root, IExtensionMap<F> map)
        {
            Id = id;
            ToolOutput = root;
            Map = map;
            Flags = Enums.literals<F>();
       }
    }
}
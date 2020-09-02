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
        public WfToolId Id {get;}

        public FolderPath ToolOutput {get;}

        public IExtensionMap<F> Map {get;}

        readonly F[] Flags;

        [MethodImpl(Inline)]
        public ToolArchive(WfToolId id, FolderPath root)
        {
            Id = id;
            ToolOutput = root;
            Map = new ExtensionMap<F>(0);
            Flags = Enums.literals<F>();
        }

        public ToolArchive(WfToolId id, FolderPath root, IExtensionMap<F> map)
        {
            Id = id;
            ToolOutput = root;
            Map = map;
            Flags = Enums.literals<F>();
       }
    }
}
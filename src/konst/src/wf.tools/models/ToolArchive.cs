//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolArchive<T> : IToolArchive<T>
        where T : struct, ITool<T>
    {
        /// <summary>
        /// The tool identifier
        /// </summary>
        public CmdHostId ToolId {get;}

        /// <summary>
        /// The archive root
        /// </summary>
        public FS.FolderPath Root {get;}

        /// <summary>
        /// The archive kind
        /// </summary>
        public ToolArchiveKind ArchiveKind {get;}

        [MethodImpl(Inline)]
        public ToolArchive(CmdHostId tool, FS.FolderPath root, ToolArchiveKind kind)
        {
            ToolId = tool;
            Root = root;
            ArchiveKind = kind;
        }
    }
}
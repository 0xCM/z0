//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    public readonly struct ToolArchive<T> : IToolArchive<T>
        where T : struct, ITool<T>
    {
        /// <summary>
        /// The tool identifier
        /// </summary>
        public WfToolId OwnerId {get;}

        /// <summary>
        /// The tool output directory
        /// </summary>
        public FS.FolderPath ToolOutput {get;}

        /// <summary>
        /// The process root folder
        /// </summary>
        public FS.FolderPath Processed {get;}

        [MethodImpl(Inline)]
        public ToolArchive(WfToolId tool, FS.FolderPath src, FS.FolderPath dst)
        {
            ToolOutput = src;
            OwnerId = tool;
            Processed = dst;
        }

        public ToolFiles<T> Dir()
            => ToolOutput.AllFiles.Map(f => new ToolFile<T>(f));

        public ToolFiles<T> Dir(string pattern)
            => ToolOutput.Files(pattern, true).Map(f => new ToolFile<T>(f));
    }
}
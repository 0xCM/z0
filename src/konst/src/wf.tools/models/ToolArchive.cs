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
        public ToolId Id {get;}

        /// <summary>
        /// The tool output directory
        /// </summary>
        public FS.FolderPath Target {get;}

        /// <summary>
        /// The process root folder
        /// </summary>
        public FS.FolderPath Processed {get;}

        [MethodImpl(Inline)]
        public ToolArchive(ToolId tool, FS.FolderPath src, FS.FolderPath dst)
        {
            Target = src;
            Id = tool;
            Processed = dst;
        }

        public ToolOutput<T> Dir()
            => Target.AllFiles.Map(Tooling.target<T>);

        public ToolOutput<T> Dir(string pattern)
            => Target.Files(pattern, true).Map(Tooling.target<T>);
    }
}
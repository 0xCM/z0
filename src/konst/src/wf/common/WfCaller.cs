//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum WfCallerField : ushort
    {
        Part,

        Name,

        File,

        FileLine
    }

    /// <summary>
    /// Captures invocation origin details
    /// </summary>
    [Table]
    public struct WfCaller : ITextual, ITable<WfCallerField,WfCaller>
    {
        /// <summary>
        /// The part from which the call originated
        /// </summary>
        public PartId Part;

        /// <summary>
        /// The originator name
        /// </summary>
        public string Name;

        /// <summary>
        /// The name of the file from which the invocation occurred
        /// </summary>
        public FS.FilePath File;

        /// <summary>
        /// The file-relative invocation line number
        /// </summary>
        public uint FileLine;

        [MethodImpl(Inline)]
        public WfCaller(PartId part, string name, FS.FilePath file, int line)
        {
            Part = part;
            Name = name;
            File = file;
            FileLine = (uint)line;
        }

        [MethodImpl(Inline)]
        public WfCaller(PartId part, string name, FS.FilePath file, uint line)
        {
            Part = part;
            Name = name;
            File = file;
            FileLine = line;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RenderPatterns.PSx4, Part.Format(), Name, FileLine, File);
    }
}
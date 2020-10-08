//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures invocation origin details
    /// </summary>
    public struct CallingMember : ITextual
    {
        /// <summary>
        /// The originator name
        /// </summary>
        public StringRef Name;

        /// <summary>
        /// The name of the file from which the invocation occurred
        /// </summary>
        public StringRef File;

        /// <summary>
        /// The file-relative invocation line number
        /// </summary>
        public uint FileLine;

        [MethodImpl(Inline)]
        public CallingMember(string name, string file, int line)
        {
            Name = name;
            File = file;
            FileLine = (uint)line;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RP.PSx3, Name, FileLine, File);

        public override string ToString()
            => Format();
    }
}
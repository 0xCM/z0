//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures invocation origin details
    /// </summary>
    public struct CallingMember : ITextual
    {
        [MethodImpl(Inline), Op]
        public static CallingMember define([CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => new CallingMember(caller, file, line ?? 0);

        [MethodImpl(Inline), Op]
        public static ref CallingMember define(ref CallingMember dst, [CallerMemberName] string name = null, [CallerLineNumber] int? line = null, [CallerFilePath] string path = null)
        {
            dst.Name = name;
            dst.File = path;
            dst.FileLine = (uint)(line ?? 0);
            return ref dst;
        }

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
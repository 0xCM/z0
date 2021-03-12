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

    /// <summary>
    /// Represents a fully-qualified path to a file on the local machine
    /// </summary>
    public class FilePath : PathComponent<FilePath>
    {
        /// <summary>
        /// Lonely, so
        /// </summary>
        public static FilePath[] None
            => Array.Empty<FilePath>();

        [MethodImpl(Inline)]
        public static FilePath Define(string name)
            => new FilePath(name);

        public static FilePath operator + (FilePath a, FileName b)
            => new FilePath(Path.Join(a.Name, b.Name));

        public static FilePath operator + (FilePath a, FolderName b)
            => new FilePath(Path.Join(a.Name, b.Name));

        public static FilePath operator + (FilePath a, FileExtension b)
            => new FilePath(Path.Join(a.Name, b.Name));

        public static FilePath operator + (FilePath a, FilePath b)
            => new FilePath(Path.Join(a.Name, b.Name));

        public FilePath(){}

        public FilePath(string name)
            : base(name)
        {

        }


        public FileName FileName
            => FileName.define(Path.GetFileName(Name));
    }
}
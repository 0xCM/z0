//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an allocated file writer that targets a specified path
    /// </summary>
    public interface IPartFileWriter : IArchiveWriter
    {
        /// <summary>
        /// The path to which the writer writes
        /// </summary>
        FS.FilePath TargetPath {get;}

        void Write(string src);

        void WriterLine(string src);

        void WriteLines(string[] src);
    }

    public interface IPartFileWriter<H> : IPartFileWriter, IArchiveWriter<H>
        where H : struct, IPartFileWriter<H>
    {
    }

    public interface IPartFileWriter<H,T> : IPartFileWriter<H>, IArchiveWriter<H,T>
        where H : struct, IPartFileWriter<H,T>
    {
    }
}
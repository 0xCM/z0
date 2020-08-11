//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFileStreamWriter : IDisposable
    {

    }
    
    /// <summary>
    /// Characterizes an allocated file writer that targets a specified path
    /// </summary>
    public interface IPartFileWriter : IFileStreamWriter
    {
        /// <summary>
        /// The path to which the writer writes
        /// </summary>
        FilePath TargetPath {get;}        

        void Write(string src);

        void WriterLine(string src);

        void WriteLines(string[] src);    
    }

    /// <summary>
    /// Characterizes a filestream writer that writes data of parametric type
    /// </summary>
    /// <typeparam name="T">The type of data the writer writes</typeparam>
    public interface IPartFileWriter<T> : IPartFileWriter
    {
        /// <summary>
        /// Write one with a line
        /// </summary>
        /// <param name="src">The one to write</param>
        void WriterLine(T src);

        /// <summary>
        /// Write one without a line
        /// </summary>
        /// <param name="src">The one to write</param>
        void Write(T src);

        /// <summary>
        /// Write many with one line for each
        /// </summary>
        /// <param name="src">The many to write</param>
        void WriteLines(T[] src);
    }
}
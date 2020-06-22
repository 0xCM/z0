//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes an allocated file writer that targets a specified path
    /// </summary>
    public interface IFileStreamWriter : IServiceAllocation
    {
        /// <summary>
        /// The path to which the writer writes
        /// </summary>
        FilePath TargetPath {get;}        
    }

    /// <summary>
    /// Characterizes a filestream writer that writes data of parametric type
    /// </summary>
    /// <typeparam name="T">The type of data the writer writes</typeparam>
    public interface IFileStreamWriter<T> : IFileStreamWriter
    {
        /// <summary>
        /// Write one
        /// </summary>
        /// <param name="src">The one to write</param>
        void Write(T src);

        /// <summary>
        /// Write many
        /// </summary>
        /// <param name="src">The many to write</param>
        void Write(T[] src);
    }
}
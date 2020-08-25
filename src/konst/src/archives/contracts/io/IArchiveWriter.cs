//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IArchiveWriter : IDisposable
    {

    }

    public interface IArchiveWriter<H> : IArchiveWriter
        where H : struct, IArchiveWriter<H>
    {

    }

    public interface IArchiveWriter<H,T> : IArchiveWriter<H>
        where H : struct, IArchiveWriter<H,T>
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
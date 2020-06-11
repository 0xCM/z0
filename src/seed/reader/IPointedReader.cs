//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IPointedReader
    {
        /// <summary>
        /// The current position of the stream
        /// </summary>
        int Position {get;}
 
        /// <summary>
        /// Spefifies whether the reader can advance to and read the next cell
        /// </summary>
        bool HasNext {get;}

        /// <summary>
        /// Spefifies the length of the data soruce
        /// </summary>
        int Length {get;}

        /// <summary>
        /// Spefifies the number of elements that remain to be read
        /// </summary>
        int Remaining {get;}

        /// <summary>
        /// If source value pos is within the range [0,Length), assigns Current = pos;
        /// otherwise, assigns Current = -1 and returns true if the former and false if the latter
        /// </summary>
        /// <param name="pos">The desired reader position</param>
        bool Seek(uint pos);
    }
    
    public interface IPointedReader<T> : IPointedReader
        where T : unmanaged
    {
        /// <summary>
        /// Deposits the next value in a caller-supplied target and returns true if there are yet more values to read
        /// </summary>
        /// <param name="dst">The value of the next byte</param>
        bool Read(ref T dst);

        /// <summary>
        /// Reads a specified number of elements if they exist or fewer if not and deposits the values in a caller-suppled target
        /// Returns the actual number of elements read
        /// </summary>
        /// <param name="offset">The offset at which to begin reading</param>
        /// <param name="wantedCount">The number of desired</param>
        /// <param name="dst">The target buffer</param>
        int Read(int offset, int wantedCount, Span<T> dst);
    }
}
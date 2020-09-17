//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Identifies a value partition element
    /// </summary>
    public interface IBitFieldSegment
    {
        /// <summary>
        /// A unique name that identifies the segment
        /// </summary>
        string Name {get;}
    }

    /// <summary>
    /// Characterizes an element within a field partition
    /// </summary>
    /// <typeparam name="T">The field type over which a partition is defined</typeparam>
    public interface IBitFieldSegment<T> : IBitFieldSegment
        where T : unmanaged
    {
        /// <summary>
        /// The first index of the segment, relative to the source field
        /// </summary>
        T StartPos {get;}

        /// <summary>
        /// The last index of the segment, relative to the source field
        /// </summary>
        T EndPos {get;}

        /// <summary>
        /// The number of bits in the segment
        /// </summary>
        T Width {get;}
    }

    public interface IBitFieldSegment<F,T> : IBitFieldSegment<T>
        where T : unmanaged
        where F : unmanaged, IBitFieldSegment<F,T>
    {

    }
}
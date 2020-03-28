//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;    

    public static class FixedSegment
    {
        public static FixedSegment<I,W,T> from<I,W,T>(I index, int first, int last, W width)
            where T: unmanaged, IFixed
            where I: unmanaged, Enum
            where W: unmanaged, Enum
                => new FixedSegment<I,W,T>(index.ToString(), index, first, last, width);
    }
    
    public readonly struct FixedSegment<I,W,T>
        where T: unmanaged, IFixed
        where I: unmanaged, Enum
        where W: unmanaged, Enum
    {
        /// <summary>
        /// A unique name that can be used as an alternate segment identifier
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The segment identifier
        /// </summary>
        public I Index {get;}

        /// <summary>
        /// The first index of the segment, relative to the source field
        /// </summary>
        public int StartPos {get;}

        /// <summary>
        /// The last index of the segment, relative to the source field
        /// </summary>
        public int EndPos {get;}

        /// <summary>
        /// The number of bits in the segment
        /// </summary>
        public W Width {get;}

        [MethodImpl(Inline)]
        internal FixedSegment(string name, I index,  int first, int last, W width)
        {
            this.Index = index;
            this.Name = name;
            this.StartPos = first;
            this.EndPos = last;
            this.Width = width;
        }
    }
}
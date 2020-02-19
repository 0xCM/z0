//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    public interface IBitFieldSegment : ICustomFormattable
    {
        /// <summary>
        /// The 0-based and monotonically increasing segment identifier
        /// </summary>
        byte Index {get;}

        /// <summary>
        /// A unique name that can be used as an alternate segment identifier
        /// </summary>
        string Name {get;}

        /// <summary>
        /// The first index of the segment, relative to the source field
        /// </summary>
        byte StartPos {get;}

        /// <summary>
        /// The last index of the segment, relative to the source field
        /// </summary>
        byte EndPos {get;}

        /// <summary>
        /// The number of bits in the segment
        /// </summary>
        byte Width
        {
            [MethodImpl(Inline)]
            get => (byte)(EndPos - StartPos + 1);
        }
    }
}
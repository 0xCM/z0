//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies operations of the form source -> target:IRenderBuffer
    /// </summary>
    public class PositionAttribute : Attribute
    {
        /// <summary>
        /// Specifies a linear position relative to an optionally-specified origin
        /// </summary>
        public long Position {get;}

        public long Origin {get;}

        public PositionAttribute(long position)
        {
            Position = position;
        }

        public PositionAttribute(long origin, long position)
        {
            Origin = origin;
            Position = position;
        }
    }
}
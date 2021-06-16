//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a segment of a number-identified line
    /// </summary>
    public readonly struct LineSegment
    {
        public LineNumber LineNumber {get;}

        public ushort MinCol {get;}

        public ushort MaxCol {get;}

        [MethodImpl(Inline)]
        public LineSegment(uint line, ushort min, ushort max)
        {
            LineNumber = line;
            MinCol = min;
            MaxCol = max;
        }
    }
}
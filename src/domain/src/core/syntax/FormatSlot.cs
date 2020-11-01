//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct FormatSlot
    {
        readonly ClosedInterval<uint> Range;

        public string Pattern {get;}

        [MethodImpl(Inline)]
        internal FormatSlot(string src, ClosedInterval<uint> range)
        {
            Pattern = src;
            Range = range;


        }

        public uint StartPos
        {
            [MethodImpl(Inline)]
            get => Range.Min;
        }

        public uint EndPos
        {
            [MethodImpl(Inline)]
            get => Range.Max;
        }

        public string InnerText
        {
            [MethodImpl(Inline)]
            get => text.segment(Pattern, StartPos + 1, EndPos - 1);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Range.IsEmpty || text.empty(Pattern);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public static FormatSlot Empty
            => new FormatSlot(EmptyString, ClosedInterval<uint>.Empty);
    }
}
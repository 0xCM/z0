//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum BenchmarkField : uint
    {
        OpId = 0 | (50 << WidthOffset),

        OpCount = 1 | (12 << WidthOffset),

        Timing = 2 | (12 << WidthOffset),
    }

    /// <summary>
    /// Defines a benchmark measure for an operator
    /// </summary>
    public readonly struct BenchmarkRecord : ITabular<BenchmarkField, BenchmarkRecord>, IComparable<BenchmarkRecord>, IComparable
    {
        /// <summary>
        /// The name of the measured operation
        /// </summary>
        public readonly OpIdentity OpId;

        /// <summary>
        /// Either the invocation count or the number of discrete operations performed
        /// </summary>
        public readonly long OpCount;

        /// <summary>
        /// The measured time
        /// </summary>
        public readonly Duration Timing;

        public static BenchmarkRecord Empty => new BenchmarkRecord(0, Duration.Zero,string.Empty);

        [MethodImpl(Inline)]
        public static BenchmarkRecord Capture(OpIdentity op, long opcount, in SystemCounter clock)
            => new BenchmarkRecord(op, opcount, clock.Elapsed);

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord(in (OpIdentity op, long opcount, SystemCounter clock)  src)
            => Capture(src.op,src.opcount, src.clock);

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord((string opName, long opCount, SystemCounter clock) src)
            => Capture(OpIdentity.define(src.opName), src.opCount, src.clock);

        [MethodImpl(Inline)]
        public static BenchmarkRecord Define(long count, Duration timing, string label)
            => new BenchmarkRecord(OpIdentity.define(label), count, timing);

        [MethodImpl(Inline)]
        BenchmarkRecord(OpIdentity id, long opcount, Duration elapsed)
        {
            this.OpId = id;
            this.OpCount = opcount;
            this.Timing = elapsed;
        }

        [MethodImpl(Inline)]
        BenchmarkRecord(long count, Duration timing, string Label)
        {
            this.OpId = OpIdentity.define(Label ?? "?");
            this.OpCount = count;
            this.Timing = timing;
        }

        const int OpNamePad = 30;

        const int OpCountPad = 15;

        public string Format(int? labelPad = null)
            => $"{OpId}".PadRight(labelPad ?? OpNamePad) + $" | Ops = {OpCount} " + $"| Time = {Timing}";

        string ITabular.DelimitedText(char delimiter)
            => text.concat(
                $"{text.format(OpId).PadRight(OpNamePad)}{delimiter}{Chars.Space}",
                 OpCount.ToString("#,#").PadRight(OpCountPad),  $"{delimiter}{Chars.Space}",
                $"{Timing.Ms}");

        public IReadOnlyList<string> GetHeaders()
            => new string[]{nameof(OpId).PadRight(OpNamePad),
                Chars.Space + nameof(OpCount).PadRight(OpCountPad),
                Chars.Space + nameof(Timing),
                };

        public override string ToString()
            => Format();

        public int CompareTo(BenchmarkRecord other)
            => OpId.Identifier.CompareTo(other.OpId.Identifier);

        public int CompareTo(object obj)
            => obj is BenchmarkRecord r ? CompareTo(r) : -1;
    }
}
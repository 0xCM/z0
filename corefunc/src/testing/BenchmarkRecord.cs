//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    /// <summary>
    /// Defines a benchmark measure for an operator
    /// </summary>
    public readonly struct BenchmarkRecord : IRecord<BenchmarkRecord>, IComparable<BenchmarkRecord>, IComparable
    {
        public static BenchmarkRecord Empty => new BenchmarkRecord(0, Duration.Zero,string.Empty);

        [MethodImpl(Inline)]   
        public static BenchmarkRecord Capture(OpIdentity op, long opcount, in SystemCounter clock) 
            => new BenchmarkRecord(op, opcount, clock.Elapsed);

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord(in (OpIdentity op, long opcount, SystemCounter clock)  src)
            => Capture(src.op,src.opcount, src.clock);

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord((string opName, long opCount, SystemCounter clock) src)
            => Capture(OpIdentity.Define(src.opName), src.opCount, src.clock);        

        [MethodImpl(Inline)]
        public static BenchmarkRecord Define(long count, Duration timing, string label)
            => new BenchmarkRecord(OpIdentity.Define(label), count, timing);


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
            this.OpId = OpIdentity.Define(Label ?? "?");
            this.OpCount = count;
            this.Timing = timing;
        }            

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

        const int OpNamePad = 30;

        const int OpCountPad = 15;

        public string Format(int? labelPad = null)
            => $"{OpId}".PadRight(labelPad ?? OpNamePad) + $" | Ops = {OpCount} " + $"| Time = {Timing}";
        
        string IRecord.DelimitedText(char delimiter)
            => concat(
                $"{OpId.Format().PadRight(OpNamePad)}{delimiter}{AsciSym.Space}",  
                 OpCount.ToString("#,#").PadRight(OpCountPad),  $"{delimiter}{AsciSym.Space}",
                $"{Timing.Ms}");

        public IReadOnlyList<string> GetHeaders()
            => new string[]{    nameof(OpId).PadRight(OpNamePad), 
                AsciSym.Space + nameof(OpCount).PadRight(OpCountPad), 
                AsciSym.Space + nameof(Timing),
                };

        public override string ToString()
            => Format();

        public int CompareTo(BenchmarkRecord other)
            => OpId.CompareTo(other.OpId);

        public int CompareTo(object obj)
            => obj is BenchmarkRecord r ? CompareTo(r) : -1;

    }
}
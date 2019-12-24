//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using static zfunc;

    /// <summary>
    /// Defines a benchmark measure for an operator
    /// </summary>
    public readonly struct BenchmarkRecord : IRecord<BenchmarkRecord>
    {
        public static readonly BenchmarkRecord Zero = new BenchmarkRecord(0, Duration.Zero,string.Empty);
        
        [MethodImpl(Inline)]
        public static implicit operator (long OpCount, Duration WorkTime, string Label)(BenchmarkRecord src)
            => (src.OpCount, src.Timing,src.Operation);

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord((long OpCount, Duration WorkTime) src)
            => Define(src.OpCount, src.WorkTime);        

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord((string opName, long opCount, SystemCounter tickCount) src)
            => Define(src.opName, src.opCount, src.tickCount);        

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord((long OpCount, Duration WorkTime, string Label) src)
            => Define(src.OpCount, src.WorkTime, src.Label);        

        [MethodImpl(Inline)]
        public static implicit operator BenchmarkRecord((long OpCount, Stopwatch sw, string Label) src)
            => Define(src.OpCount, snapshot(src.sw), src.Label);        

        [MethodImpl(Inline)]
        public static BenchmarkRecord Define(long count, Duration timing, string label = null)
            => new BenchmarkRecord(count, timing, label);

        [MethodImpl(Inline)]
        public static BenchmarkRecord Define(string name, long count, TimeSpan timing)
            => new BenchmarkRecord(count, timing, name);

        [MethodImpl(Inline)]
        public BenchmarkRecord(long count, Duration timing, string Label)
        {
            this.Operation = Label ?? "?";
            this.OpCount = count;
            this.Timing = timing;
        }            

        /// <summary>
        /// The name of the measured operation
        /// </summary>
        public readonly string Operation;

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
            => $"{Operation}".PadRight(labelPad ?? OpNamePad) + $" | Ops = {OpCount} " + $"| Time = {Timing}";
        
        string IRecord.DelimitedText(char delimiter)
            => concat(
                $"{Operation.PadRight(OpNamePad)}{delimiter}{AsciSym.Space}",  
                 OpCount.ToString("#,#").PadRight(OpCountPad),  $"{delimiter}{AsciSym.Space}",
                $"{Timing.Ms}");

        public IReadOnlyList<string> GetHeaders()
            => new string[]{    nameof(Operation).PadRight(OpNamePad), 
                AsciSym.Space + nameof(OpCount).PadRight(OpCountPad), 
                AsciSym.Space + nameof(Timing),
                };

        public override string ToString()
            => Format();
    }
}
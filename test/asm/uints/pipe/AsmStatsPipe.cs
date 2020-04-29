//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmStats : IFormattable<AsmStats>
    {
        public readonly int FunctionCount;
        
        [MethodImpl(Inline)]
        internal AsmStats(int FunctionCount)
        {
            this.FunctionCount = FunctionCount;
        }

        public string Format()
            => text.concat(nameof(FunctionCount), text.spaced(Chars.Eq), FunctionCount.ToString());
        
        public override string ToString() 
            => Format();
    }

    public struct AsmStatsCollector
    {
        int FunctionCount;
        
        [MethodImpl(Inline)]
        public void IncrementFunctionCount()
        {
            FunctionCount++;
        }

        /// <summary>
        /// Retrieves the collection statistics
        /// </summary>
        public AsmStats Collected
            => new AsmStats(FunctionCount);
    }
}
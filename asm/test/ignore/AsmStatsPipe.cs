//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public readonly struct AsmStats
    {
        [MethodImpl(Inline)]
        public static AsmStats Create(int FunctionCount)
            => new AsmStats(FunctionCount);
        
        [MethodImpl(Inline)]
        AsmStats(int FunctionCount)
        {
            this.FunctionCount = FunctionCount;
        }

        public readonly int FunctionCount;

        public override string ToString() 
        {
            return text.concat(nameof(FunctionCount), text.spaced(Chars.Eq), FunctionCount.ToString());
        }
    }

    class AsmStatsCollector
    {
        int FunctionCount;
        
        public AsmStatsCollector IncrementFunctionCount()
        {
            FunctionCount++;
            return this;
        }

        /// <summary>
        /// Retrieves the collection statistics
        /// </summary>
        public AsmStats Collected
            => AsmStats.Create(FunctionCount);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;

    using Z0.AsmSpecs;

    using static zfunc;

    public class AsmStats
    {
        public int FunctionCount {get;set;}

        public override string ToString() 
        {
            return concat(nameof(FunctionCount), spaced(AsciSym.Eq), FunctionCount.ToString());
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
            => new AsmStats
            {
                FunctionCount = FunctionCount,
            };
    }

    readonly struct AsmStatsPipe : IAsmFunctionPipe
    {
        public static IAsmFunctionPipe Create(AsmStatsCollector dst)
            => new AsmStatsPipe(dst);

        readonly AsmStatsCollector Target;
        
        AsmStatsPipe(AsmStatsCollector dst)
        {
            this.Target = dst;
        }
        
        public AsmFunction Flow(AsmFunction f)
        {
            Target.IncrementFunctionCount();    
            return f;
        }
    }

}
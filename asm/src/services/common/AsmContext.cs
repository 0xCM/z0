//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public sealed class AsmContext : OpContext<AsmContext>, IAsmContext
    {   
        public static AsmContext Define(AsmFormatConfig format)             
            => new AsmContext(format,Rng.WyHash64(Seed64.Seed10));
        
        AsmContext(AsmFormatConfig format, IPolyrand random)
            : base(random)            
        {
            this.FormatConfig = format;
        }

        public AsmFormatConfig FormatConfig {get;}
    }   
}
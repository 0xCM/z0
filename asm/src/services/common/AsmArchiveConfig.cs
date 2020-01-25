//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static zfunc;

    public readonly struct AsmArchiveConfig
    {
        public static AsmArchiveConfig Default => Define(false);

        public static AsmArchiveConfig Define(bool SingleFile)
            => new AsmArchiveConfig(SingleFile);

        public AsmArchiveConfig(bool SingleFile)
        {
            this.SingleFile = SingleFile;
        }
        
        public readonly bool SingleFile;
    }
}
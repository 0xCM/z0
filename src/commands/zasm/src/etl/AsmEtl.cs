//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using M = AsmDataModels;

    public partial class AsmEtl : IAsmEtl
    {
        public static AsmEtl Service => new AsmEtl();

        public static M.OpCodes OpCodes 
            => M.OpCodes.Model;

        public static M.Instructions Instructions 
            => M.Instructions.Model;
    }
}
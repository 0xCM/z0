//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;
    using static OpKind;

	partial class ModelQueries
    {
        public static Option<AsmBranchInfo> BranchInfo(this Instruction src, int index, ulong baseaddress)
        {
            var kind = src.GetOpKind(index);
            if(kind.IsBranch())
            {
                switch(kind)
                {
                    case NearBranch16:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch16, 16, true);
                    case NearBranch32:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch32, 32, true);
                    case NearBranch64:
                        return AsmBranchInfo.Define(baseaddress, src.NearBranch64, 64, true);
                    case FarBranch16:
                        return AsmBranchInfo.Define(baseaddress, src.FarBranch16, 16,  false);
                    case FarBranch32:
                        return AsmBranchInfo.Define(baseaddress, src.FarBranch32, 32, false);
                }
            }

            return none<AsmBranchInfo>();
        }
    }
}
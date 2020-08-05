//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static Konst;
    
    partial struct asm
    {        
        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(in MemoryAddress @base, in Instruction inxs, in AsmBranchTarget target)
            => new AsmBranchInfo(inxs, @base, inxs.IP, target, offset(inxs.IP, (byte)inxs.ByteLength, target.TargetAddress));

        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(in MemoryAddress @base, in Instruction src, int index)
            => branch(@base, src, branchTarget(src,index));                    
    }
}
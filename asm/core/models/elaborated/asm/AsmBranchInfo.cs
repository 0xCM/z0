//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Describes a branching instruction operand
    /// </summary>
    public class AsmBranchInfo
    {
        public static AsmBranchInfo Define(int size, ulong target, bool near, ulong baseaddress)
            => new AsmBranchInfo(size,target,near, baseaddress);
        
        AsmBranchInfo(int size, ulong target, bool near, ulong baseaddress)
        {
            this.Size = size;
            this.TargetAddress = target;
            this.Near = near;
            this.BaseAddress = baseaddress;
        }

        public int Size {get;}

        public bool Near {get;}
        
        public ulong TargetAddress {get;}

        public ulong BaseAddress {get;}

        public ulong LocalAddress 
            => Near ? TargetAddress - BaseAddress : TargetAddress;

        public string Label
            => LocalAddress.FormatAsmHex();
    }
}
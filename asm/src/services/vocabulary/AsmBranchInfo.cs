//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Describes a branching instruction operand
    /// </summary>
    public class AsmBranchInfo
    {
        public static AsmBranchInfo Define(int size, ulong value, bool near)
            => new AsmBranchInfo(size,value,near);
        
        AsmBranchInfo(int size, ulong value, bool near)
        {
            this.Size = size;
            this.Target = value;
            this.Near = near;
        }

        public int Size {get;}

        public bool Near {get;}
        
        public ulong Target {get;}

        /// <summary>
        /// Specifies a label for the immedate that has the form jmp{BitWidth}
        /// </summary>
        public string Label
            => $"jmp{Size}";

    }

}
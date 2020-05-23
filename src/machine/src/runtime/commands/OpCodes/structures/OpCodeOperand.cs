//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
 
    public readonly struct OpCodeOperand
    {
        readonly ushort Data;        
        
        [MethodImpl(Inline)]
        public OpCodeOperand(ushort data)
        {
            this.Data = data;
        }       
    }
}
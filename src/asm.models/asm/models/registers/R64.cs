//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;

    public readonly struct R64 : IRegOperand64
    {    
        readonly Vector128<ulong> Data;
        
        public ulong Content
        {
            [MethodImpl(Inline)]
            get => vcell(Data, 0);
        }

        public RegisterKind Kind 
        {
            get => (RegisterKind)vcell(Data,1);
        }
        
        [MethodImpl(Inline)]
        public R64(ulong value, RegisterKind kind)
            => Data = vparts(value, (ulong)kind);
    }   
}
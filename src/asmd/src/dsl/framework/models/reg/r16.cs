//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static math;

    public readonly struct r16 : IRegOperand16
    {    
        public readonly ulong Data;

        public ushort Content  
        {
            [MethodImpl(Inline)]
            get => (ushort)Data;
        }
    
        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => (RegisterKind)srl(Data, 32);
        }

        [MethodImpl(Inline)]
        public r16(ushort value, RegisterKind kind)
            => Data = or((ulong)value, sll((ulong)kind, 32));
    } 
}
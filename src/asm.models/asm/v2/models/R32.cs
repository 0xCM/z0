//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static math;

    public readonly struct R32 : IRegOperand32
    {   
        readonly ulong Data;

        public uint Content
        {
            [MethodImpl(Inline)]
            get => (uint)Data;
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => (RegisterKind)srl(Data, 32);
        }

        [MethodImpl(Inline)]
        public R32(uint value, RegisterKind kind)
            => Data = or((ulong)value, sll((ulong)kind, 32));
    } 
}
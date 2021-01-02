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

    /// <summary>
    /// Defines a 16-bit register and its content
    /// </summary>
    public readonly struct R16 : IRegister<R16,W16,ushort>
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
        public R16(ushort value, RegisterKind kind)
            => Data = or((ulong)value, sll((ulong)kind, 32));

        public RegisterClass Class
            => RegisterClass.GP;
    }
}
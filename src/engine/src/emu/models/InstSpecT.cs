//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct InstSpec<T>
        where T : unmanaged
    {
        readonly T Data;

        internal InstSpec(T data)
        {
            Data = data;
        }

        public OpCode<T> OpCode
        {
            get => default;
        }

        public byte OperandCount
        {
            get => default;
        }

        public ReadOnlySpan<byte> Operand(byte index)
        {
            return default;
        }
    }
}
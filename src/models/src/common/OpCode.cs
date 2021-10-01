//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct OpCode
    {
        readonly uint Data;

        [MethodImpl(Inline)]
        public OpCode(byte table, ushort op)
        {
            Data = (uint)table |((uint)op <<8);
        }

        public byte Table
        {
            [MethodImpl(Inline)]
            get => (byte)Table;
        }

        public ushort Value
        {
            [MethodImpl(Inline)]
            get => (ushort)(Data >>8);
        }
    }
}
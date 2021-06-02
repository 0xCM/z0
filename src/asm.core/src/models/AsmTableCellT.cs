//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum AsmCellKind : byte
    {
        None = 0,

        Sequence,

        GlobalOffset,

        BlockAddress,

        IP,

        BlockOffset,

        Expression,

        EncodedBytes,

        FormSig,

        OpCode,

        EncodedBits,

        OpUri,
    }

    public readonly struct AsmTableCell<T>
    {
        public byte Position {get;}

        public T Content {get;}

        public AsmCellKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmTableCell(byte pos, T data, AsmCellKind kind)
        {
            Content = data;
            Position = pos;
            Kind = kind;
        }
    }
}
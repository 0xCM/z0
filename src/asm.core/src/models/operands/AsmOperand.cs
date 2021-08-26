//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct AsmOperand : IAsmOperand
    {
        public AsmOpClass OpClass {get;}

        public AsmSize Size {get;}

        ByteBlock10 _Data {get;}

        [MethodImpl(Inline)]
        public AsmOperand(AsmOpClass opclass, AsmSize size)
        {
            OpClass = opclass;
            Size = size;
            _Data = default;
        }

        [MethodImpl(Inline)]
        public AsmOperand(AsmOpClass opclass, AsmSize size, ByteBlock10 data)
        {
            OpClass = opclass;
            Size = size;
            _Data = data;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => _Data.Bytes;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand<ByteBlock10>(AsmOperand src)
            =>  new AsmOperand<ByteBlock10>(src.OpClass, src.Size, src._Data);
    }
}
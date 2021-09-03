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

        public NativeSize Size {get;}

        ByteBlock10 _Data {get;}

        [MethodImpl(Inline)]
        internal AsmOperand(AsmOpClass opclass, NativeSize size)
        {
            OpClass = opclass;
            Size = size;
            _Data = default;
        }

        [MethodImpl(Inline)]
        internal AsmOperand(RegOp src)
        {
            OpClass = AsmOpClass.R;
            Size = src.RegWidth;
            _Data = core.u16(src);
        }

        [MethodImpl(Inline)]
        internal AsmOperand(imm8 src)
        {
            OpClass = AsmOpClass.Imm;
            Size = NativeWidthCode.W8;
            _Data = (byte)src;
        }

        [MethodImpl(Inline)]
        internal AsmOperand(imm16 src)
        {
            OpClass = AsmOpClass.Imm;
            Size = NativeWidthCode.W16;
            _Data = (ushort)src;
        }

        [MethodImpl(Inline)]
        internal AsmOperand(imm32 src)
        {
            OpClass = AsmOpClass.Imm;
            Size = NativeWidthCode.W32;
            _Data = (uint)src;
        }

        [MethodImpl(Inline)]
        internal AsmOperand(imm64 src)
        {
            OpClass = AsmOpClass.Imm;
            Size = NativeWidthCode.W64;
            _Data = (ulong)src;
        }

        [MethodImpl(Inline)]
        internal AsmOperand(AsmAddress src)
        {
            OpClass = AsmOpClass.M;
            Size = src.AddressSize;
            _Data = core.@as<AsmAddress,ByteBlock10>(src);
        }

        [MethodImpl(Inline)]
        internal AsmOperand(AsmOpClass opclass, NativeSize size, ByteBlock10 data)
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

        public bit IsEmpty
        {
            [MethodImpl(Inline)]
            get => OpClass == 0;
        }

        public bit IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => OpClass == 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand(RegOp src)
            => new AsmOperand(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand(AsmAddress src)
            => new AsmOperand(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand(imm8 src)
            => new AsmOperand(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand(imm16 src)
            => new AsmOperand(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand(imm32 src)
            => new AsmOperand(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand(imm64 src)
            => new AsmOperand(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand<ByteBlock10>(AsmOperand src)
            =>  new AsmOperand<ByteBlock10>(src.OpClass, src.Size, src._Data);
    }
}
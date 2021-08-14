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
    using static core;

    [StructLayout(LayoutKind.Sequential, Pack=1, Size =(int)SZ), Blittable(SZ)]
    public struct AsmOpCode
    {
        public const uint SZ = 2*PrimalSizes.U16 + PrimalSizes.U32;

        ushort Kind;

        ushort Literal;

        uint Field;

        [MethodImpl(Inline)]
        public AsmOpCode(ushort literal, uint field)
        {
            Kind = 0;
            Literal = literal;
            Field = field;
        }

        public ref byte Lead
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes,0);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Field == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Field != 0;
        }

        Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Field),0, 3);
        }

        public static AsmOpCode Empty
            => default;
    }
}
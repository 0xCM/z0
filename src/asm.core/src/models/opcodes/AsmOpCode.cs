//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.llvm;

    using static Root;
    using static core;

    [StructLayout(LayoutKind.Sequential, Pack=1, Size =(int)SZ), Blittable(SZ)]
    public struct AsmOpCode
    {
        public const uint SZ = 2*PrimalSizes.U16 + PrimalSizes.U32;

        public ushort SdmKey;

        public MC.AsmId AsmId;

        public uint Encoding;

        [MethodImpl(Inline)]
        public AsmOpCode(ushort key, MC.AsmId asmid, uint encoding)
        {
            AsmId = 0;
            SdmKey = key;
            Encoding = encoding;
        }

        public ref byte Lead
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes,0);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoding == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoding != 0;
        }

        Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Encoding),0, 3);
        }

        public static AsmOpCode Empty
            => default;
    }
}
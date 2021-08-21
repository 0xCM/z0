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
    using static AsmOpCodeTokens;

    using api = AsmOpCodes;

    [StructLayout(LayoutKind.Sequential, Pack=1, Size =(int)SZ), Blittable(SZ)]
    public struct AsmOpCode
    {
        public const uint SZ = 2*PrimalSizes.U16 + PrimalSizes.U32 + CharBlock48.SZ;

        public ushort SdmKey;

        public McAsmId AsmId;

        public uint Encoding;

        public CharBlock48 Expr;

        [MethodImpl(Inline)]
        public AsmOpCode(ushort key, McAsmId asmid, uint encoding, CharBlock48 expr)
        {
            AsmId = 0;
            SdmKey = key;
            Encoding = encoding;
            Expr = expr;
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

        public bit Rex
        {
            [MethodImpl(Inline)]
            get => api.rex(Expr.String);
        }

        public bit RexW
        {
            get
            {
                if(api.rex(Expr.String, out var x))
                    return x == RexToken.RexW;
                else
                    return false;
            }
        }

        public string Format()
            => Expr.Format();

        public override string ToString()
            => Format();

        public static AsmOpCode Empty
            => default;
    }
}
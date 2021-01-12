//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /*
    ; Byte[] alloc<byte>(long count)::located://part/sys.proxy?alloc#alloc_g[8u](64i)
    ; public static ReadOnlySpan<byte> alloc_gᐸ8uᐳᐤ64iᐤ => new byte[29]{0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0xd1,0x48,0xb9,0x18,0xea,0x10,0x5b,0xfc,0x7f,0x00,0x00,0xe8,0x19,0x79,0xa6,0x5c,0x90,0x48,0x83,0xc4,0x28,0xc3};
    ; BaseAddress = 7ffc5e1eff50h
    ; TermCode = CTC_RET_Zx3
    */
    public struct AsmBlockHeader
    {
        public OpUri Uri;

        public string OpSig;

        public string DataProp;

        public MemoryAddress BaseAddress;

        public ExtractTermCode TermCode;

        [MethodImpl(Inline)]
        public AsmBlockHeader(OpUri uri, string sig, string prop, MemoryAddress @base, ExtractTermCode term)
        {
            Uri = uri;
            OpSig = sig;
            DataProp = prop;
            BaseAddress = @base;
            TermCode = term;
        }
    }
}
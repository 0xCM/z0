//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct AsmCaseCode
    {
        [ApiComplete("casecode.callrel32")]
        public readonly ref struct CallRel32
        {
            readonly ReadOnlySpan<byte> A;

            readonly ReadOnlySpan<ushort> B;

            readonly ReadOnlySpan<uint> C;

            readonly ReadOnlySpan<ulong> D;

            readonly Span<ulong> R;

            public void Run(int i)
            {
                seek(R,i) = (ulong)f0(skip(A,i)) & f1(skip(B,i)) | f2(skip(C,i)) ^ f3(skip(D,i)) ;
            }

            [MethodImpl(NotInline)]
            public byte f0(byte a)
                => (byte)(a & 0xF0);

            [MethodImpl(NotInline)]
            public ushort f1(ushort b)
                => (ushort)(b & 0xF0F0);

            [MethodImpl(NotInline)]
            public uint f2(uint c)
                => (uint)(c & 0xF0F0F0F0);

            [MethodImpl(NotInline)]
            public ulong f3(ulong d)
                => (ulong)(d & 0xF0F0F0F0F0F0F0F0);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 210210
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;


    using static AsmDsl;

    public unsafe readonly ref struct XmmRegSlots
    {
        public static void render(in XmmRegSlots src, ITextBuffer dst)
        {
            var count = src.CellCount;
            ref var lead = ref src.First;
            var @base = address(lead);
            for(var i=0; i<count; i++)
            {
                var address = skip(@base,i);
                var offset = address - @base;
                var reg = skip(lead,i);
                dst.AppendLine(string.Format(RP.PSx3, address, offset, reg.Kind));
            }
        }

        public const uint CellSize = 16;

        readonly Span<Cell128> Buffer;

        public readonly byte CellCount;

        public readonly uint BankSize;

        [MethodImpl(Inline)]
        public static XmmRegSlots Create(N16 n)
            => new XmmRegSlots(16);

        [MethodImpl(Inline)]
        XmmRegSlots(byte count)
        {
            CellCount = count;
            Buffer = new Cell128[count];
            BankSize = CellSize*CellCount;
        }

        ref Cell128 First
        {
            [MethodImpl(Inline)]
            get => ref seek(Buffer, 0);
        }

        public ref Cell128 this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref seek(First, index);
        }

        public ref xmm0 xmm0
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm0>(seek(First, xmm0.Index));
        }

        public ref xmm1 xmm1
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm1>(seek(First, xmm1.Index));
        }

        public ref xmm2 xmm2
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm2>(seek(First, xmm2.Index));
        }

        public ref xmm3 xmm3
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm3>(seek(First, xmm3.Index));
        }

        public ref xmm4 xmm4
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm4>(seek(First, xmm4.Index));
        }

        public ref xmm5 xmm5
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm5>(seek(First, xmm5.Index));
        }

        public ref xmm6 xmm6
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm6>(seek(First, xmm6.Index));
        }

        public ref xmm7 xmm7
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm7>(seek(First, xmm7.Index));
        }

        public ref xmm8 xmm8
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm8>(seek(First, xmm8.Index));
        }

        public ref xmm9 xmm9
        {
            [MethodImpl(Inline)]
            get => ref @as<Cell128,xmm9>(seek(First, xmm9.Index));
        }
    }
}
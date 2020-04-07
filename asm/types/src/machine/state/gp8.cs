//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Registers;

    partial struct CpuState
    {
        public ref al al
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<al>(), al.Index*8);
        }

        public ref cl cl
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<cl>(), cl.Index*8);
        }

        public ref dl dl
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<dl>(), dl.Index*8);
        }

        public ref bl bl
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<bl>(), bl.Index*8);
        }

        public ref sil sil
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<sil>(), sil.Index*8);
        }

        public ref dil dil
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<dil>(), dil.Index*8);
        }

        public ref spl spl
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<spl>(), spl.Index*8);
        }

        public ref bpl bpl
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<bpl>(), bpl.Index*8);
        }

        public ref r8b rb8
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<r8b>(), r8b.Index*8);
        }

        public ref r9b rb9
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(gp<r9b>(), r9b.Index*8);
        }
    }
}
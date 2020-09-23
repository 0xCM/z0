//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Asm.Dsl;

    partial struct AsmSink
    {
        [MethodImpl(Inline), Op]
        public static al set(byte src,  al dst)
            => new al(src);

        [MethodImpl(Inline), Op]
        public static cl set(byte src,  cl dst)
            => new cl(src);

        [MethodImpl(Inline), Op]
        public static dl set(byte src,  dl dst)
            => new dl(src);

        [MethodImpl(Inline), Op]
        public static bl set(byte src,  bl dst)
            => new bl(src);

        [MethodImpl(Inline), Op]
        public static sil set(byte src,  sil dst)
            => new sil(src);

        [MethodImpl(Inline), Op]
        public static dil set(byte src,  dil dst)
            => new dil(src);

        [MethodImpl(Inline), Op]
        public static spl set(byte src,  spl dst)
            => new spl(src);

        [MethodImpl(Inline), Op]
        public static bpl set(byte src,  bpl dst)
            => new bpl(src);

        [MethodImpl(Inline), Op]
        public static r8b set(byte src,  r8b dst)
            => new r8b(src);

        [MethodImpl(Inline), Op]
        public static r9b set(byte src,  r9b dst)
            => new r9b(src);

        [MethodImpl(Inline), Op]
        public static r10b set(byte src,  r10b dst)
            => new r10b(src);

        [MethodImpl(Inline), Op]
        public static r11b set(byte src,  r11b dst)
            => new r11b(src);

        [MethodImpl(Inline), Op]
        public static r12b set(byte src,  r12b dst)
            => new r12b(src);

        [MethodImpl(Inline), Op]
        public static r13b set(byte src,  r13b dst)
            => new r13b(src);

        [MethodImpl(Inline), Op]
        public static r14b set(byte src,  r14b dst)
            => new r14b(src);

        [MethodImpl(Inline), Op]
        public static r15b set(byte src,  r15b dst)
            => new r15b(src);
    }

}
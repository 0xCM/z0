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
        public static ax set(ushort src,  ax dst)
            => new ax(src);

        [MethodImpl(Inline), Op]
        public static cx set(ushort src,  cx dst)
            => new cx(src);

        [MethodImpl(Inline), Op]
        public static dx set(ushort src,  dx dst)
            => new dx(src);

        [MethodImpl(Inline), Op]
        public static bx set(ushort src,  bx dst)
            => new bx(src);

        [MethodImpl(Inline), Op]
        public static si set(ushort src,  si dst)
            => new si(src);

        [MethodImpl(Inline), Op]
        public static di set(ushort src,  di dst)
            => new di(src);

        [MethodImpl(Inline), Op]
        public static sp set(ushort src,  sp dst)
            => new sp(src);

        [MethodImpl(Inline), Op]
        public static bp set(ushort src,  bp dst)
            => new bp(src);

        [MethodImpl(Inline), Op]
        public static r8w set(ushort src,  r8w dst)
            => new r8w(src);

        [MethodImpl(Inline), Op]
        public static r9w set(ushort src,  r9w dst)
            => new r9w(src);

        [MethodImpl(Inline), Op]
        public static r10w set(ushort src,  r10w dst)
            => new r10w(src);

        [MethodImpl(Inline), Op]
        public static r11w set(ushort src,  r11w dst)
            => new r11w(src);

        [MethodImpl(Inline), Op]
        public static r12w set(ushort src,  r12w dst)
            => new r12w(src);

        [MethodImpl(Inline), Op]
        public static r13w set(ushort src,  r13w dst)
            => new r13w(src);

        [MethodImpl(Inline), Op]
        public static r14w set(ushort src,  r14w dst)
            => new r14w(src);

        [MethodImpl(Inline), Op]
        public static r15w set(ushort src,  r15w dst)
            => new r15w(src);
    }
}
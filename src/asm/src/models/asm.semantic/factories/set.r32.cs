//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static X86Registers;

    partial struct AsmSemantic
    {
        [MethodImpl(Inline), Op]
        public static eax set(uint src,  eax dst)
            => new eax(src);

        [MethodImpl(Inline), Op]
        public static ecx set(uint src,  ecx dst)
            => new ecx(src);

        [MethodImpl(Inline), Op]
        public static edx set(uint src,  edx dst)
            => new edx(src);

        [MethodImpl(Inline), Op]
        public static ebx set(uint src,  ebx dst)
            => new ebx(src);

        [MethodImpl(Inline), Op]
        public static esi set(uint src,  esi dst)
            => new esi(src);

        [MethodImpl(Inline), Op]
        public static edi set(uint src,  edi dst)
            => new edi(src);

        [MethodImpl(Inline), Op]
        public static esp set(uint src,  esp dst)
            => new esp(src);

        [MethodImpl(Inline), Op]
        public static ebp set(uint src,  ebp dst)
            => new ebp(src);

        [MethodImpl(Inline), Op]
        public static r8d set(uint src,  r8d dst)
            => new r8d(src);

        [MethodImpl(Inline), Op]
        public static r9d set(uint src,  r9d dst)
            => new r9d(src);

        [MethodImpl(Inline), Op]
        public static r10d set(uint src,  r10d dst)
            => new r10d(src);

        [MethodImpl(Inline), Op]
        public static r11d set(uint src,  r11d dst)
            => new r11d(src);

        [MethodImpl(Inline), Op]
        public static r12d set(uint src,  r12d dst)
            => new r12d(src);

        [MethodImpl(Inline), Op]
        public static r13d set(uint src,  r13d dst)
            => new r13d(src);

        [MethodImpl(Inline), Op]
        public static r14d set(uint src,  r14d dst)
            => new r14d(src);

        [MethodImpl(Inline), Op]
        public static r15d set(uint src,  r15d dst)
            => new r15d(src);
    }
}
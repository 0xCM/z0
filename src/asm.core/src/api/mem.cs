//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOperandTypes;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public m8 m8()
            => default;

        [MethodImpl(Inline), Op]
        public m16 m16()
            => default;

        [MethodImpl(Inline), Op]
        public m32 m32()
            => default;

        [MethodImpl(Inline), Op]
        public m64 m64()
            => default;

        [MethodImpl(Inline), Op]
        public m128 m128()
            => default;

        [MethodImpl(Inline), Op]
        public m256 m256()
            => default;

        [MethodImpl(Inline), Op]
        public m512 m512()
            => default;
    }
}
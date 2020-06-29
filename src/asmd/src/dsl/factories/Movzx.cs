//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct Movzx
    {
        [MethodImpl(Inline), Op]
        public static Bound<r8,r16> movzx(r8 src, r16 dst)
            => asm.bind(src,dst);

        [MethodImpl(Inline), Op]
        public static Bound<r8,r32> movzx(r8 src, r32 dst)
            => asm.bind(src,dst);

        [MethodImpl(Inline), Op]
        public static Bound<r8,r64> movzx(r8 src, r64 dst)
            => asm.bind(src,dst);

        [MethodImpl(Inline), Op]
        public static Bound<r16,r32> movzx(r16 src, r32 dst)
            => asm.bind(src,dst);

        [MethodImpl(Inline), Op]
        public static Bound<r16,r64> movzx(r16 src, r64 dst)
            => asm.bind(src,dst);
    }
}
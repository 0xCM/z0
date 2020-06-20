//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;    
    using static Root;
    using static Typed;

    readonly partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static ref CharBlock2 copy(ReadOnlySpan<char> src, ref CharBlock2 dst)
        {
            c16(dst,0) = skip(src,0);
            c16(dst,1) = skip(src,1);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CharBlock3 copy(ReadOnlySpan<char> src, ref CharBlock3 dst)
        {
            c16(dst,0) = skip(src,0);
            c16(dst,1) = skip(src,1);
            c16(dst,2) = skip(src,2);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CharBlock4 copy(ReadOnlySpan<char> src, ref CharBlock4 dst)
        {
            c16(dst,0) = skip(src,0);
            c16(dst,1) = skip(src,1);
            c16(dst,2) = skip(src,2);
            c16(dst,3) = skip(src,3);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CharBlock8 copy(ReadOnlySpan<char> src, ref CharBlock8 dst)
        {
            c16(dst,0) = skip(src,0);
            c16(dst,1) = skip(src,1);
            c16(dst,2) = skip(src,2);
            c16(dst,3) = skip(src,3);
            c16(dst,4) = skip(src,4);
            c16(dst,5) = skip(src,5);
            c16(dst,6) = skip(src,6);
            c16(dst,7) = skip(src,7);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CharBlock16 copy(ReadOnlySpan<char> src, ref CharBlock16 dst)
        {
            var vSrc = SymBits.vload(w128, head(cast<char,byte>(src)));
            SymBits.vstore(vSrc, ref u8r(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CharBlock32 copy(ReadOnlySpan<char> src, ref CharBlock32 dst)
        {
            var vSrc = SymBits.vload(w256, head(cast<char,byte>(src)));
            SymBits.vstore(vSrc, ref u8r(dst));
            return ref dst;
        }
    }
}
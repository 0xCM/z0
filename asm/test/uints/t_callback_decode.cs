//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Gone2;

    public class t_callaback_decode : UnitTest<t_callaback_decode>
    {
        public static ReadOnlySpan<byte> or_ᐤ8uㆍ8uᐤ => new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0xc3}; 

        public static ReadOnlySpan<byte> or_ᐤ16uㆍ16uᐤ => new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x0b,0xc2,0x0f,0xb7,0xc0,0xc3};    

        public static ReadOnlySpan<byte> or_ᐤ32uㆍ32uᐤ => new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x0b,0xc2,0xc3};    

        public static ReadOnlySpan<byte> or_ᐤ64uㆍ64uᐤ => new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x0b,0xc2,0xc3};

        /*


located://math/api?or#or_(8u,8u)        | 0f 1f 44 00 00 0f b6 c1 0f b6 d2 0b c2 0f b6 c0 c3 00 00 00 19 00 00 00 40 00 00 00 00 00 00 00 00 00 00
located://math/api?or#or_(16u,16u)      | 0f 1f 44 00 00 0f b7 c1 0f b7 d2 0b c2 0f b7 c0 c3 00 00 00 19 00 00 00 40 00 00 00 00 00 00 00 00 00 00
located://math/api?or#or_(32u,32u)      | 0f 1f 44 00 00 8b c1 0b c2 c3 00 00 19 00 00 00 40 00 00 00 00 00 00 00 00 a7 a6 90 fd 7f 00 00 0f 1f 44 00 00 48 8b c1 48 0b c2 c3 19 00 00 00 40 00 00 00 00 00 00 00 50 a7 a6 90 fd 7f 00 00 0f 1f 44 00 00 48 8b c1 48 0b c2 c3 19 00 00 00 40 00 00 00 00 00 00 00 a0 a7 a6 90 fd 7f 00 00 0f 1f 44 00 00 48 0f be c1 48 0f be d2 0b c2 49 0f be d0 0b c2 48 0f be c0 c3 00 00 19 00 00 00 40 00 00 00 00 00 00 00 f8 a7 a6 90 fd 7f 00 00 0f 1f 44 00 00 0f b6 c1 0f b6 d2 0b c2 41 0f b6 d0 0b c2 0f b6 c0 c3 00 19 00 00 00 40 00 00 00 00 00 00 00 00 00 00
located://math/api?or#or_(64u,64u)      | 0f 1f 44 00 00 48 8b c1 48 0b c2 c3 19 00 00 00 40 00 00 00 00 00 00 00 a0 a7 a6 90 fd 7f 00 00 0f 1f 44 00 00 48 0f be c1 48 0f be d2 0b c2 49 0f be d0 0b c2 48 0f be c0 c3 00 00 19 00 00 00 40 00 00 00 00 00 00 00 f8 a7 a6 90 fd 7f 00 00 0f 1f 44 00 00 0f b6 c1 0f b6 d2 0b c2 41 0f b6 d0 0b c2 0f b6 c0 c3 00 19 00 00 00 40 00 00 00 00 00 00 00 00 00 00

located://math/api?xnor#xnor_(32i,32i)  | 0f 1f 44 00 00 33 d1 8b c2 f7 d0 c3 19 00 00 00 40 00 00 00 00 00 00 00 70 b1 a6 90 fd 7f 00 00 0f 1f 44 00 00 33 d1 8b c2 f7 d0 c3 19 00 00 00 40 00 00 00 00 00 00 00 c0 b1 a6 90 fd 7f 00 00 0f 1f 44 00 00 48 33 d1 48 8b c2 48 f7 d0 c3 00 19 00 00 00 40 00 00 00 10 b2 a6 90 fd 7f 00 00 0f 1f 44 00 00 48 33 d1 48 8b c2 48 f7 d0 c3 00 19 00 00 00 40 00 00 00 60 b2 a6 90 fd 7f 00 00 0f 1f 44 00 00 48 0f be c1 48 0f be d2 33 c2 48 0f be c0 c3 19 00 00 00 40 00 00 00 00 00 00 00 00 00 00


        */

    }
}
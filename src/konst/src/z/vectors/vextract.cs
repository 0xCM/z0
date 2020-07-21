//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial struct z
    {                            
        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector128<ushort> src, byte index)   
            => (ushort)ConvertToUInt32(v32u(ShiftRightLogical(src, index)));

        [MethodImpl(Inline), Op]
        public static ushort vextract(Vector256<ushort> src, byte index)   
            => (ushort)ConvertToUInt32(v32u(ShiftRightLogical(src, index)));
    }
}
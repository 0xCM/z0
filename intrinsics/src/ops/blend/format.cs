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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static zfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        static char blendsymbol(bit b)
            => b ? 'R' : 'L';

        static string vblendformat<T>(T spec, int len)
            where T : unmanaged, Enum
        {
            Span<char> dst = stackalloc char[len];
            
            var bs = spec.ToBitString();
            for(var i=0; i<dst.Length; i++)
                dst[i] = blendsymbol(bs[i]);

            return new string(dst);
        }

        [MethodImpl(Inline)]
        public static string vblendformat(Blend8x16 spec)                
            => vblendformat(spec,8);

        [MethodImpl(Inline)]
        public static string vblendformat(Blend4x32 spec)                
            => vblendformat(spec,4);

        [MethodImpl(Inline)]
        public static string vblendformat(Blend8x32 spec)                
            => vblendformat(spec,8);

        [MethodImpl(Inline)]
        public static string vblendformat(Blend2x64 spec)                
            => vblendformat(spec,2);

        [MethodImpl(Inline)]
        public static string vblendformat(Blend4x64 spec)
            => vblendformat(spec,4);

    }

}
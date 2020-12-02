//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class XTend
    {
        [MethodImpl(Inline)]
        static char blendsymbol(bit b)
            => b ? 'R' : 'L';

        [Op, Closures(UnsignedInts)]
        static string vblendformat<T>(T spec, int len)
            where T : unmanaged
        {
            Span<char> dst = stackalloc char[len];
            var bs =  BitFormatter.format(spec);
            for(var i=0; i<dst.Length; i++)
                dst[i] = blendsymbol(bs[i]);
            return new string(dst);
        }

        [MethodImpl(Inline)]
        public static string Format(this Blend8x16 spec)
            => vblendformat(spec,8);

        [MethodImpl(Inline)]
        public static string Format(this Blend4x32 spec)
            => vblendformat(spec,4);

        [MethodImpl(Inline)]
        public static string Format(this Blend8x32 spec)
            => vblendformat(spec,8);

        [MethodImpl(Inline)]
        public static string Format(this Blend2x64 spec)
            => vblendformat(spec,2);

        public static string Format(this Blend4x64 spec)
            => vblendformat(spec,4);
    }
}
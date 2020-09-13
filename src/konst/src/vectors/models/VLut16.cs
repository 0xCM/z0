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
    using static z;

    /// <summary>
    /// Implements a parallel 16-way lookup
    /// </summary>
    [ApiDataType]
    public readonly struct VLut16
    {
        internal readonly Vector128<byte> Mask;

        [MethodImpl(Inline)]
        public static VLut16 Define(Vector128<byte> src)
            => new VLut16(src);

        [MethodImpl(Inline)]
        public static VLut16 Define(ReadOnlySpan<byte> src)
            => new VLut16(src);

        [MethodImpl(Inline)]
        public static VLut16 Define(in SpanBlock128<byte> src)
            => new VLut16(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(in VLut16 src)
            => src.Mask;

        public byte this[byte i]
        {
             [MethodImpl(Inline)]
             get => vcell(Mask,i);
        }

        [MethodImpl(Inline)]
        VLut16(Vector128<byte> src) => Mask = src;

        [MethodImpl(Inline)]
        VLut16(in SpanBlock128<byte> src)
            => Mask = z.vload(src);

        [MethodImpl(Inline)]
        VLut16(ReadOnlySpan<byte> src)
            => Mask = z.vload(w128,src);
    }
}
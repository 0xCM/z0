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
    using static Memories;
    
    /// <summary>
    /// Implements a parallel 32-way lookup
    /// </summary>
    public readonly struct VLut32
    {
        internal readonly Vector256<byte> Mask;

        [MethodImpl(Inline)]
        public static VLut32 Define(Vector256<byte> src) 
            => new VLut32(src);

        [MethodImpl(Inline)]
        public static VLut32 Define(ReadOnlySpan<byte> src) 
            => new VLut32(src);

        [MethodImpl(Inline)]
        public static VLut32 Define(in Block256<byte> src) 
            => new VLut32(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(in VLut32 src) 
            => src.Mask;

        public byte this[int i] 
        { 
            [MethodImpl(Inline)] 
            get => vcell(Mask,i); 
        }

        [MethodImpl(Inline)]
        VLut32(Vector256<byte> src) 
            => Mask = src;

        [MethodImpl(Inline)]
        VLut32(in Block256<byte> src) 
            => Mask = Vectors.vload(src);

        [MethodImpl(Inline)]
        VLut32(ReadOnlySpan<byte> src) 
            => Mask = Vectors.vload(w256,src);
    }
}
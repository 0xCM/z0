//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Memories;
    
    /// <summary>
    /// Implements a parallel 32-way lookup
    /// </summary>
    public readonly struct Lut32
    {
        internal readonly Vector256<byte> Mask;

        [MethodImpl(Inline)]
        public Vector256<byte> Select(Vector256<byte> items) 
            => dvec.vshuf32x8(items, Mask);

        [MethodImpl(Inline)]
        public static Lut32 Define(Vector256<byte> src) 
            => new Lut32(src);

        [MethodImpl(Inline)]
        public static Lut32 Define(ReadOnlySpan<byte> src) 
            => new Lut32(src);

        [MethodImpl(Inline)]
        public static Lut32 Define(in Block256<byte> src) 
            => new Lut32(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(in Lut32 src) 
            => src.Mask;

        public byte this[int i] 
        { 
            [MethodImpl(Inline)] 
            get => vcell(Mask,i); 
        }

        [MethodImpl(Inline)]
        Lut32(Vector256<byte> src) 
            => Mask = src;

        [MethodImpl(Inline)]
        Lut32(in Block256<byte> src) 
            => Mask = Vectors.vload(src);

        [MethodImpl(Inline)]
        Lut32(ReadOnlySpan<byte> src) 
            => Mask = Vectors.vload(w256,src);
    }
}
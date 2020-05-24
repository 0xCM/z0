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
    /// Implements a parallel 16-way lookup
    /// </summary>
    public readonly struct Lut16
    {
        internal readonly Vector128<byte> Mask;

        [MethodImpl(Inline)]
        public static Lut16 Define(Vector128<byte> src) 
            => new Lut16(src);

        [MethodImpl(Inline)]
        public static Lut16 Define(ReadOnlySpan<byte> src) 
            => new Lut16(src);

        [MethodImpl(Inline)]
        public static Lut16 Define(in Block128<byte> src) 
            => new Lut16(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(in Lut16 src) 
            => src.Mask;

        public byte this[int i] 
        {
             [MethodImpl(Inline)] 
             get => vcell(Mask,i); 
        }

        [MethodImpl(Inline)]
        Lut16(Vector128<byte> src) => Mask = src;

        [MethodImpl(Inline)]
        Lut16(in Block128<byte> src) 
            => Mask = Vectors.vload(src);

        [MethodImpl(Inline)]
        Lut16(ReadOnlySpan<byte> src) 
            => Mask = Vectors.vload(w128,src);
    }
}
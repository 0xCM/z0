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
    
    /// <summary>
    /// Defines content for a parallel 32-way lookup
    /// </summary>
    public readonly struct Lut32
    {
        readonly Vector256<byte> data;

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(Lut32 src)
            => src.data;

        [MethodImpl(Inline)]
        internal Lut32(Vector256<byte> data)
            => this.data = data;

        [MethodImpl(Inline)]
        internal Lut32(in Block256<byte> data)
            => this.data = data.LoadVector();

        public byte this[int i]
        {
            [MethodImpl(Inline)]
            get => data.GetElement(i);

            [MethodImpl(Inline)]
            set => data.WithElement(i,value);
        }

        public Vector256<byte> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => 32;
        }
    }
}
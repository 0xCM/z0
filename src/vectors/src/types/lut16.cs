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
    /// Defines content for a parallel 16-way lookup
    /// </summary>
    public readonly struct Lut16
    {
        readonly Vector128<byte> data;

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(Lut16 src)
            => src.data;

        [MethodImpl(Inline)]
        internal Lut16(Vector128<byte> data)
            => this.data = data;

        [MethodImpl(Inline)]
        internal Lut16(in Block128<byte> data)
            => this.data = data.LoadVector();

        public byte this[int i]
        {
            [MethodImpl(Inline)]
            get => data.GetElement(i);

            [MethodImpl(Inline)]
            set => data.WithElement(i,value);
        }

        public Vector128<byte> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => 16;
        }
    }
}
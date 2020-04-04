//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    [StructLayout(LayoutKind.Sequential)]
    [Fixed(FixedWidth.W256)]
    public struct Fixed256V : IFixed<Fixed256V>, IEquatable<Fixed256V>
    {
        internal Vector256<ulong> data;

        public int BitWidth  { [MethodImpl(Inline)] get => 256; }

        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        public static Fixed256V From<T>(Vector256<T> src)
            where T : unmanaged
                => new Fixed256V(src.AsUInt64());


        [MethodImpl(Inline)]
        Fixed256V(Vector256<ulong> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V(Vector256<byte> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V(Vector256<ushort> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V(Vector256<uint> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256V(Vector256<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(Fixed256V x)
            => x.data.AsByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ushort>(Fixed256V x)
            => x.data.AsUInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<uint>(Fixed256V x)
            => x.data.AsUInt32();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ulong>(Fixed256V x)
            => x.data.AsUInt64();
                
        [MethodImpl(Inline)]
        public bool Equals(Fixed256V src)
            => data.Equals(src.data);
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed256V x && Equals(x);

        public override string ToString() 
            => data.ToString();
    }

    partial class XFixed
    {
    }
}
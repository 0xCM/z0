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
    using System.Security;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    [Fixed(FixedWidth.W256,false,FixedWidth.NumericWidths)]
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

    partial class FixedVectorOps
    {
        [MethodImpl(Inline)]
        public static Vector256<T> ToVector<T>(this in Fixed256V src)
            where T : unmanaged
                => src.data.As<ulong,T>();

        [MethodImpl(Inline)]
        public static Fixed256V ToFixedV<T>(this Vector256<T> x)
            where T : unmanaged
                => Fixed256V.From(x);

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this UnaryOp256V f, Vector256<T> x)
            where T : unmanaged
                => f(x.ToFixedV()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector256<T> ApplyV<T>(this BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();
    }
}
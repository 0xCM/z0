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

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128V Emitter128V();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128V UnaryOp128V(Fixed128V a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128V BinaryOp128V(Fixed128V a, Fixed128V b);

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed128V : IFixed<Fixed128V>, IEquatable<Fixed128V>, IFormattable<Fixed128V>
    {
        public const int BitWidth = 128;        

        internal Vector128<ulong> data;

        public int FixedBitCount  { [MethodImpl(Inline)] get => BitWidth; }

        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        public static Fixed128V From<T>(Vector128<T> src)
            where T : unmanaged
            => new Fixed128V(src.AsUInt64());

        [MethodImpl(Inline)]
        public static Fixed128V From((ulong x0, ulong x1) x)
            => new Fixed128V(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static Fixed128V From(in ConstPair<ulong> x)
            => new Fixed128V(x.A,x.B);


        [MethodImpl(Inline)]
        Fixed128V(Vector128<ulong> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        Fixed128V(ulong x0, ulong x1)
        {
            data = Vector128.Create(x0,x1);
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128V((ulong x0, ulong x1) x)
            => From(x);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(in ConstPair<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(Vector128<byte> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(Vector128<ushort> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(Vector128<uint> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128V(Vector128<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(Fixed128V x)
            => x.data.AsByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ushort>(Fixed128V x)
            => x.data.AsUInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<uint>(Fixed128V x)
            => x.data.AsUInt32();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(Fixed128V x)
            => x.data.AsUInt64();
                
        [MethodImpl(Inline)]
        public bool Equals(Fixed128V src)
            => data.Equals(src.data);
        
        public string Format()
            => data.ToString();

        public override int GetHashCode()
            => data.GetHashCode();
        
        public override bool Equals(object src)
            => src is Fixed128V x && Equals(x);
        
        public override string ToString() 
            => Format();
    }

    partial class FixedVectorOps
    {
        [MethodImpl(Inline)]
        public static Vector128<T> ToVector<T>(this in Fixed128V src)
            where T : unmanaged
                => src.data.As<ulong,T>();

        [MethodImpl(Inline)]
        public static Fixed128V ToFixedV<T>(this Vector128<T> x)
            where T : unmanaged
                => Fixed128V.From(x);

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this UnaryOp128V f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToFixedV()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> ApplyV<T>(this BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();
    }
}
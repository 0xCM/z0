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
    public delegate Fixed256 Emitter256();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 UnaryOp256(Fixed256 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed256 BinaryOp256(Fixed256 a, Fixed256 b);

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed256  : IFixed<Fixed256>, IEquatable<Fixed256>
    {
        public const int BitWidth = 256;        

        Fixed128 X0;

        Fixed128 X1;

        public int FixedBitCount  { [MethodImpl(Inline)] get => BitWidth; }

        [MethodImpl(Inline)]
        Fixed256(Fixed128 x0, Fixed128 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<byte> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<ushort> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<uint> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(Vector256<ulong> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(Fixed256 x)
            => x.ToVector<byte>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ushort>(Fixed256 x)
            => x.ToVector<ushort>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<uint>(Fixed256 x)
            => x.ToVector<uint>();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ulong>(Fixed256 x)
            => x.ToVector<ulong>();

        [MethodImpl(Inline)]
        public static implicit operator Fixed256((Fixed128 x0, Fixed128 x1) x)
            => new Fixed256(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(in Pair<Fixed128> x)
            => new Fixed256(x.A,x.B);

        [MethodImpl(Inline)]
        public static implicit operator Fixed256(in ConstPair<Fixed128> x)
            => new Fixed256(x.A,x.B);

        [MethodImpl(Inline)]
        public bool Equals(Fixed256 src)
            => X0.Equals(src.X0) && X1.Equals(src.X1);
        
        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed256 x && Equals(x);

        public override string ToString() 
            => array(X0,X1).FormatDataList();
    }

    partial class Fixed
    {
        [MethodImpl(Inline)]
        public static ref readonly F FromVector<T,F>(in Vector256<T> src)
            where F : unmanaged, IFixed
            where T : struct
                => ref From<Vector256<T>,F>(in src);

    }

    partial class FixedVectorOps
    {
        [MethodImpl(Inline)]
        public static Fixed256 ToFixed<T>(this Vector256<T> x)
            where T : unmanaged
                => Unsafe.As<Vector256<T>,Fixed256>(ref x);

        [MethodImpl(Inline)]
        public static Vector256<T> ToVector<T>(this in Fixed256 src)
            where T : unmanaged
                => Unsafe.As<Fixed256,Vector256<T>>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this UnaryOp256 f, Vector256<T> x)
           where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector256<T> Apply<T>(this BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            var zf = f(Unsafe.As<Vector256<T>,Fixed256>(ref x), Unsafe.As<Vector256<T>,Fixed256>(ref y));
            return Unsafe.As<Fixed256,Vector256<T>>(ref zf);
        }
    }
}
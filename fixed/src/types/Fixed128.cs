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
    public delegate Fixed128 Emitter128();

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 UnaryOp128(Fixed128 a);

    [SuppressUnmanagedCodeSecurity]
    public delegate Fixed128 BinaryOp128(Fixed128 a, Fixed128 b);

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed128 : IFixed<Fixed128>, IEquatable<Fixed128>
    {
        public const int BitWidth = 128;        

        ulong X0;

        ulong X1;       

        public int FixedBitCount  { [MethodImpl(Inline)] get => BitWidth; }

        public FixedWidth FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)BitWidth;
        }

        [MethodImpl(Inline)]
        Fixed128(ulong x0, ulong x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128((ulong x0, ulong x1) x)
            => new Fixed128(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(in Pair<ulong> x)
            => new Fixed128(x.A,x.B);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128(in ConstPair<ulong> x)
            => new Fixed128(x.A,x.B);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<byte> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<ushort> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<uint> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<ulong> x)
            => x.ToFixed();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(Fixed128 x)
            => x.ToVector<byte>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ushort>(Fixed128 x)
            => x.ToVector<ushort>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<uint>(Fixed128 x)
            => x.ToVector<uint>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(Fixed128 x)
            => x.ToVector<ulong>();

                
        [MethodImpl(Inline)]
        public bool Equals(Fixed128 src)
            => X0 == src.X0 && X1 == src.X1;
        
        public override int GetHashCode()
            => HashCode.Combine(X0,X1);
        
        public override bool Equals(object src)
            => src is Fixed128 x && Equals(x);

        public override string ToString() 
            => array(X0,X1).FormatDataList();       
    }

    partial class Fixed
    {
        [MethodImpl(Inline)]
        public static ref readonly F FromVector<T,F>(in Vector128<T> src)
            where F : unmanaged, IFixed
            where T : struct
                => ref From<Vector128<T>,F>(in src);
    }

    partial class FixedVectorOps
    {
        [MethodImpl(Inline)]
        public static Vector128<T> ToVector<T>(this in Fixed128 src)
            where T : unmanaged
                => Unsafe.As<Fixed128,Vector128<T>>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        public static Fixed128 ToFixed<T>(this Vector128<T> x)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,Fixed128>(ref x);

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this UnaryOp128 f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> Apply<T>(this BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToFixed(), y.ToFixed()).ToVector<T>();
    }
}
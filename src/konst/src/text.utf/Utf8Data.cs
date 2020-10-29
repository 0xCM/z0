//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Utf8Data)]
    public readonly struct Utf8Data
    {
        const NumericKind Closure = UInt8x16x32k;

        [MethodImpl(Inline), Op]
        public static utf8x0 define(N0 n, byte src)
            => new utf8x0(src);

        [MethodImpl(Inline), Op]
        public static utf8x1 define(N1 n, byte src)
            => new utf8x1(src);

        [MethodImpl(Inline), Op]
        public static utf8x2 define(N2 n, byte src)
            => new utf8x2(src);

        [MethodImpl(Inline), Op]
        public static utf8x3 define(N3 n, byte src)
            => new utf8x3(src);

        [MethodImpl(Inline), Op]
        public static utf8x1<W8,byte> define(W8 w, N1 n, byte src)
            => new utf8x1<W8,byte>(src);

        [MethodImpl(Inline), Op]
        public static utf8x1<W16,ushort> define(W16 w, N1 n, ushort src)
            => new utf8x1<W16,ushort>(src);

        [MethodImpl(Inline), Op]
        public static utf8x1<W24,uint24> define(W24 w, N1 n, uint24 a)
            => new utf8x1<W24,uint24>(a);

        [MethodImpl(Inline), Op]
        public static utf8x1<W32,uint> define(W8 w, N1 n, uint a)
            => new utf8x1<W32,uint>(a);

        [MethodImpl(Inline), Op]
        public static utf8x2<W8,byte> define(W8 w, N2 n, byte a0, byte a1)
            => new utf8x2<W8,byte>(a0,a1);

        [MethodImpl(Inline), Op]
        public static utf8x2<W8,byte> define(W8 w, N2 n, ushort src)
            => new utf8x2<W8,byte>((byte)src, (byte)(src >> 8));

        [MethodImpl(Inline), Op]
        public static utf8x4<W8,byte> define(W8 w, N4 n, ushort a0, ushort a1)
            => new utf8x4<W8,byte>(define(w, n2, a0), define(w, n2, a0));

        [MethodImpl(Inline), Op]
        public static utf8x4<W8,byte> define(W8 w, N4 n, byte a0, byte a1, byte a2, byte a3)
            => new utf8x4<W8,byte>(a0, a1, a2, a3);

        [MethodImpl(Inline), Op]
        public static utf8x8<W8,byte> define(W8 w, N8 n, byte a0, byte a1, byte a2, byte a3, byte a4, byte a5, byte a6, byte a7)
            => new utf8x8<W8,byte>(define(w, n4, a0, a1, a2, a3), define(w, n4, a4,a5,a6,a7));

        /// <summary>
        /// Defines the first segment of an 8, 16, 24 or 32-bit utf8-encoded symbol
        /// </summary>
        public struct utf8x0
        {
            public const byte Index = 0;

            internal byte Value;

            [MethodImpl(Inline)]
            public utf8x0(byte value)
                => Value = value;
        }

        public struct utf8x1
        {
            public const byte Index = 1;

            internal byte Value;

            [MethodImpl(Inline)]
            public utf8x1(byte value)
                => Value = value;
        }

        public struct utf8x2
        {
            public const byte Index = 2;

            internal byte Value;

            [MethodImpl(Inline)]
            public utf8x2(byte value)
                => Value = value;
        }

        public struct utf8x3
        {
            public const byte Index = 3;

            internal byte Value;

            [MethodImpl(Inline)]
            public utf8x3(byte value)
                => Value = value;
        }

        /// <summary>
        /// Defines a utf8-encoded symbol where <typeparamref name='T'/> is an unmanaged type with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x1<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
            internal T A0;

            [MethodImpl(Inline)]
            public utf8x1(T a)
                => A0 = a;

            [MethodImpl(Inline)]
            public static implicit operator utf8x1<W,T>(T src)
                => new utf8x1<W,T>(src);

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }

        /// <summary>
        /// Defines an ordered sequence of two utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x2<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
            internal utf8x1<W,T> A0;

            internal utf8x1<W,T> A1;

            [MethodImpl(Inline)]
            public utf8x2(in utf8x1<W,T> a0, in utf8x1<W,T> a1)
            {
                A0 = a0;
                A1 = a1;
            }

            [MethodImpl(Inline)]
            public static implicit operator utf8x2<W,T>(in Pair<utf8x1<W,T>> src)
                => new utf8x2<W,T>(src.Left, src.Right);

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }

        /// <summary>
        /// Defines an ordered sequence of 4 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x4<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
            internal utf8x2<W,T> A0;

            internal utf8x2<W,T> A1;

            [MethodImpl(Inline)]
            public utf8x4(in utf8x2<W,T> a0, in utf8x2<W,T> a1)
            {
                A0 = a0;
                A1 = a1;
            }

            [MethodImpl(Inline)]
            public utf8x4(in utf8x1<W,T> a0, in utf8x1<W,T> a1, in utf8x1<W,T> a2, in utf8x1<W,T> a3)
            {
                A0 = pair(a0,a1);
                A1 = pair(a2,a3);
            }

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }

        /// <summary>
        /// Defines an ordered sequence of 8 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x8<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
            internal utf8x4<W,T> A;

            internal utf8x4<W,T> B;

            [MethodImpl(Inline)]
            public utf8x8(in utf8x4<W,T> a, in utf8x4<W,T> b)
            {
                A = a;
                B = b;
            }

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }

        /// <summary>
        /// Defines an ordered sequence of 16 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x16<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
            internal utf8x8<W,T> A;

            internal utf8x8<W,T> B;

            [MethodImpl(Inline)]
            public utf8x16(in utf8x8<W,T> a, in utf8x8<W,T> b)
            {
                A = a;
                B = b;
            }

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }

        /// <summary>
        /// Defines an ordered sequence of 32 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x32<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {

            internal utf8x16<W,T> A;

            internal utf8x16<W,T> B;

            [MethodImpl(Inline)]
            public utf8x32(in utf8x16<W,T> a, in utf8x16<W,T> b)
            {
                A = a;
                B = b;
            }

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }

        /// <summary>
        /// Defines an ordered sequence of 64 encoded utf8 symbols where <typeparamref name='T'/> is an unmanaged type with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x64<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
            internal utf8x32<W,T> A;

            internal utf8x32<W,T> B;

            [MethodImpl(Inline)]
            public utf8x64(in utf8x32<W,T> a, in utf8x32<W,T> b)
            {
                A = a;
                B = b;
            }

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }

        /// <summary>
        /// Defines an ordered sequence of 128 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x128<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {

            internal utf8x64<W,T> A;

            internal utf8x64<W,T> B;

            [MethodImpl(Inline)]
            public utf8x128(in utf8x64<W,T> a, in utf8x64<W,T> b)
            {
                A = a;
                B = b;
            }

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }

        /// <summary>
        /// Defines an ordered sequence of 128 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x256<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
            internal utf8x128<W,T> A;

            internal utf8x128<W,T> B;

            [MethodImpl(Inline)]
            public utf8x256(in utf8x128<W,T> a, in utf8x128<W,T> b)
            {
                A = a;
                B = b;
            }

            /// <summary>
            /// The atom width
            /// </summary>
            public static Hex5 AtomWidth
                => (Hex5)default(W).BitWidth;

            /// <summary>
            /// The size of the storage cell, in bytes
            /// </summary>
            public static Hex2 CellSize
                => (Hex2)size<T>();
        }
    }
}
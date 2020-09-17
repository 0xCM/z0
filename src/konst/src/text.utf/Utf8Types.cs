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

    public readonly struct Utf8Types
    {
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
        /// Defines a utf8-encoded symbol where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x1<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
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

            internal T A;

            [MethodImpl(Inline)]
            public utf8x1(T a)
            {
                A = a;
            }
        }

        /// <summary>
        /// Defines an ordered sequence of two utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x2<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
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

            internal utf8x1<W,T> A;

            internal utf8x1<W,T> B;

            [MethodImpl(Inline)]
            public utf8x2(in utf8x1<W,T> a, in utf8x1<W,T> b)
            {
                A = a;
                B = b;
            }
        }

        /// <summary>
        /// Defines an ordered sequence of 4 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        public struct utf8x4<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
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

            internal utf8x2<W,T> A;

            internal utf8x2<W,T> B;

            [MethodImpl(Inline)]
            public utf8x4(in utf8x2<W,T> a, in utf8x2<W,T> b)
            {
                A = a;
                B = b;
            }
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

            internal utf8x4<W,T> A;

            internal utf8x4<W,T> B;

            [MethodImpl(Inline)]
            public utf8x8(in utf8x4<W,T> a, in utf8x4<W,T> b)
            {
                A = a;
                B = b;
            }
        }

        /// <summary>
        /// Defines an ordered sequence of 16 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x16<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
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

            internal utf8x8<W,T> A;

            internal utf8x8<W,T> B;

            [MethodImpl(Inline)]
            public utf8x16(in utf8x8<W,T> a, in utf8x8<W,T> b)
            {
                A = a;
                B = b;
            }
        }

        /// <summary>
        /// Defines an ordered sequence of 32 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x32<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
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

            internal utf8x16<W,T> A;

            internal utf8x16<W,T> B;

            [MethodImpl(Inline)]
            public utf8x32(in utf8x16<W,T> a, in utf8x16<W,T> b)
            {
                A = a;
                B = b;
            }
        }

        /// <summary>
        /// Defines an ordered sequence of 64 encoded utf8 symbols where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x64<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
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

            internal utf8x32<W,T> A;

            internal utf8x32<W,T> B;

            [MethodImpl(Inline)]
            public utf8x64(in utf8x32<W,T> a, in utf8x32<W,T> b)
            {
                A = a;
                B = b;
            }
        }

        /// <summary>
        /// Defines an ordered sequence of 128 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x128<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {

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

            internal utf8x64<W,T> A;

            internal utf8x64<W,T> B;

            [MethodImpl(Inline)]
            public utf8x128(in utf8x64<W,T> a, in utf8x64<W,T> b)
            {
                A = a;
                B = b;
            }
        }

        /// <summary>
        /// Defines an ordered sequence of 128 utf8-encoded symbols where <typeparamref name='T'/> is an unmanaged type
        /// with interpreted width of <see cref='W8'/>, <see cref='W16'/>, <see cref='W24'/> or <see cref='W32'/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct utf8x256<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
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

            internal utf8x128<W,T> A;

            internal utf8x128<W,T> B;

            [MethodImpl(Inline)]
            public utf8x256(in utf8x128<W,T> a, in utf8x128<W,T> b)
            {
                A = a;
                B = b;
            }
        }
    }
}
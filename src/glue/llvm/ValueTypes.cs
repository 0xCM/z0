//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    using static LlvmValues;

    public interface IValueType<T>
        where T : unmanaged, IValueType<T>
    {
        StringAddress Name {get;}

        BitWidth Width => width<T>();

        ByteSize Size => size<T>();
    }

    public struct ValueTypeInfo
    {
        public StringAddress Name;

        public BitWidth Width;
    }

    /// <summary>
    /// Derived from ValueTypes.td
    /// </summary>
    public readonly struct ValueTypes
    {
        const LayoutKind Layout = LayoutKind.Sequential;

        /// <summary>
        ///  1 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v1i64
        {
            public const ushort Width = 64;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v1i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }

        /// <summary>
        ///  2 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v2i64
        {
            public const ushort Width = 128;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v2i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }

        /// <summary>
        ///  4 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v4i64
        {
            public const ushort Width = 256;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v4i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }

        /// <summary>
        ///  4 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v8i64
        {
            public const ushort Width = 512;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v8i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }

        /// <summary>
        ///  16 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v16i64
        {
            public const ushort Width = 1024;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v16i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }

        /// <summary>
        ///  32 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v32i64
        {
            public const ushort Width = 2048;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v32i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }

        /// <summary>
        ///  64 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v64i64
        {
            public const ushort Width = 4096;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v64i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }

        /// <summary>
        ///  128 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v128i64
        {
            public const ushort Width = 8192;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v128i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }

        /// <summary>
        ///  256 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v256i64
        {
            public const ushort Width = 16384;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v256i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
       }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock1 : IDataBlock<ByteBlock1>
    {
        public const ushort Size = Pow2.T00;

        byte A;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        [MethodImpl(Inline)]
        public static implicit operator ByteBlock1(byte src)
            => @as<uint,ByteBlock1>(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(ByteBlock1 src)
            => @as<ByteBlock1,byte>(src);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock2 : IDataBlock<ByteBlock2>
    {
        public const ushort Size = Pow2.T01;

        ByteBlock1 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        [MethodImpl(Inline)]
        public static implicit operator ByteBlock2(ushort src)
            => @as<ushort,ByteBlock2>(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(ByteBlock2 src)
            => @as<ByteBlock2,ushort>(src);
    }

    /// <summary>
    /// 3 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock3 : IDataBlock<ByteBlock3>
    {
        public const ushort Size = 3;

        ByteBlock2 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock4 : IDataBlock<ByteBlock4>
    {
        public const ushort Size = Pow2.T02;

        ByteBlock2 A;

        ByteBlock2 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }

        [MethodImpl(Inline)]
        public static implicit operator ByteBlock4(uint src)
            => @as<uint,ByteBlock4>(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(ByteBlock4 src)
            => @as<ByteBlock4,uint>(src);
    }

    /// <summary>
    /// 5 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock5 : IDataBlock<ByteBlock5>
    {
        public const ushort Size = 5;

        ByteBlock4 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// 6 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock6 : IDataBlock<ByteBlock6>
    {
        public const ushort Size = 6;

        ByteBlock5 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// 7 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock7 : IDataBlock<ByteBlock7>
    {
        public const ushort Size = 7;

        ByteBlock6 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock8 : IDataBlock<ByteBlock8>
    {
        public const ushort Size = Pow2.T03;

        ByteBlock4 A;

        ByteBlock4 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }

        [MethodImpl(Inline)]
        public static implicit operator ByteBlock8(ulong src)
            => @as<ulong,ByteBlock8>(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(ByteBlock8 src)
            => @as<ByteBlock8,ulong>(src);
    }

    /// <summary>
    /// 9 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock9 : IDataBlock<ByteBlock9>
    {
        public const ushort Size = 9;

        ByteBlock8 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// 10 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock10 : IDataBlock<ByteBlock10>
    {
        public const ushort Size = 10;

        ByteBlock9 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// 11 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock11 : IDataBlock<ByteBlock11>
    {
        public const ushort Size = 11;

        ByteBlock10 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// 12 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock12 : IDataBlock<ByteBlock12>
    {
        public const ushort Size = 12;

        ByteBlock8 A;

        ByteBlock4 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// 13 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock13 : IDataBlock<ByteBlock13>
    {
        public const ushort Size = 13;

        ByteBlock12 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// 14 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock14 : IDataBlock<ByteBlock14>
    {
        public const ushort Size = 14;

        ByteBlock7 A;

        ByteBlock7 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// 15 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock15 : IDataBlock<ByteBlock15>
    {
        public const ushort Size = 15;

        ByteBlock10 A;

        ByteBlock5 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// Defines 16 bytes = 512 bits of stack-allocated storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock16 : IDataBlock<ByteBlock16>
    {
        public const ushort Size = Pow2.T04;

        public ulong A;

        public ulong B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock17 : IDataBlock<ByteBlock17>
    {
        public const ushort Size = 17;

        ByteBlock16 A;

        ByteBlock1 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock18 : IDataBlock<ByteBlock18>
    {
        public const ushort Size = 18;

        ByteBlock16 A;

        ByteBlock2 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock19 : IDataBlock<ByteBlock19>
    {
        public const ushort Size = 19;

        ByteBlock16 A;

        ByteBlock3 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock20 : IDataBlock<ByteBlock20>
    {
        public const ushort Size = 20;

        ByteBlock16 A;

        ByteBlock4 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock24 : IDataBlock<ByteBlock24>
    {
        public const ushort Size = 24;

        ByteBlock16 A;

        ByteBlock8 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// Covers 32 bytes = 256 bits of stack-allocated storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock32 : IDataBlock<ByteBlock32>
    {
        public const ushort Size = Pow2.T05;

        ByteBlock16 A;

        ByteBlock16 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// Covers 64 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock64 : IDataBlock<ByteBlock64>
    {
        public const ushort Size = Pow2.T06;

        ByteBlock32 A;

        ByteBlock32 B;

        [MethodImpl(Inline)]
        public ByteBlock64(ByteBlock32 a, ByteBlock32 b)
        {
            A = a;
            B = b;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// Covers 80 bytes of storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock80 : IDataBlock<ByteBlock80>
    {
        public const ushort Size = 80;

        ByteBlock64 A;

        ByteBlock18 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
    }

    /// <summary>
    /// Covers 128 bytes = 1024 bits of stack-allocated storage
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock128
    {
        public const ushort Size = Pow2.T07;

        ByteBlock64 A;

        ByteBlock64 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
   }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock256
    {
        public const ushort Size = Pow2.T08;

        ByteBlock128 A;

        ByteBlock128 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
   }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock512
    {
        public const ushort Size = Pow2.T09;

        ByteBlock256 A;

        ByteBlock256 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
   }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock1024
    {
        public const ushort Size = Pow2.T10;

        ByteBlock512 A;

        ByteBlock512 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
   }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock2048
    {
        public const ushort Size = Pow2.T11;

        ByteBlock1024 A;

        ByteBlock1024 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
   }

    [StructLayout(LayoutKind.Sequential)]
    public struct ByteBlock4096
    {
        public const ushort Size = Pow2.T12;

        ByteBlock2048 A;

        ByteBlock2048 B;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref byte First
        {
            [MethodImpl(Inline)]
            get => ref first(Bytes);
        }
   }
}
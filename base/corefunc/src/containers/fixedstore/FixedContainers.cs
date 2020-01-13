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

    using static zfunc;

    public interface IFixed
    {
        int Width {get;}
    }

    public interface IFixed<W> : IFixed
        where W : unmanaged, ITypeNat
    {
        W NatWidth => default;
    }

    public interface IFixed<F,W> : IFixed<W>
        where F : unmanaged, IFixed<F,W>
        where W : unmanaged, ITypeNat
    {
        
    }

    public struct Fixed8 : IFixed<Fixed8,N8>
    {
        public const int BitWidth = 8;        

        internal byte X0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(byte x0)
            => new Fixed8(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(sbyte x0)
            => new Fixed8((byte)x0);

        [MethodImpl(Inline)]
        internal Fixed8(byte x0)
            => X0 = x0;

        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }
    }

    public struct Fixed16 : IFixed<Fixed16,N16>
    {
        public const int BitWidth = 16;

        internal ushort X0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(ushort x0)
            => new Fixed16(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed16(short x0)
            => new Fixed16((ushort)x0);

        [MethodImpl(Inline)]
        internal Fixed16(ushort x0)
            => X0 = x0;

        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }
    }

    public struct Fixed32 : IFixed<Fixed32,N32>
    {
        public const int BitWidth = 32;        

        internal uint X0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(uint x0)
            => new Fixed32(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed32(int x0)
            => new Fixed32((uint)x0);

        [MethodImpl(Inline)]
        public static explicit operator uint(Fixed32 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static explicit operator int(Fixed32 x)
            => (int)x.X0;

        [MethodImpl(Inline)]
        internal Fixed32(uint x0)
            => X0 = x0;

        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }
    }

    public struct Fixed64 : IFixed<Fixed64,N64>
    {
        public const int BitWidth = 64;        

        internal ulong X0;

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(long x0)
            => new Fixed64((ulong)x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed64(ulong x0)
            => new Fixed64(x0);

        [MethodImpl(Inline)]
        public static explicit operator ulong(Fixed64 x)
            => x.X0;

        [MethodImpl(Inline)]
        public static explicit operator long(Fixed64 x)
            => (long)x.X0;

        [MethodImpl(Inline)]
        internal Fixed64(ulong x0)
            => X0 = x0;
        
        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed128 : IFixed<Fixed128,N128>
    {
        internal ulong X0;

        ulong X1;       

        public const int BitWidth = 128;        

        [MethodImpl(Inline)]
        public static implicit operator Fixed128((ulong x0, ulong x1) x)
            => new Fixed128(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(in Pair<ulong> x)
            => new Fixed128(x.A,x.B);
        
        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<byte> x)
        {
            var dst = FixedStore.alloc(n128);
            FixedStore.deposit(x,ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<ushort> x)
        {
            var dst = FixedStore.alloc(n128);
            FixedStore.deposit(x,ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<uint> x)
        {
            var dst = FixedStore.alloc(n128);
            FixedStore.deposit(x,ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(Vector128<ulong> x)
        {
            var dst = FixedStore.alloc(n128);
            FixedStore.deposit(x,ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        internal Fixed128(ulong x0, ulong x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }
        

        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed256  : IFixed<Fixed256,N256>
    {
        public const int BitWidth = 256;        

        internal Fixed128 X0;

        Fixed128 X1;

        [MethodImpl(Inline)]
        public static implicit operator Fixed256((Fixed128 x0, Fixed128 x1) x)
            => new Fixed256(x.x0,x.x1);

        [MethodImpl(Inline)]
        internal Fixed256(Fixed128 x0, Fixed128 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }
        
        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed512  : IFixed<Fixed512,N512>
    {
        public const int BitWidth = 512;        

        internal Fixed256 X0;

        Fixed256 X1;
        
        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed1024 : IFixed<Fixed1024,N1024>
    {
        public const int BitWidth = 1024;        

        internal Fixed512 X0;

        Fixed512 X1;
        

        public int Width
        {
            [MethodImpl(Inline)]
            get => BitWidth;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed2048
    {
        internal Fixed1024 X0;

        Fixed1024 X1;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed4096
    {
        internal Fixed2048 X0;

        Fixed2048 X1;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char2
    {
        internal char C0;

        char C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char4
    {
        internal Char2 C0;

        Char2 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char8
    {
        internal Char4 C0;

        Char4 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char16
    {
        internal Char8 C0;

        Char8 C1;        
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct Char32
    {
        internal Char16 C0;

        Char16 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char64
    {
        internal Char32 C0;

        Char32 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char128
    {
        internal Char64 C0;

        Char64 C1;        
    }

    public static class FixedContainers
    {

    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    using static zfunc;

    public struct Fixed8
    {
        [MethodImpl(Inline)]
        public static implicit operator Fixed8(byte x0)
            => new Fixed8(x0);

        [MethodImpl(Inline)]
        public static implicit operator Fixed8(sbyte x0)
            => new Fixed8((byte)x0);

        [MethodImpl(Inline)]
        internal Fixed8(byte x0)
            => X0 = x0;

        internal byte X0;
    }

    public struct Fixed16
    {
        [MethodImpl(Inline)]
        public static implicit operator Fixed16(ushort x0)
            => new Fixed16(x0);


        [MethodImpl(Inline)]
        public static implicit operator Fixed16(short x0)
            => new Fixed16((ushort)x0);

        [MethodImpl(Inline)]
        internal Fixed16(ushort x0)
            => X0 = x0;

        internal ushort X0;
    }

    public struct Fixed32
    {
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

        internal uint X0;
    }

    public struct Fixed64
    {
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

        internal ulong X0;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed128
    {
        [MethodImpl(Inline)]
        public static implicit operator Fixed128((ulong x0, ulong x1) x)
            => new Fixed128(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(in Pair<ulong> x)
            => new Fixed128(x.A,x.B);

        [MethodImpl(Inline)]
        internal Fixed128(ulong x0, ulong x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }
        
        internal ulong X0;

        ulong X1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed256
    {
        [MethodImpl(Inline)]
        public static implicit operator Fixed256((Fixed128 x0, Fixed128 x1) x)
            => new Fixed256(x.x0,x.x1);

        [MethodImpl(Inline)]
        internal Fixed256(Fixed128 x0, Fixed128 x1)
        {
            this.X0 = x0;
            this.X1 = x1;
        }

        internal Fixed128 X0;

        Fixed128 X1;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed512
    {
        internal Fixed256 X0;

        Fixed256 X1;
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Fixed1024
    {
        internal Fixed512 X0;

        Fixed512 X1;
        
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
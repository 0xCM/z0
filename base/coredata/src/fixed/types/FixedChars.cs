//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public interface IFixedChar : IFixed
    {
        ReadOnlySpan<char> Individuals {get;}
        
    }
    public interface IFixedChar<C> : IFixedChar
        where C : unmanaged    
    {
        int IFixed.BitCount
        {
            [MethodImpl(Inline)]
            get => bitsize<C>();
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char2 : IFixedChar<Char2>
    {
        public const int BitSize = 2*16;

        char C0;

        char C1;        

        [MethodImpl(Inline)]
        public static Char2 From(char c0, char c1)
            => new Char2(c0,c1);
        
        [MethodImpl(Inline)]
        Char2(char c0, char c1)
        {
            this.C0 = c0;
            this.C1 = c1;
        }
        
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        public unsafe ReadOnlySpan<char> Individuals
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<char>(Unsafe.AsPointer(ref this), BitSize/8);
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char4 : IFixedChar<Char4>
    {        
        public const int BitSize = 4*16;

        Char2 C0;

        Char2 C1; 

        [MethodImpl(Inline)]
        public static Char4 From(Char2 c0, Char2 c1)
            => new Char4(c0,c1);

        [MethodImpl(Inline)]
        public static Char4 From(char c0, char c1, char c2, char c3)
            => From(Char2.From(c0,c1), Char2.From(c2,c3));

        [MethodImpl(Inline)]
        Char4(Char2 c0, Char2 c1)
        {
            C0 = c0;
            C1 = c1;
        }

        public int BitCount
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        public unsafe ReadOnlySpan<char> Individuals
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<char>(Unsafe.AsPointer(ref this), BitSize/8);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char8 : IFixedChar<Char8>
    {
        public const int BitSize = 8*16;

        Char4 C0;

        Char4 C1;        

        [MethodImpl(Inline)]
        public static Char8 From(Char4 c0, Char4 c1)
            => new Char8(c0,c1);

        [MethodImpl(Inline)]
        public static Char8 From(char c0, char c1, char c2, char c3, char c4, char c5, char c6, char c7)
            => From(Char4.From(c0,c1,c2,c3), Char4.From(c4,c5, c7,c7));

        [MethodImpl(Inline)]
        Char8(Char4 c0, Char4 c1)
        {
            C0 = c0;
            C1 = c1;
        }

        public int BitCount
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        public unsafe ReadOnlySpan<char> Individuals
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<char>(Unsafe.AsPointer(ref this), BitSize/8);
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char16 : IFixedChar<Char16>
    {
        public const int BitSize = 16*16;

        Char8 C0;

        Char8 C1;        

        [MethodImpl(Inline)]
        public static Char16 From(Char8 c0, Char8 c1)
            => new Char16(c0,c1);

        [MethodImpl(Inline)]
        Char16(Char8 c0, Char8 c1)
        {
            C0 = c0;
            C1 = c1;
        }
 
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => BitSize;
        }

        public unsafe ReadOnlySpan<char> Individuals
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<char>(Unsafe.AsPointer(ref this), BitSize/8);
        }
   }


    [StructLayout(LayoutKind.Sequential)]
    public struct Char32
    {
        public const int BitSize = 32*16;

        internal Char16 C0;

        Char16 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char64
    {
        public const int BitSize = 64*16;

        internal Char32 C0;

        Char32 C1;        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Char128
    {
        public const int BitSize = 128*16;

        internal Char64 C0;

        Char64 C1;        
    }
}
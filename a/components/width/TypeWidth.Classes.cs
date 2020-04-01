//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using W = TypeWidth;

    public readonly struct W1 : ITypeWidth<W1>  
    { 
        [MethodImpl(Inline)]
        public static implicit operator int(W1 src)
            => (int)src.TypeWidth;

        public TypeWidth TypeWidth => W.W1; 

        [MethodImpl(Inline)]
        public bool Equals(W1 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W1;
    }

    public readonly struct W8 : ITypeWidth<W8> 
    { 
        [MethodImpl(Inline)]
        public static implicit operator int(W8 src)
            => (int)src.TypeWidth;

        public TypeWidth TypeWidth => W.W8; 

         public W64 Squared
         {
             [MethodImpl(Inline)]
             get => default;
         }

         public W16 Twice
         {
             [MethodImpl(Inline)]
             get => default;
         }

        [MethodImpl(Inline)]
        public bool Equals(W8 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W8;
    }

    public readonly struct W16 : ITypeWidth<W16> 
    { 
        [MethodImpl(Inline)]
        public static implicit operator int(W16 src)
            => (int)src.TypeWidth;

        public TypeWidth TypeWidth => W.W16; 

         public W8 Half
         {
             [MethodImpl(Inline)]
             get => default;
         }

         public W256 Squared
         {
             [MethodImpl(Inline)]
             get => default;
         }

         public W32 Twice
         {
             [MethodImpl(Inline)]
             get => default;
         }

        [MethodImpl(Inline)]
        public bool Equals(W16 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W16;
    }

    public readonly struct W32 : ITypeWidth<W32> 
    { 
        [MethodImpl(Inline)]
        public static implicit operator int(W32 src)
            => (int)src.TypeWidth;

        public TypeWidth TypeWidth => W.W32; 

         public W16 Half
         {
            [MethodImpl(Inline)]
             get => default;
         }

         public W64 Twice
         {
             [MethodImpl(Inline)]
             get => default;
         }

        [MethodImpl(Inline)]
        public bool Equals(W32 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W32;
    }

    public readonly struct W64 : ITypeWidth<W64> 
    {
        [MethodImpl(Inline)]
        public static implicit operator int(W64 src)
            => (int)src.TypeWidth;

         public TypeWidth TypeWidth => W.W64; 

         public W32 Half
         {
            [MethodImpl(Inline)]
             get => default;
         }

         public W128 Twice
         {
             [MethodImpl(Inline)]
             get => default;
         }

        [MethodImpl(Inline)]
        public bool Equals(W64 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W64;
    }

    public readonly struct W128 : ITypeWidth<W128> 
    {
        [MethodImpl(Inline)]
        public static implicit operator int(W128 src)
            => (int)src.TypeWidth;

         public TypeWidth TypeWidth => W.W128; 

         public W64 Half
         {
            [MethodImpl(Inline)]
             get => default;
         }

         public W256 Twice
         {
             [MethodImpl(Inline)]
             get => default;
         }

        [MethodImpl(Inline)]
        public bool Equals(W128 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W128;
    }

    public readonly struct W256 : ITypeWidth<W256> 
    {
        [MethodImpl(Inline)]
        public static implicit operator int(W256 src)
            => (int)src.TypeWidth;

         public TypeWidth TypeWidth => W.W256; 

         public W128 Half
         {
            [MethodImpl(Inline)]
             get => default;
         }

         public W512 Twice
         {
             [MethodImpl(Inline)]
             get => default;
         }

        [MethodImpl(Inline)]
        public bool Equals(W256 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W256;
    }

    public readonly struct W512 : ITypeWidth<W512> 
    {
        [MethodImpl(Inline)]
        public static implicit operator int(W512 src)
            => (int)src.TypeWidth;

         public TypeWidth TypeWidth => W.W512; 

         public W256 Half
         {
            [MethodImpl(Inline)]
             get => default;
         }

        [MethodImpl(Inline)]
        public bool Equals(W512 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W512;
    }

    public readonly struct W1024 : ITypeWidth<W1024> 
    {
        [MethodImpl(Inline)]
        public static implicit operator int(W1024 src)
            => (int)src.TypeWidth;

         public TypeWidth TypeWidth => W.W1024; 

         public W512 Half
         {
            [MethodImpl(Inline)]
             get => default;
         }

        [MethodImpl(Inline)]
        public bool Equals(W1024 w) => true;

        public override string ToString() 
            => ((ushort)TypeWidth).ToString();
        
        public override int GetHashCode()
            => TypeWidth.GetHashCode();
        
        public override bool Equals(object obj)
            => obj is W1024;
    }
}
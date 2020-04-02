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

}
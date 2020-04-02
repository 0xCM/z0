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

}
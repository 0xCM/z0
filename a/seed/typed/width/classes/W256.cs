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

}
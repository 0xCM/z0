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
}
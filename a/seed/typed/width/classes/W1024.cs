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
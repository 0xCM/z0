//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    public readonly struct VectorTypeKind : IVectorTypeKind
    {
        public VectorWidth VectorWidth {get;}

        public TypeWidth TypeWidth => (TypeWidth)VectorWidth;

        public DataWidth DataWidth => (DataWidth)VectorWidth;

        [MethodImpl(Inline)]
        public static implicit operator VectorTypeKind(VectorWidth width)
            => new VectorTypeKind(width);

        [MethodImpl(Inline)]
        public VectorTypeKind(VectorWidth width)
        {
            this.VectorWidth = width;
        }
    }        
}
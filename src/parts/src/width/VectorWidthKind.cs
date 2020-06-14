//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct VectorWidthKind : IVectorWidth
    {
        public VectorWidth VectorWidth {get;}

        public TypeWidth TypeWidth 
            => (TypeWidth)VectorWidth;

        public DataWidth DataWidth 
            => (DataWidth)VectorWidth;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidthKind(VectorWidth width)
            => new VectorWidthKind(width);

        [MethodImpl(Inline)]
        public VectorWidthKind(VectorWidth width)
        {
            VectorWidth = width;
        }
    }
}
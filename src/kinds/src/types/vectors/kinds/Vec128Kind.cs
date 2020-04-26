//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;

    public readonly struct Vec128Kind<T> : IVectorKind<Vec128Kind<T>,W128,T>
        where T : unmanaged
    {        
        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec128Kind<T> src)
            => VectorWidth.W128;
            
        [MethodImpl(Inline)]
        public static implicit operator Vec128Type(Vec128Kind<T> src)
            => default;

        public VectorWidth Width => VectorWidth.W128;

        public NumericKind CellKind => NumericKinds.kind<T>();

        public NumericWidth CellWidth => (NumericWidth)Widths.measure<T>();

        public Type TypeDefinition => typeof(Vector128<T>).GenericDefinition2();
    }        
}
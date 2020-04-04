//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface INumericKind : IKind, ILiteralKind<NumericKind>
    {
        
    }

    public interface INumericKind<T> : INumericKind, ITypeKind<T>
        where T : unmanaged
    {
        TypeWidth Width => (TypeWidth)bitsize<T>();            
                
        NumericKind ITypedLiteral<NumericKind>.Class 
            => NumericKinds.kind<T>();
    }
}
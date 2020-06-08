//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INumericKind : IKind, ILiteralKind<NumericKind>
    {
        
    }

    public interface INumericKind<T> : INumericKind
        where T : unmanaged
    {
        TypeWidth Width => (TypeWidth)NumericKinds.bitsize<T>();            
                
        NumericKind ITypedLiteral<NumericKind>.Class 
            => NumericKinds.kind<T>();
    }
}
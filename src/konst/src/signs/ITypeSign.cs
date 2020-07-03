//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using NK = NumericKind;
    
    public interface ITypeSign
    {
        TypeSignKind Sign {get;}
    }
    
    public interface ITypeSign<S> : ITypeSign, ITypedLiteral<TypeSignKind,sbyte>
        where S : unmanaged, ITypeSign<S> 
    {
        sbyte ITypedLiteral<TypeSignKind,sbyte>.Value
            => (sbyte)Sign;

        TypeSignKind ITypedLiteral<TypeSignKind>.Class
            => Sign;
    }

}
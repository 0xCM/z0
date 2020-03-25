//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public interface INumericKind : IKind
    {
        
    }

    public interface INumericKind<T> : INumericKind, ITypeKind<T>
        where T : unmanaged
    {
        TypeWidth Width => (TypeWidth)bitsize<T>();            

        NumericKind NumericKind { [MethodImpl(Inline)] get=> NumericTypes.kind<T>();}
    }
}
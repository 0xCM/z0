//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface INumericKind<T> : ITypeKind<T>
        where T : unmanaged
    {
        TypeWidth Width => (TypeWidth)bitsize<T>();            

        NumericKind NumericKind { [MethodImpl(Inline)] get=> NumericKinds.kind<T>();}
    }
}
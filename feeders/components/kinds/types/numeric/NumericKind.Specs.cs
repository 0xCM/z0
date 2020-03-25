//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    using NK = NumericKind;

    public interface INumericKind : IKind
    {
        
    }

    public interface INumericKind<T> : INumericKind, IFixedWidth
        where T : unmanaged
    {
        FixedWidth IFixedWidth.FixedWidth => (FixedWidth)bitsize<T>();            

        NumericKind NumericKind { [MethodImpl(Inline)] get=> NumericTypes.kind<T>();}
    }
}
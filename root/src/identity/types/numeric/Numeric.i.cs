//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface INumericKind : IKind<NumericKind>,  IIdentity<NumericKinded>
    {
        
    }

    public interface INumericKind<T> : INumericKind, IKind<NumericKind>, IFixedWidth
        where T : unmanaged
    {
        FixedWidth IFixedWidth.FixedWidth => (FixedWidth)bitsize<T>();            

        NumericKind IKind<NumericKind>.Class { [MethodImpl(Inline)] get=> NumericIdentity.kind<T>();}

        string IIdentity.Identifier => NumericIdentity.kind<T>().Format();
    }

}
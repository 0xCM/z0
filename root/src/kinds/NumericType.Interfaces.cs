//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public interface INumericType : ITypeKind<NumericKind>
    {        
    
    }

    public interface INumericType<T> : INumericType, IFixedWidth
        where T : unmanaged
    {
        FixedWidth IFixedWidth.FixedWidth => (FixedWidth)bitsize<T>();            

        NumericKind NumericKind { [MethodImpl(Inline)] get=> Numeric.kind<T>();}
    }
}
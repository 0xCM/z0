//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface INumericTypeKind : ITypeKind<NumericKind>
    {        
    
    }

    public interface INumericTypeKind<T> : INumericTypeKind, IFixedWidth
        where T : unmanaged
    {
        FixedWidth IFixedWidth.FixedWidth => (FixedWidth)bitsize<T>();            

        NumericKind NumericKind { [MethodImpl(Inline)] get=> Numeric.kind<T>();}
    }

    public readonly struct NumericTypeKind<T> : INumericTypeKind<T> 
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public static implicit operator NumericKind(NumericTypeKind<T> src)
            => Numeric.kind<T>();
    }
}
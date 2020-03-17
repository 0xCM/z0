//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Chracterizes a numeric thing
    /// </summary>
    public interface INumeric : IComparable, IConvertible, IFormattable
    {

    }

    /// <summary>
    /// Chracterizes a parametric numeric thing
    /// </summary>
    public interface INumeric<T> : IComparable<T>, IConvertible, IFormattable, IEquatable<T>
        where T : unmanaged
    {
        
    }

    public interface INumericKind : IKind<NumericKind>,  IIdentity<NumericKinded>
    {
        
    }

    public interface INumericKind<T> : INumericKind, IKind<NumericKind>, IFixedWidth
        where T : unmanaged
    {
        FixedWidth IFixedWidth.FixedWidth => (FixedWidth)bitsize<T>();            

        NumericKind IKind<NumericKind>.Class { [MethodImpl(Inline)] get=> Numeric.kind<T>();}

        string IIdentity.Identifier => Numeric.kind<T>().Format();
    }
}
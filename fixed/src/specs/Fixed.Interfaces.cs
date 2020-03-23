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
    /// Characterizes a type that is naturally-parametric with natural widths that can be specified as a fixed-width
    /// </summary>
    /// <typeparam name="W">The natural width type</typeparam>
    public interface IFixedWidth<W> : IFixedWidth
        where W : unmanaged, ITypeNat
    {
        FixedWidth IFixedWidth.FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)NatMath2.natval<W>();
        }
    }

    public interface IFixed<C,F> : IFixed<F>
        where F : unmanaged, IFixed
        where C : IFixed<C,F>
    {
        
    }

    public interface IFixedChar : IFixed
    {
        ReadOnlySpan<char> Individuals {get;}        
    }

    public interface IFixedChar<C> : IFixedChar
        where C : unmanaged    
    {
        int IFixed.BitWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<C>();
        }                       
    }

    public interface IFixedNumeric<T> : IFixed<T>, IFixedWidth
        where T : unmanaged        
    {
        T Data {get;set;}

        NumericKind NumericKind
        {
            [MethodImpl(Inline)]
            get => typeof(T).NumericKind();
        }

        FixedWidth IFixedWidth.FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)bitsize<T>();
        }

        int IFixed.BitWidth
        {
            [MethodImpl(Inline)]
            get => (int)bitsize<T>();
        }    
    }

    public interface IFixedNumeric<F,T> : IFixedNumeric<T>, IEquatable<F>
        where F : unmanaged, IFixedNumeric<F,T>
        where T : unmanaged
    {

    }    
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    public interface ISymbol<S>
        where S : unmanaged
    {
        /// <summary>
        /// The symbol value
        /// </summary>
        S Value {get;}
    }

    public interface ISymbol<S,T> : ISymbol<S>    
        where S : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        ushort SegWidth 
            => (ushort)bitsize<T>();

        /// <summary>
        /// The symbol value, from storage cell persective
        /// </summary>
        T Cell
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<S,T>(ref edit(Value));
        }                     
    }

    public interface ISymbol<S,N,T> : ISymbol<S,T>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        /// <summary>
        /// The bit-width of a symbol
        /// </summary>
        ushort SymWidth 
            => (ushort)value<N>();
        
        /// <summary>
        /// The maximum number of symbols that can be packed into a storage cell
        /// </summary>
        ushort Capacity 
            => (ushort)(SegWidth/SymWidth);
    }
}
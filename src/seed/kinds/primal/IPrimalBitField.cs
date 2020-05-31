//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IPrimalBitField
    {

    }

    public interface IPrimalBitField<T> : IPrimalBitField
        where T : unmanaged 
    {
        /// <summary>
        /// The raw bitfield data
        /// </summary>
        T FieldData {get;}
    }

    public interface IFieldRefinement<V> : IPrimalBitField
        where V : unmanaged, Enum
    {
        /// <summary>
        /// The refined bitfield data
        /// </summary>
        V FieldValue {get;}
    }

    public interface IPrimalBitField<V,T> : IFieldRefinement<V>, IPrimalBitField<T>
        where V : unmanaged, Enum
        where T : unmanaged
    {

    }

    public interface IIndexedField<I> : IPrimalBitField
        where I : unmanaged, Enum
    {

    }

    public interface IPrimalField<I,T> : IPrimalBitField<T>, IIndexedField<I>
        where I : unmanaged, Enum
        where T : unmanaged 
    {
        /// <summary>
        /// Retreives a T-valued I-identified segment
        /// </summary>
        /// <param name="index">The field index identifier</param>
        T Data(I index);        
    }

    /// <summary>
    /// Characterizes an I-indexed bitfield defined over corresponding S-indexed segments
    /// </summary>
    /// <typeparam name="I">The bitfield index type</typeparam>
    /// <typeparam name="S">The segmentation type</typeparam>
    public interface ISegmentedField<I,S> : IIndexedField<I>
        where I : unmanaged, Enum
        where S : unmanaged, Enum
    {
        /// <summary>
        /// Retrieves an I-identified segment
        /// </summary>
        /// <param name="index">The field index identifier</param>
        S Index(I index);
    }

    public interface IMaskedField<I,M> : IIndexedField<I>
        where M : unmanaged, Enum
        where I : unmanaged, Enum
    {
        /// <summary>
        /// Retrieves an I-identified mask
        /// </summary>
        /// <param name="index">The field index identifier</param>
        M Mask(I index);
    }


    /// <summary>
    /// Characterizes a bitfied predicated on a seqeunce primal types
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="I">The bifield index type that defines 0-based sequentail identifier corresponding to each bitfield segment</typeparam>
    /// <typeparam name="V">The type of value over which the bitfield is defined</typeparam>
    /// <typeparam name="S">The bitfield segment type</typeparam>
    /// <typeparam name="M">The bitfield mask type</typeparam>
    /// <typeparam name="T">The raw bitfield data type with width equal or greater than the bitfield value type</typeparam>
    public interface IPrimalBitField<F,V,T,I,W,S,M> :        
         IPrimalBitField<V,T>, 
         IPrimalField<I,T>,
         ISegmentedField<I,S>, 
         IMaskedField<I,M>
        where F : struct, IPrimalBitField<F,V,T,I,W,S,M>
        where I : unmanaged, Enum
        where W : unmanaged, Enum
        where V : unmanaged, Enum
        where S : unmanaged, Enum
        where M : unmanaged, Enum
        where T : unmanaged 
    {        
        
    }
}
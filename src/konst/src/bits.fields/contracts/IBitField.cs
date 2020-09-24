//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IBitField
    {

    }

    /// <summary>
    /// Characterizes a content-parametric bitfield
    /// </summary>
    /// <typeparam name="T">The bitfield content type</typeparam>
    public interface IBitField<T> : IBitField
        where T : unmanaged
    {
        /// <summary>
        /// The raw bitfield data
        /// </summary>
        T Content {get;}
    }

    /// <summary>
    /// Characterizes a content and index-parametric bitfield
    /// </summary>
    /// <typeparam name="I">The bitfield index type that defines 0-based sequential index corresponding to each bitfield segment</typeparam>
    /// <typeparam name="T">The bitfield content type</typeparam>
    public interface IBitField<I,T> : IBitField<T>
        where I : unmanaged
        where T : unmanaged
    {

    }

   public interface IRefinedBitField<F,T> : IBitField<T>
        where F : unmanaged, Enum
        where T : unmanaged
    {
        F Kind {get;}

        T IBitField<T>.Content
            => EnumValue.scalar<F,T>(Kind);
    }

    /// <summary>
    /// Characterizes a bitfield from which segments can be specified/extracted
    /// </summary>
    /// <typeparam name="I">The bifield index type that defines 0-based sequential index corresponding to each bitfield segment</typeparam>
    /// <typeparam name="P">The bitfield position type</typeparam>
    /// <typeparam name="T">The bitfield content type from which segments are extracted/specified</typeparam>
    public interface IBitField<I,P,T> : IBitField<I,T>
        where I : unmanaged, Enum
        where P : unmanaged
        where T : unmanaged
    {
        P Position(I index);
    }

    /// <summary>
    /// Characterizes a reified bitfield predicated on 3 type parameters
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="I">The bifield index type that defines 0-based sequential index corresponding to each bitfield segment</typeparam>
    /// <typeparam name="P">The bitfield position type</typeparam>
    /// <typeparam name="T">The bitfield content type from which segments are extracted/specified</typeparam>
    public interface IBitField<I,P,T,S> : IBitField<I,P,T>
        where I : unmanaged, Enum
        where P : unmanaged
        where T : unmanaged
        where S : unmanaged
    {
        S Segment(I index);

        void Segment(I index, S value);

        S this[I index]
        {
            [MethodImpl(Inline)]
            get => Segment(index);

            [MethodImpl(Inline)]
            set => Segment(index, value);
        }
    }

    /// <summary>
    /// Characterizes a reified bitfield predicated on 4 type parameters
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="I">The bifield index type that defines 0-based sequential index corresponding to each bitfield segment</typeparam>
    /// <typeparam name="P">The bitfield segment type</typeparam>
    /// <typeparam name="T">The bitfield content type from which segments are extracted/specified</typeparam>
    /// <typeparam name="W">The bitfield segment width type</typeparam>
    public interface IBitField<F,I,P,T,S,W> : IBitField<I,P,T,S>
        where F : struct, IBitField<F,I,P,T,S,W>
        where I : unmanaged, Enum
        where P : unmanaged
        where T : unmanaged
        where S : unmanaged
        where W : unmanaged
    {
        W Width(I index);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IFieldIndices<I>
        where I : unmanaged, Enum
    {
        ReadOnlySpan<I> fields();

        I field(int index);
    }

    public interface IFieldSpecs<I,E>
        where I : unmanaged, Enum
        where E : unmanaged, Enum
    {

    }

    public interface IFieldSegments<I,S>
        where S : unmanaged, Enum
        where I : unmanaged, Enum

    {
        /// <summary>
        /// Specifies I-indexed segments that constitute the field
        /// </summary>
        ReadOnlySpan<S> segments();

        S segment(I index);
    }

    public interface IFieldWidths<I,W>
        where I : unmanaged, Enum
        where W : unmanaged, Enum
    {
        ReadOnlySpan<W> Widths {get;}

        W Width(I index);
    }


    public interface IFieldMasks<I,M>
        where I : unmanaged, Enum
        where M : unmanaged, Enum
    {
        ReadOnlySpan<M> masks();

        M mask(I index);
    }
}
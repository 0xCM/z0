//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFieldIndexEntry
    {
        /// <summary>
        /// The zero-based and sequential field index
        /// </summary>
        uint FieldIndex {get;}

        /// <summary>
        /// The field name
        /// </summary>
        string FieldName {get;}

        /// <summary>
        /// The number of bits covered by the field
        /// </summary>
        uint FieldWidth {get;}
    }

    public interface IBitFieldIndexEntry<F> : IBitFieldIndexEntry, IEquatable<F>, IComparable<F>
    {

    }

    public interface IBitFieldIndexEntry<F,W> : IBitFieldIndexEntry<F>
        where F : IBitFieldIndexEntry
        where W : unmanaged
    {
        /// <summary>
        /// The number of bits covered by the field
        /// </summary>
        new W FieldWidth {get;}

        uint IBitFieldIndexEntry.FieldWidth
            => memory.uint32(FieldWidth);
    }

    public interface IBitFieldIndexEntry<F,E,W> : IBitFieldIndexEntry<F,W>
       where F : IBitFieldIndexEntry
       where E : unmanaged
       where W : unmanaged
    {
        /// <summary>
        /// The zero-based and sequential field index
        /// </summary>
        new E FieldIndex {get;}

        uint IBitFieldIndexEntry.FieldIndex
            => memory.@as<E,uint>(FieldIndex);

        string IBitFieldIndexEntry.FieldName
            => FieldIndex.ToString();
    }
}
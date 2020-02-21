//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public interface IFieldIndex<E>
        where E : IFieldIndexEntry
    {
        ReadOnlySpan<E> Entries {get;}
    }

    public interface IFieldIndexEntry
    {
        /// <summary>
        /// The zero-based and sequential field index
        /// </summary>
        int FieldIndex {get;}

        /// <summary>
        /// The field name
        /// </summary>
        string FieldName {get;}

        /// <summary>
        /// The number of bits covered by the field
        /// </summary>
        Enum FieldWidth {get;}
    }

    public interface IFieldIndexEntry<F> : IFieldIndexEntry, IFormattable<F>, IEquatable<F>, IComparable<F>
    {
    }

    public interface IFieldIndexEntry<F,W> : IFieldIndexEntry<F>
        where F : IFieldIndexEntry
        where W : unmanaged, Enum
    {
        /// <summary>
        /// The number of bits covered by the field
        /// </summary>
        new W FieldWidth {get;}

        Enum IFieldIndexEntry.FieldWidth 
            => FieldWidth;
    }

    public interface IFieldIndexEntry<F,I,W> : IFieldIndexEntry<F,W>
       where F : IFieldIndexEntry
       where I : unmanaged, Enum
       where W : unmanaged, Enum     
    {
        /// <summary>
        /// The zero-based and sequential field index
        /// </summary>
        new I FieldIndex {get;}
        
        int IFieldIndexEntry.FieldIndex
        {
            [MethodImpl(Inline)]            
            get => evalue<I,int>(FieldIndex);
        }

        string IFieldIndexEntry.FieldName
        {
            [MethodImpl(Inline)]            
            get => FieldIndex.ToString();
        }
    }
}
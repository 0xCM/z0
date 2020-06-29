//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public interface IBitFieldIndexEntry
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

    public interface IBitFieldIndexEntry<F> : IBitFieldIndexEntry, IEquatable<F>, IComparable<F>
    {
   
    }

    public interface IBitFieldIndexEntry<F,W> : IBitFieldIndexEntry<F>
        where F : IBitFieldIndexEntry
        where W : unmanaged, Enum
    {
        /// <summary>
        /// The number of bits covered by the field
        /// </summary>
        new W FieldWidth {get;}

        Enum IBitFieldIndexEntry.FieldWidth 
            => FieldWidth;
    }

    public interface IBitFieldIndexEntry<F,E,W> : IBitFieldIndexEntry<F,W>
       where F : IBitFieldIndexEntry
       where E : unmanaged, Enum
       where W : unmanaged, Enum     
    {
        /// <summary>
        /// The zero-based and sequential field index
        /// </summary>
        new E FieldIndex {get;}
        
        int IBitFieldIndexEntry.FieldIndex
        {
            [MethodImpl(Inline)]            
            get => Enums.scalar<E,int>(FieldIndex);
        }

        string IBitFieldIndexEntry.FieldName
        {
            [MethodImpl(Inline)]            
            get => FieldIndex.ToString();
        }
    }
}
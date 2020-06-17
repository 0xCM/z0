//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

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

    public interface IFieldIndexEntry<F> : IFieldIndexEntry, ITextual, IEquatable<F>, IComparable<F>
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

    public interface IFieldIndexEntry<F,E,W> : IFieldIndexEntry<F,W>
       where F : IFieldIndexEntry
       where E : unmanaged, Enum
       where W : unmanaged, Enum     
    {
        /// <summary>
        /// The zero-based and sequential field index
        /// </summary>
        new E FieldIndex {get;}
        
        int IFieldIndexEntry.FieldIndex
        {
            [MethodImpl(Inline)]            
            get => Enums.scalar<E,int>(FieldIndex);
        }

        string IFieldIndexEntry.FieldName
        {
            [MethodImpl(Inline)]            
            get => FieldIndex.ToString();
        }
    }
}
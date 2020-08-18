//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Defines an E-V parametric literal index
    /// </summary>
     public readonly struct EnumLiteralDetails<E,P> : IEnumerable<EnumLiteralDetail<E,P>>, IConstIndex<EnumLiteralDetail<E,P>>
        where E : unmanaged, Enum
        where P : unmanaged
    {
        readonly EnumLiteralDetail<E,P>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiteralDetails<E,P>(EnumLiteralDetail<E,P>[] src)
            => new EnumLiteralDetails<E,P>(src);

        [MethodImpl(Inline)]
        public EnumLiteralDetails(EnumLiteralDetail<E,P>[] src) 
            => Data = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public EnumLiteralDetail<E,P>[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref readonly EnumLiteralDetail<E,P> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref readonly EnumLiteralDetail<E,P> this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public IEnumerator<EnumLiteralDetail<E,P>> GetEnumerator()
            => ((IEnumerable<EnumLiteralDetail<E,P>>)Data).GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
            => Data.GetEnumerator();

        public EnumLiteralDetails<E> Indices
            => Enums.index<E>();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    /// <summary>
    /// Defines an E-parametric literal index
    /// </summary>
    [ApiProviderAttribute(DataIndex)]
    public readonly struct EnumLiteralDetails<E> : IIndex<EnumLiteralDetail<E>>
        where E : unmanaged, Enum
    {
        readonly EnumLiteralDetail<E>[] Data;

        [MethodImpl(Inline)]
        internal EnumLiteralDetails(EnumLiteralDetail<E>[] src)
            => Data = src;

        public EnumLiteralDetail<E>[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly EnumLiteralDetail<E> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref readonly EnumLiteralDetail<E> this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public E[] LiteralValues
        {
            [MethodImpl(Inline)]
            get => Data.Map(x => x.LiteralValue);
        }

        public F[] Convert<F>()
            where F : unmanaged, Enum
        {
            var src = LiteralValues;
            var dst = new F[src.Length];

            for(var i=0; i< src.Length; i++)
                dst[i] = (F)(object)src[i];
            return dst;
        }

        public IEnumerable<NamedValue<E>> NamedValues
            => from i in Data select NamedValue.define(i.Name, i.LiteralValue);

        public EnumLiteralDetail<E>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator EnumLiteralDetails<E>(EnumLiteralDetail<E>[] src)
            => new EnumLiteralDetails<E>(src);

        // public IEnumerator<EnumLiteralDetail<E>> GetEnumerator()
        //     => ((IEnumerable<EnumLiteralDetail<E>>)Data).GetEnumerator();

        // IEnumerator IEnumerable.GetEnumerator()
        //     => Data.GetEnumerator();
    }
}
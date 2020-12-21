// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IConstIndex<T> : ISeq<T>, IMeasured, IEnumerable<T>, ITextual
    {
        ref readonly T First
            => ref first(Items);

        ref readonly T Last
            => ref skip(Items, Length - 1);

        ref readonly T this[long index]
            => ref memory.skip(Items, index);

        ref readonly T this[ulong index]
            => ref memory.skip(Items, index);

        ref readonly T Lookup(long index)
            => ref memory.skip(Items,index);

        ref readonly T Lookup(ulong index)
            => ref memory.skip(Items,index);

        int IMeasured.Length
            => Items.Length;

        bool INullity.IsEmpty
            => Length == 0;

        string ITextual.Format()
            => string.Format("({0}:{1})*", typeof(T).Name, Length);

        IEnumerator IEnumerable.GetEnumerator()
            => Index.enumerator(Items);

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Index.enumerator(Items);
    }
}
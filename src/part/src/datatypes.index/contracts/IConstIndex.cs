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
    public interface IConstIndex<T> : IMeasured, IEnumerable<T>, ITextual
    {
        ReadOnlySpan<T> Terms {get;}

        ref readonly T First
            => ref first(Terms);

        ref readonly T Last
            => ref skip(Terms, Length - 1);

        ref readonly T this[long index]
            => ref memory.skip(Terms, index);

        ref readonly T this[ulong index]
            => ref memory.skip(Terms, index);

        ref readonly T Lookup(long index)
            => ref memory.skip(Terms,index);

        ref readonly T Lookup(ulong index)
            => ref memory.skip(Terms,index);

        int IMeasured.Length
            => Terms.Length;

        bool INullity.IsEmpty
            => Length == 0;

        string ITextual.Format()
            => string.Format("({0}:{1})*", typeof(T).Name, Length);

        IEnumerator IEnumerable.GetEnumerator()
            => Index.enumerator(Terms);

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Index.enumerator(Terms);
    }
}
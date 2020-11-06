//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IIndexedView<T> : INullity, IMeasured, ITextual
    {
        T[] Storage {get;}


        ReadOnlySpan<T> Terms
            => Storage;

        ref readonly T this[long index]
            => ref z.skip(Terms, index);

        ref readonly T this[ulong index]
            => ref z.skip(Terms, index);

        int IMeasured.Length
            => Terms.Length;

        bool INullity.IsEmpty
            => Length == 0;

        bool INullity.IsNonEmpty
            => Length != 0;

        string ITextual.Format()
            => z.delimit(Storage).Format();
    }

    [Free]
    public interface IIndexedView<I,T> : IIndexedView<T>, IMeasured<I>
        where I : unmanaged
    {
        ref readonly T this[I index]
            => ref z.skip(Terms,z.@as<I,uint>(index));

        int IMeasured.Length
            => Terms.Length;

        I IMeasured<I>.Length
            => z.@as<uint,I>((uint)Terms.Length);

        I ICounted<I>.Count
            => z.@as<uint,I>((uint)Terms.Length);
    }

    [Free]
    public interface IIndexedView<H,I,T> : IIndexedView<I,T>
        where I : unmanaged
        where H : IIndexedView<H,I,T>, new()
    {

    }
}
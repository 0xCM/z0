//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdName : ITextual, IName<string>, INullity, IHashed
    {
        uint IHashed.Hash
            => (uint)(Content?.GetHashCode() ?? 0);

        string ITextual.Format()
            => Content ?? string.Empty;
    }

    [Free]
    public interface ICmdName<T> : ICmdName, IEquatable<T>, IHashed
        where T : struct, ICmdName<T>
    {
        bool IEquatable<T>.Equals(T src)
            => text.equals(Content, src.Content);
    }
}

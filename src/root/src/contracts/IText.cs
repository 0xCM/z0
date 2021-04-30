//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IText : ITextual, INullity
    {
        string Text {get;}

        ReadOnlySpan<char> Data => Text;

        int Length => Text?.Length ?? 0;

        bool INullity.IsEmpty => Length == 0;

        bool INullity.IsNonEmpty => Length != 0;

        string ITextual.Format()
            => Text;
    }

    public interface IText<T> : IText, IEquatable<T>, IComparable<T>
        where T : IText<T>
    {
        bool IEquatable<T>.Equals(T src)
            => string.Equals(Text, src.Text);

        int IComparable<T>.CompareTo(T src)
            => Text?.CompareTo(src.Text) ?? 0;
    }
}
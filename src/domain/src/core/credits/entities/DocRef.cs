//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CreditTypes;

    using E = DocRef;
    using S = System.UInt64;
    using API = Credits;

    /// <summary>
    /// Defines a reference to document content
    /// </summary>
    public readonly struct DocRef : IDataEntity<E>
    {
        readonly S State;

        public static E Empty => new E(0);

        public E Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => State == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => State != 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator E(S src)
            => new DocRef(src);

        [MethodImpl(Inline)]
        public static implicit operator S(E src)
            => src.State;

        [MethodImpl(Inline)]
        public bool Equals(E src)
            => State == src.State;

        [MethodImpl(Inline)]
        public string Format()
            => API.format(this);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => State.GetHashCode();

        public override bool Equals(object src)
            => src is E entity && Equals(entity);

        [MethodImpl(Inline)]
        public DocRef(S data)
            => State = data;

        public Vendor Vendor
        {
            [MethodImpl(Inline)]
            get => API.vendor(this);
        }

        public Volume Volume
        {
            [MethodImpl(Inline)]
            get => API.volume(this);
        }

        public Division Division
        {
            [MethodImpl(Inline)]
            get => API.division(this);
        }

        public Chapter Chapter
        {
            [MethodImpl(Inline)]
            get => API.chapter(this);
        }

        public Appendix Appendix
        {
            [MethodImpl(Inline)]
            get => API.appendix(this);
        }

        public Section Section
        {
            [MethodImpl(Inline)]
            get => API.section(this);
        }

        public Topic Topic
        {
            [MethodImpl(Inline)]
            get => API.topic(this);
        }

        public ContentRef Content
        {
            [MethodImpl(Inline)]
            get => API.content(this);
        }
    }
}
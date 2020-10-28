//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static CreditTypes;

    using E = ContentRef;
    using S = System.UInt16;
    using API = Credits;

    /// <summary>
    /// Defines a reference to specialized content within a document, such as figures and tables
    /// that often, as a flagrant display of idiocy, have numbering schemes that are content-type
    /// independent and even doucment-location independent
    /// </summary>
    public readonly struct ContentRef : IDataEntity<E>
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
        public static implicit operator E(S data)
            => new ContentRef(data);

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
        public ContentRef(S src)
            => State = src;

        /// <summary>
        /// The level-0 content number
        /// </summary>
        public ContentNumber Level0
        {
            [MethodImpl(Inline)]
            get => API.number(this, n0);
        }

        /// <summary>
        /// The level-1 content number (if any)
        /// </summary>
        public ContentNumber Level1
        {
            [MethodImpl(Inline)]
            get => API.number(this, n1);
        }

        /// <summary>
        /// The level-2 content number (if any)
        /// </summary>
        public ContentNumber Level2
        {
            [MethodImpl(Inline)]
            get => API.number(this, n2);
        }

        /// <summary>
        /// The type of referenced content
        /// </summary>
        public ContentType ContentType
        {
            [MethodImpl(Inline)]
            get => API.type(this);
        }

    }
}
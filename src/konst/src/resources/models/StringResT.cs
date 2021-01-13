//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents an identified string resource
    /// </summary>
    public readonly struct StringRes<E> : ITextual
        where E : unmanaged
    {
        /// <summary>
        /// The resource identifier
        /// </summary>
        public E Identifier {get;}

        /// <summary>
        /// The resource address
        /// </summary>
        public MemoryAddress Address {get;}

        /// <summary>
        /// The resource value extracted from the accompanying location
        /// </summary>
        public uint Length {get;}

        [MethodImpl(Inline)]
        public StringRes(E id, MemoryAddress address, uint length)
        {
            Identifier = id;
            Address = address;
            Length = length;
        }

        [MethodImpl(Inline)]
        public string Format()
            => StringRef.create(Address, Length).Format();

        public override string ToString()
            => Format();
    }
}
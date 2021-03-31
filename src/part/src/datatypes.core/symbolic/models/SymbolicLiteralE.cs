//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct SymbolicLiteral<E> : IComparableRecord<SymbolicLiteral<E>>
    {
        /// <summary>
        /// The component that defines the literal
        /// </summary>
        public ClrAssemblyName Component;

        /// <summary>
        /// The literal's declaring type
        /// </summary>
        public Identifier Type;

        /// <summary>
        /// The container-relative declaration order of the literal
        /// </summary>
        public ushort Position;

        /// <summary>
        /// The literal name
        /// </summary>
        public Identifier Name;

        /// <summary>
        /// A global identifier
        /// </summary>
        public SymIdentity Identity;

        /// <summary>
        /// The literal's primitive classifier
        /// </summary>
        public ClrPrimalKind DataType;

        /// <summary>
        /// The encoded literal, possibly an invariant address to a string resource
        /// </summary>
        public ulong EncodedValue;

        public E DirectValue;

        /// <summary>
        /// The symbol, if so attributed, otherwise, the identifier
        /// </summary>
        public string Symbol;

        /// <summary>
        /// The meaning of the literal, if available; otherwise empty
        /// </summary>
        public TextBlock Description;

        [MethodImpl(Inline)]
        public int CompareTo(SymbolicLiteral<E> src)
            => Identity.CompareTo(src.Identity);
    }
}
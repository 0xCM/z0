//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;
    using static AsciResourceSet;

    public readonly ref struct AsciResourceSet<A>
        where A : unmanaged, IAsciSequence
    {
        /// <summary>
        /// The resource set name
        /// </summary>
        public readonly asci32 Name;

        internal readonly ReadOnlySpan<byte> Content;

        public readonly asci64 Description;

        /// <summary>
        /// The resource entry count
        /// </summary>
        public int EntryCount
        {
            [MethodImpl(Inline)]
            get => EntryCount<A>(Content.Length);
        }

        /// <summary>
        /// Retrives an index-identified resource
        /// </summary>
        /// <param name="index">The resource index in the range [0..Count-1]</param>
        [MethodImpl(Inline)]
        public ref readonly A Entry(int index)
        {
            ref readonly var cell = ref LeadingCell(Content, index);
            return ref Unsafe.As<byte,A>(ref edit(cell));
        }

        /// <summary>
        /// Retrives an index-identified resource
        /// </summary>
        /// <param name="index">The resource index in the range [0..Count-1]</param>
        public ref readonly A this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Entry(index);
        }

        [MethodImpl(Inline)]
        internal AsciResourceSet(in asci32 name, ReadOnlySpan<byte> content, asci64? description = null)
        {
            Name = name;
            Content = content;
            Description = description ?? asci64.Null;
        }              

        [MethodImpl(Inline)]
        internal static ref readonly byte LeadingCell(ReadOnlySpan<byte> content, int index)
            => ref Control.skip(content, EntryOffset<A>(index));
    }
}
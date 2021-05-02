//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static memory;

    using api = CharBlocks;
    using B = CharBlock4;

    /// <summary>
    /// Defines a character block b with capacity(b) = 4x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock4 : ICharBlock<B>
    {
        CharBlock2 Lo;

        CharBlock2 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<B,char>(this, CharCount);
        }

        /// <summary>
        /// Specifies a reference to the leading cell
        /// </summary>
        public ref char First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => CharCount;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator B(string src)
            => api.init(src, out B dst);

        public static B Empty => RP.Spaced4;

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 4;

        /// <summary>
        /// The size of the block, in bytes
        /// </summary>
        public const uint Size = CharCount * 2;
    }
}
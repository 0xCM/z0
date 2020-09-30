//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using api = CharBlocks;

    /// <summary>
    /// Defines a character block b with capacity(b) = 4x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock4 : ICharBlock<CharBlock4>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock2 Lo;

        public CharBlock2 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock4,char>(this, CharCount);
        }

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 4;
    }
}
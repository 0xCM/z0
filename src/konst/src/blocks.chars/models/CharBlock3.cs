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
    /// Defines a character block b with capacity(b) = 3x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock3 : ICharBlock<CharBlock3>
    {
        /// <summary>
        /// The lower content
        /// </summary>
        public CharBlock2 Lo;

        public CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
           get => cover<CharBlock3,char>(this, CharCount);
        }

        /// <summary>
        /// The block capacity
        /// </summary>
        public const ushort CharCount = 3;
    }
}
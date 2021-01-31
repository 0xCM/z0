//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;

    using api = CharBlocks;

    /// <summary>
    /// Defines a character block b with capacity(b) = 13x16u
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CharBlock13 : ICharBlock<CharBlock13>
    {
        /// <summary>
        /// The upper segment
        /// </summary>
        public CharBlock12 Lo;

        /// <summary>
        /// The upper content
        /// </summary>
        public CharBlock1 Hi;

        /// <summary>
        /// The block content presented as an editable buffer
        /// </summary>
        public Span<char> Data
        {
            [MethodImpl(Inline)]
            get => cover<CharBlock13,char>(this, CharCount);
        }

        /// <summary>
        /// Specifies a reference to the leading cell
        /// </summary>
        public ref char First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator CharBlock13(string src)
            => api.init(src, out CharBlock13 dst);

        public const ushort CharCount = 13;
    }
}
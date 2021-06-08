//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmFragment : ITextual
    {
        /// <summary>
        /// The content origin
        /// </summary>
        public GridPoint<uint> Location {get;}

        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmFragment(GridPoint<uint> location, TextBlock content)
        {
            Location = location;
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content.ToString();

        public override string ToString()
            => Format();
    }
}
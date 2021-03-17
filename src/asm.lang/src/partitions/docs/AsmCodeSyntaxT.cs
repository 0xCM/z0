//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmCodeSyntax<T> : ITextual
        where T : ITextual
    {
        /// <summary>
        /// The content origin
        /// </summary>
        public GridPoint<uint> Location {get;}

        /// <summary>
        /// The line content
        /// </summary>
        public T Content {get;}

        [MethodImpl(Inline)]
        public AsmCodeSyntax(GridPoint<uint> location, T content)
        {
            Location = location;
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public static implicit operator AsmCodeSyntax(AsmCodeSyntax<T> src)
            => new AsmCodeSyntax(src.Location, src.Content);
    }
}
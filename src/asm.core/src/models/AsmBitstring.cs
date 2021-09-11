//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a sequence of bits that specifies an instruction encoding
    /// </summary>
    public readonly struct AsmBitstring
    {
        readonly TextBlock Data {get;}

        [MethodImpl(Inline)]
        internal AsmBitstring(string src)
        {
            Data = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => Data.Hash;
        }

        public string Format()
            => Data;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmBitstring(AsmHexCode src)
            => new AsmBitstring(AsmRender.format8x4(src));

        public static AsmBitstring Empty
        {
            [MethodImpl(Inline)]
            get => new AsmBitstring(TextBlock.Empty);
        }
    }
}
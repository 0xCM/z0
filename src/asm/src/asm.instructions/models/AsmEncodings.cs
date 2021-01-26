//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public readonly struct AsmEncodings : IIndex<AsmEncoding>
    {
        readonly Index<AsmEncoding> Data;

        [MethodImpl(Inline)]
        public AsmEncodings(AsmEncoding[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<AsmEncoding> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public AsmEncoding[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public AsmEncodings Distinct()
            => new AsmEncodings(Data.Distinct().Index());

        public AsmEncodings Sort()
            => new AsmEncodings(Data.Sort());

        public AsmEncodings SortDistinct()
            => Distinct().Sort();

        [MethodImpl(Inline)]
        public static implicit operator AsmEncodings(AsmEncoding[] src)
            => new AsmEncodings(src);
    }
}
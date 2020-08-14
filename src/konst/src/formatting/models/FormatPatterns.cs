//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FormatPatterns
    {
        readonly TableSpan<FormatPattern> Data;

        [MethodImpl(Inline)]
        public static implicit operator FormatPatterns(FormatPattern[] src)
            => new FormatPatterns(src);

        [MethodImpl(Inline)]
        public FormatPatterns(FormatPattern[] src)
            => Data = src;

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<FormatPattern> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
        
        public ref readonly FormatPattern this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }    
}
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
        public readonly FormatPattern[] Data;

        [MethodImpl(Inline)]
        public FormatPatterns(FormatPattern[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<string> Descriptions
        {
            [MethodImpl(Inline)]
            get => Data.Select(x => x.Description);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ref readonly FormatPattern First
        {
            [MethodImpl(Inline)]
            get => ref Data[0];
        }
        
        public ReadOnlySpan<FormatPattern> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }
        
        public ref readonly FormatPattern this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }    
}
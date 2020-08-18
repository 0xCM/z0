//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RenderPatternIndex
    {
        readonly TableSpan<RenderPattern> Data;

        [MethodImpl(Inline)]
        public static implicit operator RenderPatternIndex(RenderPattern[] src)
            => new RenderPatternIndex(src);

        [MethodImpl(Inline)]
        public RenderPatternIndex(RenderPattern[] src)
            => Data = src;

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<RenderPattern> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
        
        public ref readonly RenderPattern this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }    
}
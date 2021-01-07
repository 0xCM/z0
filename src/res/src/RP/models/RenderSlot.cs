//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    /// <summary>
    /// Represents a slot within a format pattern
    /// </summary>
    public readonly struct RenderSlot
    {
        public byte Position {get;}

        public string Pattern {get;}

        [MethodImpl(Inline)]
        public RenderSlot(byte pos, string pattern)
        {
            Position = pos;
            Pattern = pattern;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrEmpty(Pattern);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public static RenderSlot Empty
        {
            [MethodImpl(Inline)]
            get => new RenderSlot(0, string.Empty);
        }

       [MethodImpl(Inline)]
       public static implicit operator RenderSlot((byte pos, string pattern) src)
            => new RenderSlot(src.pos, src.pattern);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a slot within a render pattern
    /// </summary>
    public readonly struct RenderSlot<T>
    {
        public byte Position {get;}

        public RenderPattern Pattern {get;}

        [MethodImpl(Inline)]
        internal RenderSlot(byte pos, RenderPattern pattern)
        {
            Position = pos;
            Pattern = pattern;
        }

        [MethodImpl(Inline)]
        public string Format(T arg)
            => Pattern.Apply(arg);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Pattern.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public static RenderSlot Empty
        {
            [MethodImpl(Inline)]
            get => new RenderSlot(0, EmptyString);
        }

       [MethodImpl(Inline)]
       public static implicit operator RenderSlot<T>(Paired<byte,string> src)
            => new RenderSlot<T>(src.Left, src.Right);

       [MethodImpl(Inline)]
       public static implicit operator RenderSlot<T>((byte pos, string pattern) src)
            => new RenderSlot<T>(src.pos, src.pattern);

       [MethodImpl(Inline)]
       public static implicit operator RenderSlot<T>((byte pos, RenderPattern pattern) src)
            => new RenderSlot<T>(src.pos, src.pattern);
    }
}
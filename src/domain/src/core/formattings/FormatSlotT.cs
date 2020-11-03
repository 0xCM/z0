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
    /// Represents a slot within a format pattern
    /// </summary>
    public readonly struct FormatSlot<T>
    {
        public byte Position {get;}

        public FormatPattern Pattern {get;}

        [MethodImpl(Inline)]
        internal FormatSlot(byte pos, FormatPattern pattern)
        {
            Position = pos;
            Pattern = pattern;
        }

        [MethodImpl(Inline)]
        public string Format(T arg)
            => Pattern.Format(arg);

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

        public static FormatSlot Empty
        {
            [MethodImpl(Inline)]
            get => new FormatSlot(0, EmptyString);
        }

       [MethodImpl(Inline)]
       public static implicit operator FormatSlot<T>(Paired<byte,string> src)
            => new FormatSlot<T>(src.Left, src.Right);

       [MethodImpl(Inline)]
       public static implicit operator FormatSlot<T>((byte pos, string pattern) src)
            => new FormatSlot<T>(src.pos, src.pattern);

       [MethodImpl(Inline)]
       public static implicit operator FormatSlot<T>((byte pos, FormatPattern pattern) src)
            => new FormatSlot<T>(src.pos, src.pattern);
    }
}
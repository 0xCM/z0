//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AspectRow
    {
        /// <summary>
        /// The aspect name
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The defining source
        /// </summary>
        public readonly object Source;

        /// <summary>
        /// The aspect value
        /// </summary>
        public readonly object Value;

        /// <summary>
        /// An informative description
        /// </summary>
        public readonly string Description;

        [MethodImpl(Inline)]
        public static implicit operator AspectRow((string name, object src, object value, string description) src)
            => new AspectRow(src.name, src.src, src.value, src.description);

        [MethodImpl(Inline)]
        public AspectRow(string name, object src, object value, string description)
        {
            Name = name;
            Source = Null.Banish(src);
            Value = Null.Banish(value);
            Description = Null.Banish(description);
        }

        public bool IsEmpty
            => Value == null || Value is Null;

        public bool IsNonEmpty
            => !IsEmpty;

        public string Format()
            => text.concat(Source, text.bracket(Name)," = ", Description);

        public override string ToString()
            => Format();

        public static AspectRow Empty
            => (string.Empty, Null.Value, Null.Value, string.Empty);
    }
}
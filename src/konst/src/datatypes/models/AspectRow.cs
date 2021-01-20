//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AspectRow
    {
        /// <summary>
        /// The aspect name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The defining source
        /// </summary>
        public object Source {get;}

        /// <summary>
        /// The aspect value
        /// </summary>
        public object Value {get;}

        /// <summary>
        /// An informative description
        /// </summary>
        public string Description {get;}

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
            => text.concat(Source, text.bracket(Name),":", Description);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AspectRow((string name, object src, object value, string description) src)
            => new AspectRow(src.name, src.src, src.value, src.description);

        public static AspectRow Empty
            => new AspectRow(EmptyString, Null.Value, Null.Value, EmptyString);
    }
}
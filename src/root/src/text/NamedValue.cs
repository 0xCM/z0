//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct NamedValue
    {
        [MethodImpl(Inline)]
        public static NamedValue<V> empty<V>()
            => new NamedValue<V>(EmptyString, default(V));

        /// <summary>
        /// The name of the value
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The named value
        /// </summary>
        public dynamic Value {get;}

        [MethodImpl(Inline)]
        public NamedValue(string name, dynamic value)
        {
            Name = name;
            Value = value;
        }

        public string Format()
            => $"{Name}:={Value}";

        public override string ToString()
            => Format();

        public static NamedValue Empty
        {
            [MethodImpl(Inline)]
            get => new NamedValue(EmptyString, 0u);
        }
    }
}
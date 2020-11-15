//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Specifies a kinded tool option
    /// </summary>
    public readonly struct ToolOption<K> : IToolOption<K>
        where K : unmanaged
    {
        /// <summary>
        /// The option name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The option kind
        /// </summary>
        public K Kind {get;}

        [MethodImpl(Inline)]
        public ToolOption(K kind)
        {
            Name = kind.ToString();
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public ToolOption(string name, K kind)
        {
            Name = name;
            Kind = kind;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Name);
        }

        public bool IsAnonymous
        {
            [MethodImpl(Inline)]
            get => string.Equals(Name, ToolOption.AnonymousOptionName);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ToolOption<K>(K src)
            => new ToolOption<K>(src);

        [MethodImpl(Inline)]
        public static implicit operator ToolOption(ToolOption<K> src)
            => new ToolOption(src.Name);

        /// <summary>
        /// Specifies the empty option
        /// </summary>
        public static ToolOption<K> Empty
        {
            [MethodImpl(Inline)]
            get => new ToolOption<K>(EmptyString, default(K));
        }
    }
}
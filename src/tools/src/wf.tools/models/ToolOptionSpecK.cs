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
    /// Specifies a kinded option
    /// </summary>
    public readonly struct ToolOptionSpec<K> : IToolOptionSpec<K>
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

        /// <summary>
        /// A description for the option, if available
        /// </summary>
        public string Purpose {get;}

        /// <summary>
        /// The option protocol
        /// </summary>
        public ArgProtocol Protocol {get;}

        [MethodImpl(Inline)]
        public ToolOptionSpec(K kind)
        {
            Name = kind.ToString();
            Kind = kind;
            Purpose = EmptyString;
            Protocol = new ArgProtocol(ArgPrefix.Default);
        }

        [MethodImpl(Inline)]
        public ToolOptionSpec(string name, K kind)
        {
            Name = name;
            Kind = kind;
            Purpose = EmptyString;
            Protocol = new ArgProtocol(ArgPrefix.Default);
        }

        [MethodImpl(Inline)]
        public ToolOptionSpec(string name, K kind, string purpose, ArgProtocol protocol)
        {
            Name = name;
            Kind = kind;
            Purpose = purpose;
            Protocol = protocol;
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
            get => text.empty(Name);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ToolOptionSpec(ToolOptionSpec<K> src)
            => new ToolOptionSpec(src.Name, src.Purpose, src.Protocol);

        /// <summary>
        /// Specifies the empty option
        /// </summary>
        public static ToolOptionSpec<K> Empty
        {
            [MethodImpl(Inline)]
            get => new ToolOptionSpec<K>(EmptyString, default(K));
        }
    }
}
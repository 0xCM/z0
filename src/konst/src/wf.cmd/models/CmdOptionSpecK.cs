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
    /// Specifies a kinded option
    /// </summary>
    public readonly struct CmdOptionSpec<K> : ICmdOptionSpec<K>
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
        public CmdArgProtocol Protocol {get;}

        [MethodImpl(Inline)]
        public CmdOptionSpec(K kind)
        {
            Name = kind.ToString();
            Kind = kind;
            Purpose = EmptyString;
            Protocol = new CmdArgProtocol(CmdArgPrefix.Default);
        }

        [MethodImpl(Inline)]
        public CmdOptionSpec(string name, K kind)
        {
            Name = name;
            Kind = kind;
            Purpose = EmptyString;
            Protocol = new CmdArgProtocol(CmdArgPrefix.Default);
        }

        [MethodImpl(Inline)]
        public CmdOptionSpec(string name, K kind, string purpose, CmdArgProtocol protocol)
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
        public static implicit operator CmdOptionSpec(CmdOptionSpec<K> src)
            => new CmdOptionSpec(src.Name, src.Purpose, src.Protocol);

        /// <summary>
        /// Specifies the empty option
        /// </summary>
        public static CmdOptionSpec<K> Empty
        {
            [MethodImpl(Inline)]
            get => new CmdOptionSpec<K>(EmptyString, default(K));
        }
    }
}
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
    /// Defines a command option
    /// </summary>
    public readonly struct ToolOptionSpec : IToolOptionSpec
    {
        /// <summary>
        /// The option name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The option's use
        /// </summary>
        public string Purpose {get;}

        /// <summary>
        /// The option protocol
        /// </summary>
        public ArgProtocol Protocol {get;}

        [MethodImpl(Inline)]
        public ToolOptionSpec(string name)
        {
            Name = name;
            Purpose = EmptyString;
            Protocol = new ArgProtocol(ArgPrefix.Default);
        }

        [MethodImpl(Inline)]
        public ToolOptionSpec(string name, string purpose)
        {
            Name = name;
            Purpose = purpose;
            Protocol = new ArgProtocol(ArgPrefix.Default);
        }

        [MethodImpl(Inline)]
        public ToolOptionSpec(string name, string purpose, ArgProtocol protocol)
        {
            Name = name;
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
            => ToolCmd.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ToolOptionSpec(string src)
            => new ToolOptionSpec(src);

        public static ToolOptionSpec Empty
        {
            [MethodImpl(Inline)]
            get => new ToolOptionSpec(EmptyString);
        }
    }
}
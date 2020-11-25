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

    [ApiHost(ApiNames.Cmd, true)]
    public readonly partial struct Cmd
    {
        internal const byte MaxVarCount = 16;

        internal const string Anonymous = "anonymous";

        internal const string CmdIdNotFound = "Command identifier not found";

        internal const string InvalidOption = "Option text invalid";

        internal const char DefaultSpecifier = Chars.Colon;

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static ICmdCatalog catalog(IWfShell wf)
            => new CmdCatalog(wf);

        [MethodImpl(Inline), Op]
        public static CmdBuilder builder(IWfShell wf)
            => new CmdBuilder(wf);

        [MethodImpl(Inline), Factory]
        public CmdArgProtocol protocol(CmdArgPrefix prefix, AsciCharCode qualifier = AsciCharCode.Space)
            => new CmdArgProtocol(prefix, qualifier);


        /// <summary>
        /// Creates an option without purpose
        /// </summary>
        /// <param name="name">The option name</param>
        [MethodImpl(Inline), Factory]
        public static CmdOptionSpec option(string name)
            => new CmdOptionSpec(name);

        /// <summary>
        /// Creates a meaningful option
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="purpose">The option's significance</param>
        [MethodImpl(Inline), Factory]
        public static CmdOptionSpec option(string name, string purpose)
            => new CmdOptionSpec(name, purpose);

        /// <summary>
        /// Creates a meaningful option with non-default protocol
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="purpose">The option's significance</param>
        /// <param name="purpose">The invocation protocol</param>
        [MethodImpl(Inline), Factory]
        public static CmdOptionSpec option(string name, string purpose, CmdArgPrefix prefix)
            => new CmdOptionSpec(name, purpose, prefix);

        /// <summary>
        /// Creates a meaningful option with non-default protocol
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="purpose">The option's significance</param>
        /// <param name="purpose">The invocation protocol</param>
        [MethodImpl(Inline), Factory]
        public static CmdOptionSpec option(string name, string purpose, CmdArgProtocol protocol)
            => new CmdOptionSpec(name, purpose, protocol);
    }
}
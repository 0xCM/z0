//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Cmd
    {
        /// <summary>
        /// Creates an option without purpose
        /// </summary>
        /// <param name="name">The option name</param>
        [MethodImpl(Inline), Factory]
        public static CmdOption option(string name)
            => new CmdOption(name);

        /// <summary>
        /// Creates a meaningful option
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="description">What does it do?</param>
        [MethodImpl(Inline), Factory]
        public static CmdOption option(string name, string description)
            => new CmdOption(name, description);

        /// <summary>
        /// Creates a meaningful option with non-default protocol
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="purpose">The option's significance</param>
        /// <param name="purpose">The invocation protocol</param>
        [MethodImpl(Inline), Factory]
        public static CmdOption option(string name, string purpose, ArgPrefix prefix)
            => new CmdOption(name, purpose, prefix);

        /// <summary>
        /// Creates a meaningful option with non-default protocol
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="purpose">The option's significance</param>
        /// <param name="purpose">The invocation protocol</param>
        [MethodImpl(Inline), Factory]
        public static CmdOption option(string name, string purpose, ArgProtocol protocol)
            => new CmdOption(name, purpose, protocol);
    }
}
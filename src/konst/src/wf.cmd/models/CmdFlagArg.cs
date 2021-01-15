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
    /// Defines a tool flag argument
    /// </summary>
    public readonly struct CmdFlagArg
    {
        /// <summary>
        /// The flag name
        /// </summary>
        public Name FlagName {get;}

        /// <summary>
        /// Whether the flag is enabled
        /// </summary>
        public bool Enabled {get;}

        [MethodImpl(Inline)]
        public CmdFlagArg(string name, bool enabled)
        {
            FlagName = name;
            Enabled = enabled;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdFlagArg(string src)
            => new CmdFlagArg(src,true);

        [MethodImpl(Inline)]
        public static implicit operator bool(CmdFlagArg src)
            => src.Enabled;

        [MethodImpl(Inline)]
        public static bool operator true(CmdFlagArg src)
            => src.Enabled;

        [MethodImpl(Inline)]
        public static bool operator false(CmdFlagArg src)
            => !src.Enabled;
    }
}
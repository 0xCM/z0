//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cmd
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a command-flag that exibits boolean characteristics: it's there or its not
    /// </summary>
    public readonly struct CmdFlag
    {
        [MethodImpl(Inline)]
        public static implicit operator CmdFlag(string name)
            => new CmdFlag(name);

        [MethodImpl(Inline)]
        public CmdFlag(string name)
        {
            Name = name;
            Emit = true;
        }
        
        [MethodImpl(Inline)]
        public CmdFlag(string name, bool emit)
        {
            Name = name;
            Emit = emit;
        }
        
        /// <summary>
        /// The flag name
        /// </summary>
        public readonly StringRef Name;

        /// <summary>
        /// Whether the flag is emitted
        /// </summary>
        public readonly bool Emit;

        [MethodImpl(Inline)]
        public string Format()
            => Emit ? Name.Format() : EmptyString;

        public override string ToString()
            => Format();
    }
}
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
    public readonly struct CmdOption
    {
        [MethodImpl(Inline)]
        public static implicit operator CmdOption((string name, string value) src)
            => new CmdOption(src.name, src.value);
        
        [MethodImpl(Inline)]
        public CmdOption(string name, string value)
        {
            Name = name;
            Value = value;
        }
        
        /// <summary>
        /// The option name
        /// </summary>
        public readonly StringRef Name;

        /// <summary>
        /// The option value
        /// </summary>
        public readonly StringRef Value;

        [MethodImpl(Inline)]
        public string Format(string pattern)
            => text.format(pattern, Name.Format(), Value.Format());
        
        [MethodImpl(Inline)]
        public string Format()
            => Format("{0}={1}");

        public override string ToString() 
            => Format();
    }
}
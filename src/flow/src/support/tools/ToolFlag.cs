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
    
    public readonly struct ToolFlag
    {
        [MethodImpl(Inline)]
        public static implicit operator ToolFlag(string name)
            => new ToolFlag(name);

        [MethodImpl(Inline)]
        public ToolFlag(string name)
        {
            Name = name;
            Emit = true;
        }
        
        [MethodImpl(Inline)]
        public ToolFlag(string name, bool emit)
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
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
        /// <summary>
        /// The flag name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// Whether the flag is emitted
        /// </summary>
        public bool Emit {get;}

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

        [MethodImpl(Inline)]
        public string Format()
            => Emit ? Name ?? EmptyString : EmptyString;

        public override string ToString()
            => Format();
    }
}
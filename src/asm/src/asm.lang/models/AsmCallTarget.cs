//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct AsmCallTarget
    {
        /// <summary>
        /// The target's identifier
        /// </summary>
        public Identifier Name;

        /// <summary>
        /// The target's base address
        /// </summary>
        public MemoryAddress Base;

        [MethodImpl(Inline)]
        public AsmCallTarget(MemoryAddress @base)
        {
            Name = EmptyString;
            Base = @base;
        }

        [MethodImpl(Inline)]
        public AsmCallTarget(string id, MemoryAddress @base)
        {
            Name = id;
            Base = @base;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}
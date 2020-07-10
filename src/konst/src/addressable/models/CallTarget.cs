//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CallTarget
    {
        /// <summary>
        /// The target's identifier
        /// </summary>
        public readonly string Id;
        
        /// <summary>
        /// The target's base address
        /// </summary>
        public readonly MemoryAddress Base;

        [MethodImpl(Inline)]
        public CallTarget(MemoryAddress @base)
        {
            Id = EmptyString;
            Base = @base;
        }       

        [MethodImpl(Inline)]
        public CallTarget(string id, MemoryAddress @base)
        {
            Id = id;
            Base = @base;
        }       

        public string Format()
            => text.concat(Base.Format(), Chars.Colon, Chars.Space, z.ifempty(Id, "target"));
        
        public override string ToString()
            => Format();
    }
}
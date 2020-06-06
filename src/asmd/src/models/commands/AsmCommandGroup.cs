//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmCommandGroup : ITextual
    {
        public readonly AsciCode16 Name;

        [MethodImpl(Inline)]
        public AsmCommandGroup(string name)
        {
            Symbolic.encode(name, out Name);
        }

        [MethodImpl(Inline)]
        public AsmCommandGroup(AsciCode16 name)
        {
            Name = name;
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => Name.Format();
    }
}
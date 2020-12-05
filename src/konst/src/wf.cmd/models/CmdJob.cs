//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CmdJob : ITextual
    {
        public string Name {get;}

        public string Spec {get;}

        [MethodImpl(Inline)]
        public CmdJob(string name, string spec)
        {
            Name = name;
            Spec = spec;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Spec;

        public override string ToString()
            => Format();
    }
}
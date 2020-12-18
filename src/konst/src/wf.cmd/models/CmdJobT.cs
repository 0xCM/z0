//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdJob<T> : ITextual
        where T : struct, ITextual
    {
        public string Name {get;}

        public T Spec {get;}

        [MethodImpl(Inline)]
        public CmdJob(string name, T spec)
        {
            Spec = spec;
            Name = name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Spec.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdJob(CmdJob<T> src)
            => new CmdJob(src.Name, src.Format());
    }
}
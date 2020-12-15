//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a link between an identified resource and an emission target
    /// </summary>
    public readonly struct ResEmission : IDataFlow<ResDescriptor,FS.FilePath>
    {
        public ResDescriptor Source {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public ResEmission(ResDescriptor src, FS.FilePath dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator ResEmission(Link<ResDescriptor,FS.FilePath> link)
            => new ResEmission(link.Source, link.Target);

        [MethodImpl(Inline)]
        public static implicit operator Link<ResDescriptor,FS.FilePath>(ResEmission src)
            => new ResEmission(src.Source, src.Target);
    }
}
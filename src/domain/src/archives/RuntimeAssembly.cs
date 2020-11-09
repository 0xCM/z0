//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using api = RuntimeArchive;

    public readonly struct RuntimeAssembly : ITextual
    {
        public Assembly Component {get;}

        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public RuntimeAssembly(Assembly src, FS.FilePath path)
        {
            Component = insist(src);
            Path = path;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Assembly(RuntimeAssembly src)
            => src.Component;

        [MethodImpl(Inline)]
        public static implicit operator RuntimeAssembly(Assembly src)
            => api.assembly(src);
    }
}

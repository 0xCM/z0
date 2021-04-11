//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct CaseScript<T>
    {
        public T Case {get;}

        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public CaseScript(T @case, FS.FilePath path)
        {
            Case = @case;
            Path = path;
        }

        [MethodImpl(Inline)]
        public static implicit operator CaseScript<T>((T @case, FS.FilePath path) src)
            => new CaseScript<T>(src.@case, src.path);
    }

}
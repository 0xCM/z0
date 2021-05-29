//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ToolScript<T>
    {
        public T Data {get;}

        public FS.FilePath ScriptPath {get;}

        [MethodImpl(Inline)]
        public ToolScript(T @case, FS.FilePath path)
        {
            Data = @case;
            ScriptPath = path;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolScript<T>((T @case, FS.FilePath path) src)
            => new ToolScript<T>(src.@case, src.path);
    }
}
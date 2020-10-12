//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolEmission<T> : IToolEmission<T>
        where T : struct, ITool<T>
    {
        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public ToolEmission(FS.FilePath path)
        {
            Target = Files.normalize(path);
        }
    }
}
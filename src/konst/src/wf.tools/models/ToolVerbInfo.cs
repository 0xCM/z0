//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ToolVerbInfo<T>
        where T : struct
    {
        public ToolId Tool {get;}

        public ToolVerb Verb {get;}

        public T Spec {get;}
    }
}
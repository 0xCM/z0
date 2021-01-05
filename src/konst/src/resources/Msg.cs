//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial struct Msg
    {
        public static RenderPattern<Assembly,uint> EmittingResources => "Emitting {1} {0} resources";

        public static RenderPattern<FS.FilePath> EmittedRuntimeIndex => "Emitted operation index to {0}";
    }
}
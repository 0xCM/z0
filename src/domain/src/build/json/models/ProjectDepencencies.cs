//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyModel;
    using System.IO;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct JsonDeps
    {
        public readonly struct ProjectDependencies
        {
            readonly DependencyContext Source;

            readonly IndexedView<CompilationLibrary> CompilationLibraries;

            readonly IndexedView<RuntimeLibrary> RuntimeLibraries;

            readonly CompilationOptions Options;

            readonly IndexedView<RuntimeFallbacks> RuntimeGraph;

            [MethodImpl(Inline)]
            internal ProjectDependencies(DependencyContext src)
            {
                Source = insist(src);
                CompilationLibraries = src.CompileLibraries.Array();
                RuntimeLibraries = src.RuntimeLibraries.Array();
                Options = src.CompilationOptions;
                RuntimeGraph = src.RuntimeGraph.Array();
            }


            [MethodImpl(Inline)]
            public Options OptionData()
                => data(Options, out Options _);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.Extensions.DependencyModel;

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

            internal ProjectDependencies(DependencyContext src)
            {
                Source = insist(src);
                CompilationLibraries = src.CompileLibraries.Array();
                RuntimeLibraries = src.RuntimeLibraries.Array();
                Options = src.CompilationOptions;
                RuntimeGraph = src.RuntimeGraph.Array();
            }

            public Options OptionData()
            {
                var dst = new Options();
                return map(Options, ref dst);
            }

            public ReadOnlySpan<Library> Libraries()
            {
                var count = CompilationLibraries.Count;
                var target = span<Library>(count);
                var libs = CompilationLibraries.View;
                for(var i=0u; i<count; i++)
                    map(skip(libs, i), ref seek(target,i));
                return target;
            }
        }
    }
}
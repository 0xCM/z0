//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.External)]

namespace Z0.Parts
{
    using System;
    using System.Reflection;

    public sealed class External : Part<External>
    {
        public readonly struct Imports
        {
            public Assembly MsBuildFramework
                => typeof(Microsoft.Build.Framework.BuildEngineResult).Assembly;

            public Assembly MsBuildTasks
                => typeof(Microsoft.Build.Tasks.AssignCulture).Assembly;

            public Assembly MsBuildUtilities
                => typeof(Microsoft.Build.Utilities.MuxLogger).Assembly;

            public Assembly Dia2Lib
                => typeof(Dia2Lib._FILETIME).Assembly;

            public Assembly MsTraceEvent
                => typeof(Microsoft.Diagnostics.Symbols.NativeSymbolModule).Assembly;

            public Assembly CSharpWorkspaces
                => typeof(Microsoft.CodeAnalysis.CSharp.Formatting.BinaryOperatorSpacingOptions).Assembly;

            public Assembly CodeAnalysis
                => typeof(Microsoft.CodeAnalysis.Emit.InstrumentationKind).Assembly;

            public Assembly Srm
                => typeof(System.Reflection.Metadata.AssemblyDefinition).Assembly;
        }
    }
}
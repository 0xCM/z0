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
        // public readonly struct Imports
        // {
        //     public Assembly Dia2Lib
        //         => typeof(Dia2Lib._FILETIME).Assembly;

        //     public Assembly MsTraceEvent
        //         => typeof(Microsoft.Diagnostics.Symbols.NativeSymbolModule).Assembly;

        //     public Assembly CSharpWorkspaces
        //         => typeof(Microsoft.CodeAnalysis.CSharp.Formatting.BinaryOperatorSpacingOptions).Assembly;

        //     public Assembly CodeAnalysis
        //         => typeof(Microsoft.CodeAnalysis.Emit.InstrumentationKind).Assembly;

        //     public Assembly Srm
        //         => typeof(System.Reflection.Metadata.AssemblyDefinition).Assembly;
        // }
    }
}
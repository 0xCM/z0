
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    partial struct EmissionWorkflow 
    {
        partial struct EmitProjectDocs
        {
            const string Sep = "| ";

            static string format(ProjectDocRecord src)
            {
                return text.concat(src.Kind.ToString().PadRight(12), Sep, src.Identifer.PadRight(70), Sep, src.Summary);   
            }

            static DocTargetKind kind(char src)
                => src switch {
                    'T' => DocTargetKind.Type,
                    'M' => DocTargetKind.Method,
                    'P' => DocTargetKind.Property,
                    'F' => DocTargetKind.Field,
                    _ => DocTargetKind.None,
                };            
        }
    }
}
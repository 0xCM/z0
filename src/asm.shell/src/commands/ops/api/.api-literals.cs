//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static WsAtoms;

    partial class AsmCmdService
    {
        [CmdOp(".api-literals")]
        Outcome EmitApiLiterals(CmdArgs args)
        {
            var result = Outcome.Success;
            var literals = EmitApiLiterals();
            return result;
        }

        Index<CompilationLiteral> EmitApiLiterals()
        {
            var result = Outcome.Success;
            var components = ApiRuntimeLoader.assemblies();
            var providers = ApiLiterals.providers(components).View;
            var count = providers.Length;
            var buffer = list<CompilationLiteral>();
            var dst = Ws.Tables().Table<ApiLiterals>(machine);
            for(var i=0; i<count; i++)
            {
                ref readonly var provider = ref skip(providers,i);
                var literals = ApiLiterals.provided(provider).View;
                for(var j=0; j<literals.Length; j++)
                {
                    ref readonly var literal = ref skip(literals,j);
                    buffer.Add(literal.Specify());
                }
            }

            var records = buffer.ToArray();
            TableEmit(records.ToReadOnlySpan(), CompilationLiteral.RenderWidths, dst);
            return records;
        }
    }
}
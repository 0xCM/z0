//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        Outcome EmitApiLiterals()
        {
            var result = Outcome.Success;
            var components = ApiRuntimeLoader.assemblies();
            var providers = ApiLiterals.providers(components).View;
            var count = providers.Length;
            var buffer = list<ApiLiteralSpec>();
            var dst = ApiWs.Table<ApiLiterals>();
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

            TableEmit(buffer.ViewDeposited(), ApiLiteralSpec.RenderWidths, dst);

            return result;
        }
    }
}
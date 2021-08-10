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
        [CmdOp(".emit-api-literals")]
        Outcome EmitApiLiterals(CmdArgs args)
        {
            var result = Outcome.Success;
            var components = ApiRuntimeLoader.assemblies();
            var providers = ApiLiterals.providers(components).View;
            var count = providers.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var provider = ref skip(providers,i);
                Write(provider.Name);
                var literals = ApiLiterals.provided(provider).View;
                for(var j=0; j<literals.Length; j++)
                {
                    ref readonly var literal = ref skip(literals,j);
                    Write(literal.Format());
                }
            }

            return result;
        }
    }
}
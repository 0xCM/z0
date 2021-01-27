//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static z;

    public sealed class AsmJmpCollector : WfService<AsmJmpCollector,AsmJmpCollector>
    {
        public Index<AsmJmpRow> Collect(ApiPartRoutines src)
        {
            var collection = root.list<AsmJmpRow>();
            var hosts = src.View;
            uint kHost = src.HostCount;
            for(var i=0u; i<kHost; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var rCount = host.RoutineCount;
                var routines = @readonly(host.Routines);
                for(var j=0u; j<rCount; j++)
                {
                    ref readonly var member = ref skip(routines,j);
                    var instructions = member.Instructions.View;
                    var iCount = instructions.Length;
                    for(var k=0u; k<iCount; k++)
                    {
                        ref readonly var fx = ref skip(instructions, k);
                        var fc = fx.Instruction.FlowControl;
                        switch(fc)
                        {
                            case IceFlowControl.ConditionalBranch:
                            case IceFlowControl.UnconditionalBranch:
                            case IceFlowControl.IndirectBranch:
                                var kind = AsmBuilder.jccKind(fx.Mnemonic);
                                IceExtractors.jmprow(fx, kind, out var dst);
                                collection.Add(dst);
                            break;
                        }
                    }
                }
            }

            return collection.ToArray();
        }
    }
}
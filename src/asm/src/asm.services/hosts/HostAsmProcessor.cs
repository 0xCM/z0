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

    public readonly struct HostAsmProcessor : IWfDataProcessor<AsmHandlerKind,ApiHostRoutines>
    {
        public IWfShell Wf {get;}

        public ApiHostRoutines Source {get;}

        public IWfDataBroker<AsmHandlerKind,ApiHostRoutines> Broker {get;}

        [MethodImpl(Inline)]
        public HostAsmProcessor(IWfShell context, ApiHostRoutines src)
        {
            Wf = context;
            Broker = BitBrokers.broker64<AsmHandlerKind,ApiHostRoutines>();
            Source = src;
            (this as IWfDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        public void Process()
        {
            var processor = AsmServices.processor(Wf);
            var count = Source.RoutineCount;
            var routines = @readonly(Source.Routines);
            for(var j=0; j<count; j++)
            {
                ref readonly var routine = ref skip(routines,j);
                var instructions = routine.Instructions.View;
                var iCount = instructions.Length;
                for(var k=0; k<iCount; k++)
                    processor.Process(skip(instructions,k));
            }
        }

        [MethodImpl(Inline)]
        public void Process(ApiHostRoutines src)
        {
            var processor = AsmServices.processor(Wf);
            var routines = @readonly(src.Routines);
            var count = routines.Length;
            for(var j=0; j<count; j++)
            {
                ref readonly var routine = ref skip(routines,j);
                var instructions = routine.Instructions.View;
                var iCount = instructions.Length;
                for(var k=0; k<iCount; k++)
                    processor.Process(skip(instructions,k));
            }
        }
    }
}
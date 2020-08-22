//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    public enum PartHandlerKind : byte
    {
        A = 0,

        B = 1,

        C = 2
    }

    public interface IPartProcessor : IAsmProcessor<PartHandlerKind,PartAsmFx>
    {
        //IDataBroker<PartHandlerKind,PartInstructions> Broker {get;}
    }

    public readonly struct PartAsmProcessor : IPartProcessor
    {
        public IWfContext Wf {get;}

        readonly BitBroker<PartHandlerKind,PartAsmFx> broker;

        public IDataBroker<PartHandlerKind,PartAsmFx> Broker
            => broker;

        [MethodImpl(Inline)]
        public PartAsmProcessor(IWfContext wf)
        {
            Wf = wf;
            broker = DataBrokers.broker64<PartHandlerKind,PartAsmFx>();
            (this as IDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        public void Process(PartAsmFx src)
        {
            for(var i=0; i<src.Length; i++)
                AsmProcessors.hosts(Wf, src[i]).Process();
        }
    }
}
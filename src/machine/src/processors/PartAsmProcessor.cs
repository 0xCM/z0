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

    public interface IAsmProcessor<T> : IDataProcessor<T>
    {
        void Process(T src);
    }


    public interface IAsmProcessor<E,T> : IAsmProcessor<T>
        where E : unmanaged, Enum
    {
        IDataBroker<E,T> Broker {get;}

        void Relay(E kind, T data)
            => Broker.Relay(kind,data);
    }

    public interface IAsmProcessor : IAsmProcessor<Mnemonic,BasedAsmFx>
    {
        void OnAnd(BasedAsmFx located)
        {

        }

        void OnOr(BasedAsmFx located)
        {

        }

        void IDataProcessor.Connect()
        {
            Broker[Mnemonic.And] = AB.handler<BasedAsmFx>(OnAnd);
            Broker[Mnemonic.Or] = AB.handler<BasedAsmFx>(OnOr);
        }
    }

    public readonly struct PartAsmProcessor : IAsmProcessor<PartHandlerKind,PartAsmFx>
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
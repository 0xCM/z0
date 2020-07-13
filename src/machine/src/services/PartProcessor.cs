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

    public interface IPartProcessor : IAsmProcessor<PartInstructions>
    {
        IDataBroker<PartHandlerKind,PartInstructions> Broker {get;}     
    }
    
    public readonly struct PartProcessor : IPartProcessor
    {
        public IMachineContext Context {get;}

        readonly BitBroker<PartHandlerKind,PartInstructions> broker;

        public IDataBroker<PartHandlerKind,PartInstructions> Broker 
            => broker;

        [MethodImpl(Inline)]
        internal PartProcessor(IMachineContext context)
        {
            Context = context;   
            broker = DataBrokers.broker64<PartHandlerKind,PartInstructions>();
            (this as IDataProcessor).Connect();
        }

        [MethodImpl(Inline)]
        public void Process(PartInstructions src)
        {
            var pHost = Processors.Host(Context);
            for(var i=0; i<src.Length; i++)
                pHost.Process(src[i]);
        }
    }
}
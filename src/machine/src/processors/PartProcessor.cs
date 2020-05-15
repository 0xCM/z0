//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

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
        public static IPartProcessor Create(IMachineContext context)
            => new PartProcessor(context);

        public IMachineContext Context {get;}

        public IDataBroker<PartHandlerKind,PartInstructions> Broker {get;}

        PartProcessor(IMachineContext context)
        {
            Context = context;   
            Broker = DataBroker64<PartHandlerKind,PartInstructions>.Alloc();
            (this as IDataProcessor).Connect();
        }

        public void Process(PartInstructions src)
        {
            var pHost = HostProcessor.Create(Context);
            for(var i=0; i<src.Length; i++)
                pHost.Process(src[i]);
        }
    }
}
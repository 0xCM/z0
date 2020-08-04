//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class AsmContext : IAsmContext 
    {            
        [MethodImpl(Inline)]
        public static IAsmContext create(IAppContext root)
            => new AsmContext(root);

        public IAppContext ContextRoot {get;}

        public event Action<IAppMsg> Next;

        public IAppMsgQueue MessageQueue {get;}
                
        public ICaptureServices CaptureServices {get;}

        [MethodImpl(Inline)]
        void Relay(IAppMsg msg)
            => Next(msg);

        [MethodImpl(Inline)]
        public AsmContext(IAppContext root)
        {
            ContextRoot = root;
            MessageQueue = root.MessageQueue;
            Next = root.MessageRelay;
            root.MessageQueue.Next += Relay;      
            CaptureServices = Capture.Services;
        }
       
        public void Deposit(IAppMsg msg)
            => MessageQueue.Deposit(msg);

        public void Notify(string msg, AppMsgKind? severity = null)
            => MessageQueue.Notify(msg, severity);

        public IReadOnlyList<IAppMsg> Dequeue()
            => MessageQueue.Dequeue();

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => MessageQueue.Flush(e);

        public void Emit(FilePath dst) 
            => MessageQueue.Emit(dst);
    }   
}
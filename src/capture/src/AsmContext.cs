//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    
    public class AsmContext : IAsmContext 
    {            
        public static IAsmContext Create(IAppContext root, Action<IAppMsg> relay = null)
            => new AsmContext(root, relay);
        
        public static IAsmContext Create(IAppMsgQueue queue)
            => new AsmContext(queue);

        public IAppContext ContextRoot {get;}

        public event Action<IAppMsg> Next;

        public IAppMsgQueue MessageQueue {get;}
                
        public ICaptureServices CaptureServices {get;}

        AsmContext(IAppContext root, Action<IAppMsg> relay = null)
        {
            ContextRoot = root;
            MessageQueue = root.MessageQueue;
            Next  = relay ?? root.MessageRelay;
            root.MessageQueue.Next += Relay;                  
            CaptureServices = Capture.Services;
        }

        AsmContext(IAppMsgQueue queue)
        {
            Next  = e => {};
            MessageQueue = queue;
            MessageQueue.Next += Relay;      
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

        void Relay(IAppMsg msg)
            => Next(msg);
    }   
}
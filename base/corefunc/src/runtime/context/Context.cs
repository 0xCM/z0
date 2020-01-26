//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public abstract class Context : IContext
    {        
        
        protected Context(IPolyrand rng)
        {
            this.Random = rng;            
        }

        object lockobj = new object();

        /// <summary>
        /// The context random source
        /// </summary>
        public virtual IPolyrand Random {get;}

        List<AppMsg> Messages {get;} 
            = new List<AppMsg>();

        public IReadOnlyList<AppMsg> DequeuePosts()
        {
            lock(lockobj)
            {
                var messages = Messages.ToArray();
                Messages.Clear();
                return messages;
            }
        }
        
        /// <summary>
        /// Enqueues application messages
        /// </summary>
        /// <param name="msg">The messages to enqueue</param>
        public void PostMessage(AppMsg msg)
            => Messages.Add(msg);

        public void PostError(Exception e)
        {
            Messages.Add(AppMsg.Define($"{e}", SeverityLevel.Error));
            var messages = DequeuePosts();
            Terminal.Get().WriteMessages(messages);
            log(messages, LogArea.Test);            
        }
        
        public void PostMessage(string msg, SeverityLevel? severity = null)
            => PostMessage(AppMsg.Define($"{msg}", severity ?? SeverityLevel.Babble));
    }
}
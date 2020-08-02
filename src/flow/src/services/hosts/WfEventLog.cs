//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.IO;

    using static Konst;

    public struct WfEventLog : IMultiSink
    {           
        readonly StreamWriter StdTarget;
        
        readonly StreamWriter ErrTarget;

        readonly IMultiSink RelayTarget;

        readonly object ErrLock;

        readonly object StdLock;

        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        internal WfEventLog(FilePath std, FilePath err, IMultiSink relay)
        {
            Ct = CorrelationToken.define(1);
            StdLock = new object();
            ErrLock = new object();
            StdTarget = std.Writer();
            ErrTarget = err.Writer();
            RelayTarget = relay;
        }

         public void Deposit(IWfEvent src)
         {
            var formatted = src.Format();

            if(src.IsError)
            {
                lock(ErrLock)
                    ErrTarget.WriteLine(formatted);
            }
            else
            {
                lock(StdLock)
                    StdTarget.WriteLine(formatted);                    
            }
            
            RelayTarget.Deposit(src);
        }

         public void Deposit(IAppEvent src)
         {
            Deposit(new WfStatus(src.Format(), src.Flair, Ct));            
         }

        public void Dispose()
        {            
            StdTarget.Flush();
            StdTarget.Dispose();

            ErrTarget.Flush();
            ErrTarget.Dispose();

            RelayTarget.Deposit(new WfStepFinished(nameof(WfEventLog)));
            RelayTarget.Dispose();
        }
   }
}
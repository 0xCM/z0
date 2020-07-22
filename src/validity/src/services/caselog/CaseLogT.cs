//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
        
    using static Konst;
    using static z;

    public class CaseLog<F,R> : ICaseLog<R>
        where R : ITabular
        where F : unmanaged, Enum
    {
        object Locker;

        int Counter;

        StreamWriter Writer;        
                
        readonly FilePath Target;

        static string[] HeaderLabels 
            => Tabular.Headers<F>();

        static string HeaderText 
            => Tabular.HeaderText<F>();
        
        public CaseLog(FilePath dst)
        {
            Target = dst;
            Locker = new object();
            Writer = Target.Writer();
            Writer.WriteLine(HeaderText);
            Counter = 0;        
        }
        
        public void Deposit(params R[] src)
        {
            try
            {
                lock(Locker)
                {
                    CaseLog.deposit(src,Writer);
                    Writer.Flush();
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
            => Writer.Dispose();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
        
    using static Konst;

    public interface ICaseLog<R> : IDisposable
        where R : ITabular
    {
        FilePath Target {get;}
        
        void Write(R[] src);    
    }
    
    public readonly struct CaseLog : IDisposable
    {
        public static CaseLog create(FilePath dst)
            => new CaseLog(new CaseLog<TestCaseField,TestCaseRecord>(dst));

        readonly ICaseLog<TestCaseRecord> Log;
        
        CaseLog(ICaseLog<TestCaseRecord> log)
        {
            Log = log;
        }

        public void Dispose()
        {
            Log.Dispose();
        }

        public void Write(TestCaseRecord[] src)
            => Log.Write(src);
    }
    
    public class CaseLog<F,R> : ICaseLog<R>
        where R : ITabular
        where F : unmanaged, Enum
    {
        object Locker;

        int Counter;

        StreamWriter Writer;        
                
        public FilePath Target {get;}

        public CaseLog(FilePath dst)
        {
            Target = dst;
            Locker = new object();
            Writer = Target.Writer();
            Counter = 0;        
        }
        
        public void Write(R[] src)
        {
            if(src.Length == 0)
                return;

            var dst = text.build();
            z.iter(src, r => dst.Append(r.DelimitedText(FieldDelimiter)));                     
            
            lock(Locker)
            {
                if(Counter == 0)
                    Writer.WriteLine(Tabular.HeaderText<F>(FieldDelimiter));
                Writer.Write(dst.ToString());
                Counter += src.Length;
            }            
        }

        public void Dispose()
        {
            Writer.Dispose();
        }
    }
}
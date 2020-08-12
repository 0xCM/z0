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

    public class TableLog<F,R> : ITableLog<F,R>
        where R : struct, ITable<F,R>
        where F : unmanaged, Enum
    {
        object Locker;

        int Counter;

        StreamWriter Writer;        
                
        readonly FilePath Target;

        readonly ITableFormatter<F,R> Formatter;
        
        public TableLog(ITableFormatter<F,R> formatter, FilePath dst)
        {
            Target = dst;
            Locker = new object();
            Writer = Target.Writer();
            Formatter = formatter;
            Writer.WriteLine(formatter.FormatHeader());
            Counter = 0;        
        }
        
        public void Deposit(params R[] src)
        {
            try
            {
                lock(Locker)
                {
                    var count = src.Length;            
                    var input = span(src);
                    for(var i=0u; i<count; i++)
                        Writer.WriteLine(Formatter.FormatRow(skip(input,i)));
                   
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
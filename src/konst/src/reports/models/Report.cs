//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public abstract class Report<R> : IReport, INullity
        where R : ITabular
    {             
        public R[] Records {get;}

        public TabularFormat Format {get;}

        public Report(R[] records, TabularFormat format)
        {
            Records = records;
            Format = format;
        }

        public string[] HeaderLabels 
        { 
            [MethodImpl(Inline)] 
            get => Format.Headers; 
        }
    
        public int FieldCount 
        {
             [MethodImpl(Inline)] 
             get => Format.FieldCount; 
        }
        public ref readonly R this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Records[index]; 
        }

        public int RecordCount 
        { 
            [MethodImpl(Inline)] 
            get => Records.Length; 
        }

        public bool IsEmpty 
            => RecordCount == 0;

        public bool IsNonEmpty 
            => RecordCount != 0;

        public abstract Option<FilePath> Save(FilePath dst);

        public virtual string ReportName
            => GetType().DisplayName();
    }
    
    public class Report<F,R> : Report<R>, TReport<F,R>
        where F : unmanaged, Enum
        where R : ITabular
    {   
        public static TabularStore<F,R> Log => default;

        public static Report<F,R> Empty 
            => new Report<F,R>();

        public new TabularFormat<F> Format {get;}

        public Report(R[] records)
            : base(records, Tabular.Specify<F>())
        {
            Format = Tabular.Specify<F>();            
        }

        public Report()
            : base(Array.Empty<R>(), Tabular.Specify<F>())
        {
            Format = Tabular.Specify<F>();            
        }

        [MethodImpl(Inline)]
        public override Option<FilePath> Save(FilePath dst) 
            => Log.Save(Records, dst);         
    }

   public class Report<B,F,R> : Report<F,R>, INullary<B>
        where F : unmanaged, Enum
        where R : ITabular
        where B : Report<B,F,R>, new()
    {             
        public static new B Empty => new B();

        public Report(R[] records)
            : base(records)
        {
            
        }

        public Report()
            : base(new R[]{})
        {
            
        }

        public B Zero 
            => Empty;
    }    
}
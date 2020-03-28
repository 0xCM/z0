//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Domain;

    public class Report<R> : IReport<R>
        where R : IRecord<R>
    {             
        public static Report<R> Empty => new Report<R>();

        public R[] Records {get;}

        public ReportInfo Description {get;}

        public Report()
        {
            this.Records = new R[0]{};
            this.Description = Reports.describe<R>();
        }

        public Report(R[] records)
            : this()
        {
            Records = records;
        }
        
        public string[] HeaderNames { [MethodImpl(Inline)] get => Description.HeaderNames; }
    
        public int FieldCount { [MethodImpl(Inline)] get => Description.FieldCount; }

        public R this[int index] { [MethodImpl(Inline)] get => Records[index]; }

        public int RecordCount { [MethodImpl(Inline)] get => Records.Length; }        

        [MethodImpl(Inline)]
        public Option<FilePath> Save(FilePath dst) => Records.Save(dst);   

        public virtual string ReportName  => GetType().DisplayName();
    }
    
    public class Report<F,R> : Report<R>
        where F : unmanaged, Enum
        where R : IRecord<F, R>
    {             
        public static readonly new Report<F,R> Empty = new Report<F,R>();

        public Report(R[] records)
            : base(records)
        {
            Formatter = Reports.formatter<F,R>();
        }

        public Report()
        {
            Formatter = Reports.formatter<F,R>();
        }

        public readonly RecordFormatter<F,R> Formatter;

    }

   public class Report<B,F,R> : Report<R>
        where F : unmanaged, Enum
        where R : IRecord<F, R>
        where B : Report<B,F,R>, new()
    {             
        public static readonly new B Empty = new B();

        public Report(R[] records)
            : base(records)
        {
            Formatter = Reports.formatter<F,R>();
        }

        public Report()
            : base(new R[]{})
        {
            Formatter = Reports.formatter<F,R>();
        }

        public readonly RecordFormatter<F,R> Formatter;
    }    
}
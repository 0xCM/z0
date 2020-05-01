//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class Report<R> : IReport<R>
        where R : ITabular<R>
    {             
        public static Report<R> Empty => new Report<R>();

        public const char DefaultDelimiter = Chars.Pipe;

        public R[] Records {get;}

        public TabularFormat Format {get;}

        public Report()
        {
            this.Records = new R[0]{};
            this.Format = TabularFormats.derive<R>();
        }

        public Report(R[] records)
            : this()
        {
            Records = records;
        }
        
        public string[] HeaderLabels { [MethodImpl(Inline)] get => Format.Headers; }
    
        public int FieldCount { [MethodImpl(Inline)] get => Format.FieldCount; }

        public R this[int index] { [MethodImpl(Inline)] get => Records[index]; }

        public int RecordCount { [MethodImpl(Inline)] get => Records.Length; }        

        [MethodImpl(Inline)]
        public Option<FilePath> Save(FilePath dst) 
            => TableLog.Service.Save(Records, dst); 

        public virtual string ReportName
            => GetType().DisplayName();
    }
    
    public class Report<F,R> : Report<R>
        where F : unmanaged, Enum
        where R : ITabular<F,R>
    {             
        public static readonly new Report<F,R> Empty = new Report<F,R>();

        public Report(R[] records)
            : base(records)
        {
            Formatter = FieldFormat.formatter<F>();
        }

        public Report()
        {
            Formatter = FieldFormat.formatter<F>();
        }

        public readonly FieldFormatter<F> Formatter;
    }

   public class Report<B,F,R> : Report<R>, INullary<B>
        where F : unmanaged, Enum
        where R : ITabular<F,R>
        where B : Report<B,F,R>, new()
    {             
        public static new B Empty => new B();

        public Report(R[] records)
            : base(records)
        {
            Formatter = FieldFormat.formatter<F>();
        }

        public Report()
            : base(new R[]{})
        {
            Formatter = FieldFormat.formatter<F>();
        }

        public readonly FieldFormatter<F> Formatter;

        public bool IsEmpty => RecordCount == 0;

        public bool IsNonEmpty => RecordCount != 0;

        public B Zero => Empty;
    }    
}
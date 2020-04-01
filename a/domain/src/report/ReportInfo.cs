//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Seed;

    public readonly struct ReportInfo : IFormattable<ReportInfo>
    {
        public readonly string[] HeaderNames;

        public readonly ReportFieldInfo[] Fields;

        public readonly int FieldCount;

        [MethodImpl(Inline)]
        public static ReportInfo Define(ReportFieldInfo[] fields, string[] headers)
            => new ReportInfo(fields,headers);

        [MethodImpl(Inline)]
        ReportInfo(ReportFieldInfo[] fields, string[] headers)
        {
            this.Fields = fields;
            this.HeaderNames = headers;
            this.FieldCount = fields.Length;
        }
                
        public ref readonly ReportFieldInfo this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Fields[i];
        }        

        public string Format()
        {
            var dst = new StringBuilder();
            for(var i=0; i< Fields.Length; i++)
                dst.AppendLine(this[i].Format());
            return dst.ToString();
        }

        public override string ToString()
            => Format();

    }

    public readonly struct ReportInfo<F> : IFormattable<ReportInfo<F>>
        where F : unmanaged, Enum
    {
        readonly ReportInfo Description;
                
        [MethodImpl(Inline)]
        internal ReportInfo(ReportInfo description)
        {
            this.Description = description;
        }
                
        public ref readonly ReportFieldInfo this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Description.Fields[i];
        }        

        public ref readonly ReportFieldInfo this[F f]
        {
            [MethodImpl(Inline)]
            get => ref Description.Fields[(uint)Enums.numeric<F,ulong>(f)];
        }

        public int FieldCount { [MethodImpl(Inline)] get => Description.FieldCount; }

        public string[] HeaderNames  { [MethodImpl(Inline)] get => Description.HeaderNames; }

        public ReportFieldInfo[] Fields { [MethodImpl(Inline)] get => Description.Fields; }

        public string Format()
            => Description.Format();
        
        public override string ToString()
            => Format();
    }
}
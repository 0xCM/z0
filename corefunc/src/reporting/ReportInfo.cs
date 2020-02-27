//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public readonly struct ReportInfo
    {
        public static ReportInfo Define(IEnumerable<ReportFieldInfo> fields)
            => new ReportInfo(fields.ToArray());
        
        ReportInfo(ReportFieldInfo[] fields)
        {
            this.Fields = fields;
        }
        
        public readonly ReportFieldInfo[] Fields;


        public int FieldCount
            => Fields.Length;
        
        public ref readonly ReportFieldInfo this[int i]
            => ref Fields[i];
    }

}
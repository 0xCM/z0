//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct Tabular<F,R> : ITabular<F,R>
        where F : unmanaged, Enum
        where R : ITabular
    {
        readonly R Record;

        readonly Func<R,char,string> Formatter;
    
        [MethodImpl(Inline)]
        public Tabular(R record, Func<R,char,string> formatter)
        {
            Record = record;
            Formatter = formatter;
        }
        
        public string DelimitedText(char delimiter)
            => Formatter(Record,delimiter);
    }
}
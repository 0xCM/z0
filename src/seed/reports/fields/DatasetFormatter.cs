//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DatasetFormatter<F> : IDatasetFormatter<F>
        where F : unmanaged, Enum
    {        
        public static IDatasetFormatter<F> Default 
            => new DatasetFormatter<F>(text.build());
                                                
        public StringBuilder State {get;}

        readonly char Delimiter;
        
        public static implicit operator string(DatasetFormatter<F> src)
            => src.ToString();
        
        [MethodImpl(Inline)]
        public DatasetFormatter(StringBuilder state, char delimiter = FieldDelimiter)
        {
            State = state;
            Delimiter = delimiter;
        }

        public override string ToString()
            => State.ToString();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    partial struct TextTools
    {
        public IEnumerable<TextRows> partition(TextGrid src, int offset, Func<TextRow,bool> f)
        {
            var part = list<TextRow>();
            for(var i=offset; i<src.RowCount; i++)
            {
                var row = src[i];
                if(f(row))
                {
                    yield return new TextRows(part.ToArray());
                    part.Clear();
                }
                else
                    part.Add(row);
            }
        }
    }
}
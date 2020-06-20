//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static int count(ReadOnlySpan<string> src, int start, char exclude)
        {
            var count = 0;
            for(var i=start; i<src.Length; i++)
            {
                ReadOnlySpan<char> data = Root.skip(src,i);
                
                for(var j=0; j<data.Length; j++)
                {
                    ref readonly var c = ref Root.skip(data,j);
                    if(!SymTest.IsWhiteSpace(c) && c != exclude)
                        count++;
                }
            }
            return count;
        }
    }
}
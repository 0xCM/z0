//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tools;
    
    using static Konst;
    using static z;

    partial struct Tooling
    {
        public static ListedFiles listed<T,F>(ToolFiles<T,F> src)   
            where T : struct, ITool<T>
            where F : unmanaged, Enum  
        {   
            var view = src.View;
            var buffer = sys.alloc<ListedFile>(src.Count);
            var dst = span(buffer);
            for(var i=0u; i<src.Count; i++)
                seek(dst,i) = new ListedFile(i, skip(view,i).Path.Name);
            return buffer;
        }
    }
}
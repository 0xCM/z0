//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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
                seek(dst,i) = new ListedFile(i, skip(view,i).EmissionPath.Name);
            return buffer;
        }

        public static ListedFiles listed<T>(ToolFiles<T> src)   
            where T : struct, ITool<T>
        {   
            var table = src.Table;
            var view = table.View;
            var count = table.Count;
            var buffer = sys.alloc<ListedFile>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new ListedFile(i, skip(view,i).EmissionPath.Name);
            return buffer;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Includes
    {
        public static IncludePath concat(IncludePath a, IncludePath b)
        {
            var dst = alloc<FS.FolderPath>(a.EntryCount + b.EntryCount);
            concat(a,b,dst);
            return dst;
        }

        public static IncludePath concat(IncludePath a, FS.FolderPath b)
        {
            var dst = alloc<FS.FolderPath>(a.EntryCount + 1);
            concat(a, include(b), dst);
            return dst;
        }

        public static IncludePath concat(FS.FolderPath a, IncludePath b)
        {
            var dst = alloc<FS.FolderPath>(b.EntryCount + 1);
            concat(include(a), b, dst);
            return dst;
        }

        [Op]
        public static void concat(IncludePath a, IncludePath b, IncludePath dst)
        {
            var ka = a.EntryCount;
            var va = a.Entries;
            var kb = b.EntryCount;
            var vb = b.Entries;
            var count = ka + kb;
            ref var target = ref dst.Data.First;
            var j=0;
            for(var i=0; i<ka; i++,j++)
                seek(target,j) = skip(va,i);
            for(var i=0; i<kb; i++,j++)
                seek(target,j) = skip(vb,i);
        }
    }
}
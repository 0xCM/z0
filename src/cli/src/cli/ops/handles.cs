//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;
    using static memory;

    partial struct Cli
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint handles<T>(Span<T> dst)
            where T : unmanaged
        {
            var counter = 0u;
            var max = dst.Length;
            var handles = new CliHandles<T>(max);
            for(var i=0; i<max; i++)
            {
                if(handles.Next(out seek(dst,i)))
                    counter++;
                else
                    break;
            }
            return counter;
        }
    }
}
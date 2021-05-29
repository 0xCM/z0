//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    [ApiHost]
    public class AsmJobs : AppService<AsmJobs>
    {
        [Op]
        public static AsmEncodingJob encoding(uint count)
            => new AsmEncodingJob(count);

        [MethodImpl(Inline), Op]
        public static AsmEncodingJob encoding(Index<AsmEncodingTask> tasks)
            => new AsmEncodingJob(tasks);

        [Op]
        public static AsmEncodingJob encoding(params string[] src)
            => encoding(root.mapi(src, (i,s) => AsmTasks.encoding(i.ToString(), s)));
    }
}
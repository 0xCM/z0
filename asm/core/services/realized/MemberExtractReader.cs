//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    using Record = MemberExtractRecord;

    readonly struct MemberExtractReader : IMemberExtractReader
    {
        [MethodImpl(Inline)]
        public static IMemberExtractReader Create(IContext context)
            => default(MemberExtractReader);

        public IEnumerable<Record> Read(FilePath src)
        {
            var count = 0;
            foreach(var line in src.ReadLines())
            {
                if(count++ != 0)
                {
                    yield return Record.Parse(line);
                }

            }
        }        
    }
}
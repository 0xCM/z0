//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    public static class Deconstructions
    {
        public static InstructionBlock Instructions(this INativeMemberData src)
            => Deconstructor.Decode(src.Identity, src.Content);

        public static IEnumerable<InstructionBlock> Instructions<T>(this IEnumerable<T> src)
            where T : INativeMemberData
                => from member in src select member.Instructions();

        public static string Format(this InstructionBlock src)
            => src.FormatAsm(true,true,true).FormatLines();
    }

}
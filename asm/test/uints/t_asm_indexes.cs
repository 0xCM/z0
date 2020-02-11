//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    using static zfunc;

    public class t_asm_indexes : t_asm<t_asm_indexes>
    {
        public void ListFiles()
        {
            // var archive = Context.CodeArchive(AssemblyId.GMath);
            // iter(archive.Read(), c => Trace(c.Id));

            iter(typeof(math).Assembly.ApiHosts(), t => Trace(t.ToString()));


            

        }

    }

}

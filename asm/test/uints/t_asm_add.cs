//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public class t_asm_add : AsmOpTest<t_asm_add>
    {
        protected override string OpName 
            => "add";

        protected override FolderName AsmFolder
            => FolderName.Define(nameof(math));

        public void add_bench()
        {
            add_bench(z8);
            add_bench(z8i);
            add_bench(z16);
            add_bench(z16i);
            add_bench(z32);
            add_bench(z32i);
            add_bench(z64);
        }

        public void add_check()
        {
            add_check(z8);
            add_check(z8i);
            add_check(z16);
            add_check(z16i);
            add_check(z32);
            add_check(z32i);
            add_check(z64);
            add_check(z64i);            
        }

        void add_check<T>(T t = default)
            where T : unmanaged
        {
            CheckAsmMatch2(gmath.add, ReadAsm(t));
        }

        void add_bench<T>(T t = default)
            where T : unmanaged
        {
            using var buffer = AsmExecBuffer.Create();        
            RunBench(gmath.add, buffer.BinOp(ReadAsm(t)));            
        }
    }
}

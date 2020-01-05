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
            using var buffer = AsmExecBuffer.Create();            

            add_bench(buffer, z8);
            add_bench(buffer, z8i);
            add_bench(buffer, z16);
            add_bench(buffer, z16i);
            add_bench(buffer, z32);
            add_bench(buffer, z32i);
            add_bench(buffer, z64);
        }

        public void add_check()
        {
            using var buffer = AsmExecBuffer.Create();            

            add_check(buffer, z8);
            add_check(buffer, z8i);
            add_check(buffer, z16);
            add_check(buffer, z16i);
            add_check(buffer, z32);
            add_check(buffer, z32i);
            add_check(buffer, z64);
            add_check(buffer, z64i);            
        }

        void add_check<T>(AsmExecBuffer buffer, T t = default)
            where T : unmanaged
        {
            buffer.Load(ReadAsm<T>());
            CheckMatch(buffer.BinOp<T>(),gmath.add);
        }

        void add_bench<T>(AsmExecBuffer buffer, T t = default)
            where T : unmanaged
        {
            buffer.Load(ReadAsm<T>());
            RunBench(buffer.BinOp<T>(), gmath.add<T>);
        }
    }
}

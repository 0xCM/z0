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
 
    using static zfunc;
    
    public class t_reveal_delegates: UnitTest<t_reveal_delegates>
    {

        [MethodImpl(Inline)]
        static Func<Vector256<uint>,Vector256<uint>> shuffler2()
            => x => Avx2.Shuffle(x,2);



        public void shuffle_test()
        {
            var x = Random.CpuVector<uint>(n256);
            var f = shuffler2();
            var decode = f.CaptureDelegateAsm(100).Instructions();
            Trace(decode.Format());        
        }

        public void generic_test()
        {
            var methods = typeof(gmath).DeclaredMethods().Public().BinaryOps().OpenGeneric().WithNameStartingWith("nand");
            var data = methods.CaptureGenericAsm(typeof(double)).Instructions();
            foreach(var item in data)
                Trace(item.Format());
            
        }
 
    }
}
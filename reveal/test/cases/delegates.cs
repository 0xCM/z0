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

    using static zfunc;
    
    public class t_reveal_delegates: UnitTest<t_reveal_delegates>
    {

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
            => x => ginx.vshuf4x32<T>(x, Arrange4L.AABB);


        public void immtest_1()
        {
            var x = Random.CpuVector<uint>(n256);
            var f = shuffler<uint>(n2);
            Span<byte> buffer = new byte[100];
            var decode = AsmDecoder.block(f.CaptureNative(buffer));
            Trace(decode.FormatInstructionLines());        
        }

        public void immtest_2()
        {
            var instructions = AsmDecoder.block(GetType().DeclaredMethods().WithNameLike(nameof(shuffler)).Single().CaptureNative(typeof(uint)));
            Trace(instructions.FormatInstructionLines());
        }

        public void generic_test()
        {
            Span<byte> buffer = new byte[100];
            var methods = typeof(gmath).DeclaredMethods().Public().BinaryOps().OpenGeneric().WithNameStartingWith("nand");
            var data = AsmDecoder.blocks(methods.CaptureNative(typeof(double)));
            foreach(var item in data)
                Trace(item.FormatInstructionLines());
            
        }
 
    }
}
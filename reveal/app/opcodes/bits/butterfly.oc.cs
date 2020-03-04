//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
 
    using static zfunc;
    using static As;

    /// <summary>
    /// Opcodes for bitmatrix operations
    /// </summary>
    [OpCodeProvider]
    public static class butterfly
    {        
        public static uint bfly_1x32(uint src)
            => gbits.bfly(n1,src);

        public static uint bfly_1x32_op(uint src)
            => BitCoreServices.bfly(n1,z32).Invoke(src);


        public static uint bfly_2x32(uint src)
            => gbits.bfly(n2,src);

        public static uint bfly_2x32_op(uint src)
            => BitCoreServices.bfly(n2,z32).Invoke(src);

        public static uint bfly_4x32(uint src)
            => gbits.bfly(n4,src);

        public static uint bfly_4x32_op(uint src)
            => BitCoreServices.bfly(n4,z32).Invoke(src);

    }

}

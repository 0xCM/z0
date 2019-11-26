//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static zfunc;

    /// <summary>
    /// Opcodes for memory-related operations
    /// </summary>
    public static class memoc
    {
        static N64 n64 => default;
        
        public static int blockalign_64x8u_var(int cellcount)
            => DataBlocks.blockalign<byte>(n64,cellcount);

        public static int blockalign_64x8u_16()
            => DataBlocks.blockalign<byte>(n64,16);

        public static int blockalign_64x8u_17()
            => DataBlocks.blockalign<byte>(n64,17);

    }


}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    
    partial class dinx
    {                

        /// <summary>
        /// Rotates each component in the source vector leftwards by the amount specified
        /// int the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vrotl(in Vec128<ulong> src, in Vec128<ulong> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vec128u64,offsets));
            return dinx.vor(x,y);
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the 
        /// corresponding component in the offsets vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vrotl(in Vec256<ulong> src, in Vec256<ulong> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vec256u64,offsets));
            return dinx.vor(x,y);
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the 
        /// corresponding component in the offsets vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vrotl(in Vec256<uint> src, in Vec256<uint> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vec256u32,offsets));
            return dinx.vor(x,y);
        }


        static readonly Vec128<ulong> Vec128u64 = Vec128.Fill(64ul);

        static readonly Vec256<uint> Vec256u32 = Vec256.Fill(32u);

        static readonly Vec256<ulong> Vec256u64 = Vec256.Fill(64ul);

    }

}
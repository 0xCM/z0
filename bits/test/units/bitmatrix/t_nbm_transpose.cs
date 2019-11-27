//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_nbm_transpose : t_bm<t_nbm_transpose>
    {
        public void nbm_transpose_12x14x16()
            => nbm_transpose_check<N12,N14,short>();

        public void nbm_transpose_13x64x32()
            => nbm_transpose_check<N13,N64,uint>();

        public void nbm_transpose_32x32x8()
            => nbm_transpose_check<N32,N32,byte>();

        public void nbm_transpose_8x8x8()
            => nbm_transpose_check<N8,N8,byte>();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_nbm_and : t_bm<t_nbm_and>
    {        

        public void nbm_and_64x64()
            => nbm_and_check<N64,ulong>();

        public void nbm_and_64x16()
            => nbm_and_check<N64,ushort>();

        public void nbm_and_256x256()
            => nbm_and_check<N256,uint>();


    }

}
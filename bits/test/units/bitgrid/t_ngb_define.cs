//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_nbg_define : t_bg<t_nbg_define>
    {        
        public void nbg_define_3x5x8()
            => nbg_define_check(n3, n5, z8);

        public void nbg_define_17x11x8()
            => nbg_define_check(n17, n11, z8);

        public void nbg_define_30x30x32()
            => nbg_define_check(n30, n30, z32);

        public void nbg_define_32x32x64()
            => nbg_define_check(n32, n32, z64);

        public void nbg_define_32x33x64()
            => nbg_define_check(n32, n33, z64);

        public void nbg_define_32x34x64()
            => nbg_define_check(n32, n34, z64);

        public void nbg_define_32x35x64()
            => nbg_define_check(n32, n35, z64);

        public void nbg_define_42x32x64()
            => nbg_define_check(n42, n32, z64);

        public void nbg_define_33x42x64()
            => nbg_define_check(n33,n42, z64);

        public void nbg_define_34x37x64()
            => nbg_define_check(n34, n37, z64);

        public void nbg_define_35x35x64()
            => nbg_define_check(n35, n35, z64);

        public void nbg_define_35x55x64()
            => nbg_define_check(n55, n55, z64);

        public void nbg_define_35x55x8()
            => nbg_define_check(n55, n55, z8);

    }

}

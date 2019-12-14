//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vclear : t_vcpu<t_vclear>
    {

        public void vclear_128x8()
            => vclear_check(n128,z8);

        public void vclear_128x32()
            => vclear_check(n128,z32);

        public void vclear_256x8()
            => vclear_check(n256,z8);

        public void vclear_256x16()
            => vclear_check(n256,z16);

        public void vclear_256x32()
            => vclear_check(n256,z32);

        public void vclear_256x64()
            => vclear_check(n256,z16);

    }
}
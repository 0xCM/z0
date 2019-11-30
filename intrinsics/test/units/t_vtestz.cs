//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vtestz : IntrinsicTest<t_vtestz>
    {

        public void vtestz_128x8i()
            => vtestz_check<sbyte>(n128);

        public void vtestz_128x8u()
            => vtestz_check<byte>(n128);

        public void vtestz_128x16i()
            => vtestz_check<short>(n128);

        public void vtestz_128x16u()
            => vtestz_check<ushort>(n128);

        public void vtestz_128x32i()
            => vtestz_check<int>(n128);

        public void vtestz_g128x32u()
        {
            vtestz_check<uint>(n128);
        }

        public void vtestz_g128x64i()
        {
            vtestz_check<long>(n128);
        }

        public void vtestz_g128x64u()
        {
            vtestz_check<ulong>(n128);
        }

        public void vtestz_128x32f()
        {
            vtestz_check<float>(n128);
        }

        public void vtestz_128x64f()
            => vtestz_check<double>(n128);

        public void vtestz_256x8i()
            => vtestz_check<sbyte>(n256);

        public void vtestz_256x8u()
        {
            vtestz_check<byte>(n256);
        }

        public void vtestz_256x16i()
        {
            vtestz_check<short>(n256);
        }

        public void vtestz_256x16u()
            => vtestz_check<ushort>(n256);

        public void vtestz_256x32i()
        {
            vtestz_check<int>(n256);
        }

        public void vtestz_256x32u()
        {
            vtestz_check<uint>(n256);
        }

        public void vtestz_256x64i()
            => vtestz_check<long>(n256);

        public void vtestz_256x64u()
            => vtestz_check<ulong>(n256);

        public void vtestz_256x32f()
        {
            vtestz_check<float>(n256);
        }

        public void vtestz_256x64f()
            => vtestz_check<double>(n256);


    }
}

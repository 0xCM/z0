//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vnot : t_vinx<t_vnot>
    {
        public void vnot_128x8i()
            => vnot_check<sbyte>(n128);

        public void vnot_128x8u()
            => vnot_check<byte>(n128);

        public void vnot_128x16i()
            => vnot_check<short>(n128);

        public void vnot_128x16u()
            => vnot_check<ushort>(n128);

        public void vnot_128x32i()
            => vnot_check<int>(n128);

        public void vnot_128x32u()
            => vnot_check<uint>(n128);

        public void vnot_128x64i()
            => vnot_check<long>(n128);

        public void vnot_128x64u()
            => vnot_check<ulong>(n128);

        public void vnot_256x8i()
            => vnot_check<sbyte>(n256);

        public void vnot_256x8u()
            => vnot_check<byte>(n256);

        public void vnot_256x16i()
            => vnot_check<short>(n256);

        public void vnot_256x16u()
            => vnot_check<ushort>(n256);

        public void vnot_256x32i()
            => vnot_check<int>(n256);

        public void vnot_256x32u()
            => vnot_check<uint>(n256);

        public void vnot_256x64i()
            => vnot_check<long>(n256);

        public void vnot_256x64u()
            => vnot_check<ulong>(n256);
   }

}
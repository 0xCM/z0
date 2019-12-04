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

    public class t_vinsert : t_vinx<t_vinsert>
    {
        public void vinsert_128x8i()
            => vinsert_check<sbyte>(n128);            

        public void vinsert_128x8u()
            => vinsert_check<byte>(n128);            

        public void vinsert_128x16i()
            => vinsert_check<short>(n128);            

        public void vinsert_128x16u()
            => vinsert_check<ushort>(n128);            

        public void vinsert_128x32i()
            => vinsert_check<int>(n128);            

        public void vinsert_128x32u()
            => vinsert_check<uint>(n128);            

        public void vinsert_128x64i()
            => vinsert_check<long>(n128);            

        public void vinsert_128x64u()
            => vinsert_check<ulong>(n128);            

        public void vinsert_128x32f()
            => vinsert_check<float>(n128);
        
        public void vinsert_128x64f()
            => vinsert_check<double>(n128);
    }
}

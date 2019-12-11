//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vnext : t_vinx<t_vnext>
    {   
        public void next_128x8i()
            => next_check<byte>(n128);

        public void next_128x8u()        
            => next_check<byte>(n128);

        public void next_128x16i()
            => next_check<short>(n128);

        public void next_128x16u()        
            => next_check<ushort>(n128);

        public void next_128x32i()
           => next_check<int>(n128);

        public void next_128x32u()
            => next_check<uint>(n128);

        public void next_128x64i()        
            => next_check<long>(n128);        

        public void next_128x64u()
            => next_check<ulong>(n128);

        public void next_256x8i()
            => next_check<byte>(n256);

        public void next_256x8u()        
            => next_check<byte>(n256);

        public void next_256x16i()
            => next_check<short>(n256);

        public void next_256x16u()        
            => next_check<ushort>(n256);

        public void next_256x32i()
           => next_check<int>(n256);

        public void next_256x32u()
            => next_check<uint>(n256);

        public void next_256x64i()        
            => next_check<long>(n256);        

        public void next_256x64u()
            => next_check<ulong>(n256);
    }
}

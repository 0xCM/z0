//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vbroadcast : t_vinx<t_vbroadcast>
    {
        public void vbc_128x8i()
            => vbc_check<sbyte>(n128);   

        public void vbc_128x8u()        
            => vbc_check<byte>(n128);   
        
        public void vbc_128x16i()
            => vbc_check<short>(n128);   

        public void vbc_128x16u()
            => vbc_check<ushort>(n128);   

        public void vbc_128x32i()
            => vbc_check<int>(n128);   

        public void vbc_128x32u()
            => vbc_check<uint>(n128);   

        public void vbc_128x64i()
            => vbc_check<long>(n128);   

        public void vbc_128x64u()
            => vbc_check<ulong>(n128);   

        public void vbc_128x32f()
            => vbc_check<float>(n128); 

        public void vbc_128x64f()
            => vbc_check<double>(n128);

        public void vbc_256x8i()
            => vbc_check<sbyte>(n256);   
        
        public void vbc_256x8u()
            => vbc_check<byte>(n256);   
        
        public void vbc_256x16i()
            => vbc_check<short>(n256);   

        public void vbc_256x16u()
            => vbc_check<ushort>(n256);   

        public void vbc_256x32i()
            => vbc_check<int>(n256);   

        public void vbc_256x32u()
            => vbc_check<uint>(n256);   

        public void vbc_256x64i()
            => vbc_check<long>(n256);   

        public void vbc_256x64u()
            => vbc_check<ulong>(n256);   

        public void vbc_256x32f()
            => vbc_check<float>(n256); 

        public void vbc_256x64f()
            => vbc_check<double>(n256);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    public static class Blender
    {                
        public static Vector128<byte> blend(Vector128<byte> x, Vector128<byte> y, ushort control)
        {
            var mask = dinx.vmakemask(control);
            return dinx.vblend(x,y,mask);
        }

        public static Vector256<byte> blend(Vector256<byte> x, Vector256<byte> y, uint control)        
        {
            var mask = dinx.vmakemask(control);
            return dinx.vblend(x,y,mask);
        }

    }

}
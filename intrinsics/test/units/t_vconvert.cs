//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static HexConst;


    public class t_vconvert : IntrinsicTest<t_vconvert>
    {   

        static string Format<S,T>(Vector128<S> x, Vector128<T> y)
            where S : unmanaged
            where T : unmanaged
        {
            var srcType = moniker<S>();
            var srcCount = x.Length();
            var dstType = moniker<T>();
            var dstCount = y.Length();
            var srcWidth = srcCount * bitsize<S>();
            var dstWidth = dstCount * bitsize<T>();
            var srcLabel = $"v{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:{x.FormatHex(true)} -> {y.FormatHex(true)}";
            return formatted;
        }

        public void v128x8u_v128x16u()
        {
            var x = dinx.vparts(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y = dinx.vconvert(x, out Vector128<ushort> _);
            var z = dinx.vparts(n128,0,1,2,3,4,5,6,7);
            Trace(Format(x,y));
            Claim.eq(y,z);
            
        }

    }

}
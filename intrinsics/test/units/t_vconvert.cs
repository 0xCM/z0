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

        static string Format<S,T>(Span64<S> x, Vector128<T> y)
            where S : unmanaged
            where T : unmanaged
        {
            var srcType = moniker<S>();
            var srcCount = x.Length;
            var dstType = moniker<T>();
            var dstCount = y.Length();
            var srcWidth = srcCount * bitsize<S>();
            var dstWidth = dstCount * bitsize<T>();
            var srcLabel = $"m{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:{x.Unblocked.FormatHex(true)} -> {y.FormatHex(true)}";
            return formatted;
        }

        public void v128x8u_v128x16u()
        {
            var x = dinx.vparts(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y = dinx.vconvert(x, out Vector128<ushort> _);
            var z = dinx.vparts(n128,0,1,2,3,4,5,6,7);
            Claim.eq(y,z);
        }

        public void m64x8u_v128x16u()
        {
            var x = BlockedSpan.load<byte>(n64,0,1,2,3,4,5,6,7);
            var y = dinx.vconvert(x, out Vector128<ushort> _);
            var z = dinx.vparts(n128,0,1,2,3,4,5,6,7);            

            Claim.eq(y,z);
            
        }

        public void blockspan_128x8u_v128x16u()
        {
            var x = BlockedSpan.load<byte>(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            dinx.vconvert(x, out Vector128<ushort> y0, out Vector128<ushort> y1);
            var z0 = x.Block(n64,0);
            var z1 = x.Block(n64,1);
            var y0s = y0.ToSpan();
            var y1s = y1.ToSpan();

            for(var i=0; i <8; i++)
            {
                Claim.eq(z0[i], (byte)y0s[i]);
                Claim.eq(z1[i], (byte)y1s[i]);
            }                                 
        }

        public void bitspan_5x8u_v128x32u()
        {
            var x = BitSpan.load<N5,byte>(0,1,2,3,4);
            dinx.vconvert(x, out Vector128<uint> y);
            var ys = y.ToSpan();
            for(var i=0; i<4; i++)
                Claim.eq(x[i],(byte)ys[i]);
            
                                 
        }

        public void blockspan_64x8u_v2x128x32u()
        {
            var x = BlockedSpan.load<byte>(n64,0,1,2,3,4,5,6,7);
            dinx.vconvert(x, out Vector128<uint> y0, out Vector128<uint> y1);
            var z0 = x.Slice(0,4);
            var z1 = x.Slice(4,4);
            var y0s = y0.ToSpan();
            var y1s = y1.ToSpan();

            for(var i=0; i <4; i++)
            {
                Claim.eq(z0[i], (byte)y0s[i]);
                Claim.eq(z1[i], (byte)y1s[i]);
            }
                                 
        }
    }

}
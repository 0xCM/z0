//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
        
    partial class inxs
    {
        [MethodImpl(Inline)]
        public static ref ushort broadcast(byte src, out ushort dst)
        {
            dst = vhead<byte,ushort>(CpuVector.broadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint broadcast(byte src, out uint dst)
        {
            dst = vhead<byte,uint>(CpuVector.broadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong broadcast(byte src, out ulong dst)
        {
            dst = vhead<byte,ulong>(CpuVector.broadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint broadcast(ushort src, out uint dst)
        {
            dst = vhead<ushort,uint>(CpuVector.broadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong broadcast(ushort src, out ulong dst)
        {
            dst = vhead<ushort,ulong>(CpuVector.broadcast(n128, src));
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static ref ulong broadcast(uint src, out ulong dst)
        {
            dst = vhead<uint,ulong>(CpuVector.broadcast(n128, src));
            return ref dst;
        }


    }

}
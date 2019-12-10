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
            dst = vhead<byte,ushort>(dinx.vbroadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint broadcast(byte src, out uint dst)
        {
            dst = vhead<byte,uint>(dinx.vbroadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong broadcast(byte src, out ulong dst)
        {
            dst = vhead<byte,ulong>(dinx.vbroadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint broadcast(ushort src, out uint dst)
        {
            dst = vhead<ushort,uint>(dinx.vbroadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong broadcast(ushort src, out ulong dst)
        {
            dst = vhead<ushort,ulong>(dinx.vbroadcast(n128, src));
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static ref ulong broadcast(uint src, out ulong dst)
        {
            dst = vhead<uint,ulong>(dinx.vbroadcast(n128, src));
            return ref dst;
        }


    }

}
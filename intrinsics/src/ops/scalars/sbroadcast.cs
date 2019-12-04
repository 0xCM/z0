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
    using static As;
    using static AsIn;
    
    partial class sinx
    {
        [MethodImpl(Inline)]
        public static ref ulong sbroadcast(byte src, out ulong dst)
        {
            dst = vhead<byte,ulong>(dinx.vbroadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong sbroadcast(ushort src, out ulong dst)
        {
            dst = vhead<ushort,ulong>(dinx.vbroadcast(n128, src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong sbroadcast(uint src, out ulong dst)
        {
            dst = vhead<uint,ulong>(dinx.vbroadcast(n128, src));
            return ref dst;
        }

    }

}
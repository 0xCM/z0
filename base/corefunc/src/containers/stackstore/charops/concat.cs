//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static Stacked;

    partial class Stacks
    {
        [MethodImpl(Inline)]
        public static unsafe CharStack4 concat(in CharStack2 head, in CharStack2 tail)
        {
            const int block = 2;
            var dst = chars(n4);
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst),block), block);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStack8 concat(in CharStack4 head, in CharStack4 tail)
        {
            const int block = 4;
            var dst = chars(n8);
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst), block), block);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStack16 concat(in CharStack8 head, in CharStack8 tail)
        {
            const int block = 8;
            var dst = chars(n16);
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst),block), block);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref CharStack32 concat(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
        {
            const int block = 16;
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst),block), block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static CharStack32 concat(in CharStack16 head, in CharStack16 tail)
        {
            const int block = 16;
            var dst = chars(n32);
            return concat(head,tail,ref dst);
        }

        [MethodImpl(Inline)]
        public static ref CharStack64 concat(in CharStack32 head, in CharStack32 tail, ref CharStack64 dst)
        {
            const int block = 32;
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst),block), block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static CharStack64 concat(in CharStack32 head, in CharStack32 tail)
        {
            const int block = 32;
            var dst = chars(n64);
            return concat(head,tail,ref dst);
        }
    }
}
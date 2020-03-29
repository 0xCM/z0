//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    
    using static Stacked;
    using static refs;

    partial class Stacks
    {
        [MethodImpl(Inline), Op]
        public static unsafe CharStack4 concat(in CharStack2 leads, in CharStack2 follows)
        {
            const int block = 2;
            var dst = char4();
            memory.copy(in first(in leads), ref head(ref dst), block);
            memory.copy(in first(in follows), ref seek(ref head(ref dst), block), block);            
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static CharStack8 concat(in CharStack4 leads, in CharStack4 follows)
        {
            const int block = 4;
            var dst = char8();
            memory.copy(in first(in leads), ref head(ref dst), block);
            memory.copy(in first(in follows), ref seek(ref head(ref dst), block), block);            
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static CharStack16 concat(in CharStack8 leads, in CharStack8 follows)
        {
            const int block = 8;
            var dst = char16();
            memory.copy(in first(in leads), ref head(ref dst), block);
            memory.copy(in first(in follows), ref seek(ref head(ref dst), block), block);            
            return dst;
        }


        [MethodImpl(Inline), Op]
        public static ref CharStack32 concat(in CharStack16 leads, in CharStack16 follows, ref CharStack32 dst)
        {
            const int block = 16;
            memory.copy(in first(in leads), ref head(ref dst), block);
            memory.copy(in first(in follows), ref seek(ref head(ref dst), block), block);            
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static CharStack32 concat(in CharStack16 leads, in CharStack16 follows)
        {
            const int block = 16;
            var dst = char32();
            return concat(leads,follows,ref dst);
        }

        [MethodImpl(Inline), Op]
        public static ref CharStack64 concat(in CharStack32 leads, in CharStack32 follows, ref CharStack64 dst)
        {
            const int block = 32;
            memory.copy(in first(in leads), ref head(ref dst), block);
            memory.copy(in first(in follows), ref seek(ref head(ref dst), block), block);            
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static CharStack64 concat(in CharStack32 leads, in CharStack32 follows)
        {
            const int block = 32;
            var dst = char64();
            return concat(leads,follows,ref dst);
        }
    }
}
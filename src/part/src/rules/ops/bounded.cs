//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bounded<T> bounded<T>(T min, T max)
            where T : unmanaged
                => new Bounded<T>(min,max);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit satisfied<T>(Bounded<T> rule, T src)
            where T : unmanaged
        {
            if(size<T>() == 1)
                return u8(src) >= u8(rule.Min) && u8(src) <= u8(rule.Max);
            else if(size<T>() == 2)
                return u16(src) >= u16(rule.Min) && u16(src) <= u16(rule.Max);
            else if(size<T>() == 4)
                return u32(src) >= u32(rule.Min) && u32(src) <= u32(rule.Max);
            else
                return u64(src) >= u64(rule.Min) && u64(src) <= u64(rule.Max);
        }
    }
}
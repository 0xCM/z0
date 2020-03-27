//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static gmath;
        
    partial class fspan
    {                
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static T avg<T>(ReadOnlySpan<T> src, bool @checked)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.avg(Spans.s32f(src), @checked));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.avg(Spans.s64f(src), @checked));
            else            
                throw Unsupported.define<T>();
        }           

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => avg(src,true);

    }
}
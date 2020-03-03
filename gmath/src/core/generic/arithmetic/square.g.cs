//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T square<T>(T a)
            where T : unmanaged
                => square_u(a);
                
        [MethodImpl(Inline)]
        static T square_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.square(convert<T,uint>(a)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.square(convert<T,uint>(a)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.square(uint32(a)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.square(uint64(a)));
            else
                return square_i(a);
        }

        [MethodImpl(Inline)]
        static T square_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.square(convert<T,int>(a)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.square(convert<T,int>(a)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.square(int32(a)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.square(int64(a)));
            else
                return gfp.square(a);
        }

    }
}
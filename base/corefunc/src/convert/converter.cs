//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static AsIn;
    using static As;
    
    using static zfunc;

    public static partial class Converter
    {
        [MethodImpl(Inline)]   
        public static T convert<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
                => convert_u<S,T>(src);
        
        [MethodImpl(Inline)]
        static T convert_u<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(byte))
                return convert<T>(uint8(src));
            else if(typeof(S) == typeof(ushort))
                return convert<T>(uint16(src));
            else if(typeof(S) == typeof(uint))
                return convert<T>(uint32(src));
            else if(typeof(S) == typeof(ulong))
                return convert<T>(uint64(src));
            else
                return convert_i<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_i<S,T>(S src)
                where S : unmanaged
                where T : unmanaged
        {
            if(typeof(S) == typeof(sbyte))
                return convert<T>(int8(src));
            else if(typeof(S) == typeof(short))
                return convert<T>(int16(src));
            else if(typeof(S) == typeof(int))
                return convert<T>(int32(src));
            else if(typeof(S) == typeof(long))
                return convert<T>(int64(src));
            else 
                return convert_x<S,T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_x<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
        {
            if(typeof(S) == typeof(float))
                return convert<T>(float32(src));
            else if(typeof(S) == typeof(double))
                return convert<T>(float64(src));
            else if(typeof(S) == typeof(char))
                return convert<T>(char16(src));
            else            
                return unhandled<S,T>(src);
        }

        static T unhandled<S,T>(S src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            Errors.Throw($"The conversion {typename<S>()} -> {typename<T>()} needed for the value {src} doesn't exist", caller,file,line);
            return default;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    using static As;
    using static AsIn;
    
    partial class gmath
    {
        /// <summary>
        /// Returns true if a primal integer is odd; false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static bool odd<T>(T src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return zfunc.odd(int8(src));  
            else if(typematch<T,byte>())
                return zfunc.odd(uint8(src));  
            else if(typematch<T,short>())
                return zfunc.odd(int16(src));  
            else if(typematch<T,ushort>())
                return zfunc.odd(uint16(src));  
            else if(typematch<T,int>())
                return zfunc.odd(int32(src));  
            else if(typematch<T,uint>())
                return zfunc.odd(uint32(src));  
            else if(typematch<T,long>())
                return zfunc.odd(int64(src));  
            else if(typematch<T,ulong>())
                return zfunc.odd(uint64(src));  
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Returns true if a primal integer is even; false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static bool even<T>(T src)
            where T : unmanaged
                => !odd<T>(src);    

    }

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class gmath
    {
        /// <summary>
        /// Computes the quotient of two values of primal type
        /// </summary>
        /// <param name="lhs">The quantity divided by the right operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(math.div(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(math.div(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(math.div(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(math.div(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(math.div(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(math.div(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(math.div(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(math.div(uint64(lhs), uint64(rhs)));
            else            
                return gfp.div(lhs,rhs);

        }


        /// <summary>
        /// Computes the quotient in-place of two values of primal type
        /// </summary>
        /// <param name="lhs">The quantity divided by the right operand and which is replaced by the result</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T div<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typematch<T,sbyte>())
                math.div(ref int8(ref lhs), in int8(in rhs));
            else if(typematch<T,byte>())
                math.div(ref uint8(ref lhs), in uint8(in rhs));
            else if(typematch<T,short>())
                math.div(ref int16(ref lhs), in int16(in rhs));
            else if(typematch<T,ushort>())
                math.div(ref uint16(ref lhs), in uint16(in rhs));
            else if(typematch<T,int>())
                math.div(ref int32(ref lhs), in int32(in rhs));
            else if(typematch<T,uint>())
                math.div(ref uint32(ref lhs), in uint32(in rhs));
            else if(typematch<T,long>())
                math.div(ref int64(ref lhs), in int64(in rhs));
            else if(typematch<T,ulong>())
                math.div(ref uint64(ref lhs), in uint64(in rhs));
            else
                gfp.div(ref lhs, rhs);
            return ref lhs;
        }


    }

}
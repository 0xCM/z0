//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static AsIn;
    using static Seed; using static Memories;
    
    using BL = ByteLogic;
    
    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquares
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit testz<T>(in T A, in T B)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testz(in uint8(in A), in uint8(in B));
            else if(typeof(T) == typeof(ushort))
               return testz(n, in A, in B);
            else if(typeof(T) == typeof(uint))
               return testz(n, 4, 8, in uint32(in A), in uint32(in B));
            else if(typeof(T) == typeof(ulong))
               return testz(n, 16, 4, in uint64(in A), in uint64(in B));
            else
                throw Unsupported.define<T>();
        }        
    }
}
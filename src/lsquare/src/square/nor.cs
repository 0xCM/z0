//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static In;
    using static Konst; 
    using static Memories;
    
    using BL = ByteLogic;
    
    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquare
    {
        [MethodImpl(Inline), Nor, Closures(UnsignedInts)]
        public static void nor<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.nor(in uint8(in A), in uint8(in B), ref As.uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                nor(w, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                nor(w, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                nor(w, 16, 4, in A, in B, ref Z);
            else
                throw Unsupported.define<T>();
        }
    }
}

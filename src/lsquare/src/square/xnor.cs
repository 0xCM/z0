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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void xnor<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.xnor(in uint8(in a), in uint8(in b), ref As.uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                xnor(w, in a, in b, ref dst);
            else if(typeof(T) == typeof(uint))
                xnor(w, 4, 8, in a, in b, ref dst);
            else if(typeof(T) == typeof(ulong))
                xnor(w, 16, 4, in a, in b, ref dst);
            else
                throw Unsupported.define<T>();
        }
    }
}
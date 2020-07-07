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
        [MethodImpl(Inline), Not, Closures(UnsignedInts)]
        public static void not<T>(in T src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.not(in uint8(in src), ref As.uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                not(w, in src, ref dst);
            else if(typeof(T) == typeof(uint))
                not(w, 4, 8, in src, ref dst);
            else if(typeof(T) == typeof(ulong))
                not(w, 16, 4, in src, ref dst);
            else
                throw Unsupported.define<T>();
        }
    }
}

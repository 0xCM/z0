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
        [MethodImpl(Inline), Op, Closures(NumericKind.Unsigned)]
        public static void nonimpl<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.nonimpl(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                nonimpl(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                nonimpl(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                nonimpl(n, 16, 4, in A, in B, ref Z);
            else
                throw Unsupported.define<T>();
        }
    }
}
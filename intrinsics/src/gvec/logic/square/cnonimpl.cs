//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static AsIn;
    using static Core;
    
    using BL = ByteLogic;
        
    /// <summary>
    /// Defines operators over square bit domains
    /// </summary>
    partial class LogicSquares
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Unsigned)]
        public static void cnonimpl<T>(in T A, in T B, ref T Z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.cnonimpl(in uint8(in A), in uint8(in B), ref uint8(ref Z));
            else if(typeof(T) == typeof(ushort))
                cnonimpl(n, in A, in B, ref Z);
            else if(typeof(T) == typeof(uint))
                cnonimpl(n, 4, 8, in A, in B, ref Z);
            else if(typeof(T) == typeof(ulong))
                cnonimpl(n, 16, 4, in A, in B, ref Z);
            else
                throw Unsupported.define<T>();
        }
    }
}
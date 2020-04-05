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
        public static bit testc<T>(in T A)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testc(in uint8(in A));
            else if(typeof(T) == typeof(ushort))
               return vtestc(n, in A);
            else if(typeof(T) == typeof(uint))
               return testc(n, 4, 8, in A);
            else if(typeof(T) == typeof(ulong))
                return testc(n, 16, 4, in A);
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Unsigned)]
        public static bit testc<T>(in T A, in T B)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               return BL.testc(in uint8(in A),in uint8(in B));
            else if(typeof(T) == typeof(ushort))
               return vtestc(n, in A,in B);
            else if(typeof(T) == typeof(uint))
               return testc(n, 4, 8, in A, in B);
            else if(typeof(T) == typeof(ulong))
                return testc(n, 16, 4, in A, in B);
            else
                throw Unsupported.define<T>();
        }
    }
}
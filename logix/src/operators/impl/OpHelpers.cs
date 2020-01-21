//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    internal static class OpHelpers
    {
       public static UnaryBitwiseOpSpec<T> nologic<T>(UnaryBitLogicKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static BinaryBitwiseOp<T> nologic<T>(BinaryBitLogicKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static TernaryBitwiseOp<T> nologic<T>(TernaryBitLogicKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static bit dne<K>(K kind)        
            where K : Enum
                => throw new NotSupportedException($"{kind}");

       public static UnaryOp<T> dne<T>(UnaryBitLogicKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static BinaryOp<T> dne<T>(BinaryBitLogicKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static BinaryOp<T> dne<T>(ComparisonKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");
       
       public static BitMatrixBinaryRefOp<T> nomareftop<T>(BinaryBitLogicKind id)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static T dne<K,T>(K kind)        
                => throw new NotSupportedException($"{kind}");

       public static Shifter<T> dne<T>(ShiftOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static TernaryOp<T> dne<T>(TernaryBitLogicKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

        public static T canteval<T,E>(E id, T x = default, T y = default, T z = default)
            where T : unmanaged
            where E : Enum
                => throw new NotSupportedException($"{id}");

        public static void Set<T>(IVariedExpr<T> expr, params IExpr<T>[] values)
            where T : unmanaged
        {
            var n = Math.Min(expr.Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                expr.Vars[i].Set(values[i]);
        }

    }

}

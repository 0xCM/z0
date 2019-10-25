//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
       public static UnaryBitwiseOpSpec<T> nologic<T>(UnaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static BinaryBitwiseOp<T> nologic<T>(BinaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static TernaryBitwiseOp<T> nologic<T>(TernaryBitOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static bit dne<K>(K kind)        
            where K : Enum
                => throw new NotSupportedException($"{kind}");

       public static UnaryOp<T> dne<T>(UnaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static UnaryOp<T> dne<T>(UnaryBitwiseOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static BinaryOp<T> dne<T>(BinaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static BinaryOp<T> dne<T>(BinaryBitwiseOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       public static T dne<K,T>(K kind)        
            where T : unmanaged
                => throw new NotSupportedException($"{kind}");

       public static Shifter<T> dne<T>(ShiftOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");
       public static BinaryPred<T> dne<T>(ComparisonOpKind id)
            where T : unmanaged
            => throw new NotSupportedException($"{id}");

       public static TernaryOp<T> dne<T>(TernaryBitOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

        public static T canteval<T,E>(E id, T x = default, T y = default, T z = default)
            where T : unmanaged
            where E : Enum
                => throw new NotSupportedException($"{id}");

        public static void Set<T>(IVariedExpr<T> expr, params ITypedExpr<T>[] values)
            where T : unmanaged
        {
            var n = Math.Min(expr.Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                expr.Vars[i].Set(values[i]);
        }

    }

}

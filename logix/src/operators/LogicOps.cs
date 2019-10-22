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


    internal static class LogicOps
    {
       internal static UnaryLogicOp<T> nologic<T>(UnaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       internal static BinaryLogicOp<T> nologic<T>(BinaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       internal static TernaryLogicOp<T> nologic<T>(TernaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       internal static UnaryOp<T> dne<T>(UnaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       internal static BinaryOp<T> dne<T>(BinaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       internal static Shifter<T> dne<T>(ShiftOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

       internal static TernaryOp<T> dne<T>(TernaryLogicOpKind id, T x = default)        
            where T : unmanaged
                => throw new NotSupportedException($"{id}");

        internal static T canteval<T,E>(E id, T x = default, T y = default, T z = default)
            where T : unmanaged
            where E : Enum
                => throw new NotSupportedException($"{id}");


        internal static void Set<T>(IVariedExpr<T> expr, params IExpr<T>[] values)
            where T : unmanaged
        {
            var n = Math.Min(expr.Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                expr.Vars[i].Set(values[i]);
        }

    }

}

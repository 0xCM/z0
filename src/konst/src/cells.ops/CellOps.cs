//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static Kinds;

    public class CellOpKinds
    {

    }

    [SuppressUnmanagedCodeSecurity, ApiHost]
    public partial class CellOps
    {
        public static CellOpKind[] kinds()
            => typeof(CellOpKinds).StaticProperties(true,false)
                    .Reifies(typeof(ICellOpKind))
                    .Select(p => p.MemberValue<ICellOpKind>(null))
                    .Select(k => new CellOpKind(k.OperandWidth, k.OperandType, k.OperatorType));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        internal static UnaryOp<T> uFx<T>(MethodInfo src, UnaryOpClass<T> k)
            where T : unmanaged
                => Delegates.unary<T>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        internal static BinaryOp<T> bFx<T>(MethodInfo src, BinaryOpClass<T> K)
            where T : unmanaged
                => Delegates.binary<T>(src);
    }
}
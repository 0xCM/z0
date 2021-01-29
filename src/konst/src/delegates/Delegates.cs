//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq.Expressions;

    using static Konst;

    [ApiHost(ApiNames.Delegates)]
    public partial class Delegates
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Infers a delegate type compatible with the signature of a specified method
        /// </summary>
        /// <param name="src">The source method</param>
        public static Type type(MethodInfo src)
        {
            var args = src.ParameterTypes();
            return src.IsAction()
                ? Expression.GetActionType(args)
                : Expression.GetFuncType(Arrays.concat(args, memory.array(src.ReturnType)));
        }
    }

    [ApiHost(ApiNames.DelegatesX)]
    public static partial class XDelegates
    {

    }
}
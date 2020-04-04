//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class XTend
    {
        /// <summary>
        /// Computes an test case identifier for a segmented sfunc
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="f">The function under test</param>
        /// <typeparam name="W">The type width</typeparam>
        /// <typeparam name="T">The cell width</typeparam>
        public static string CaseName<W,T>(this IValidationContext context, ISFuncApi f, W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            var id = Identify.Op<W,T>(f.Id.Name);
            var owner = Identify.owner(context.HostType);
            var host = context.HostType.Name;
            return $"{owner}/{host}/{id}";            
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ClrQuery
    {
        /// <summary>
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static FieldInfo[] fields(Type src)
            => src.GetFields(BF);
    }
}
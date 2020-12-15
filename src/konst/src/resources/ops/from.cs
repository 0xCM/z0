//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Resources
    {
        /// <summary>
        /// Collects all resource accessors defined by a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ComponentResIndex from(Assembly owner, ApiMemberRes[] src)
            => new ComponentResIndex(owner, (from access in src
                let t = access.Member.DeclaringType
                group access by t).Map(x => new ResDeclarations(x.Key, x.ToArray())));
    }
}
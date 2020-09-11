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
        public static ResourceDeclarations[] declarations(Assembly src)
            => (from a in ApiQuery.resources(src).Accessors
                let t = a.Member.DeclaringType
                group a by t).Map(x => new ResourceDeclarations(x.Key, x.ToArray()));

    }
}
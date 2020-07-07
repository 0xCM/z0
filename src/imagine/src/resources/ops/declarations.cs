//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    partial struct Resources
    {
        /// <summary>
        /// Collects all resource accessors defined by a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ResourceDeclarations[] declarations(Assembly src)    
            => (from a in accessors(src).Accessors 
                let t = a.Member.DeclaringType
                group a by t).Map(x => new ResourceDeclarations(x.Key, x.ToArray()));
    }
}
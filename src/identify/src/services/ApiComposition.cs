//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Seed;

    /// <summary>
    /// Defines a collection of resolved assemblies
    /// </summary>
    public readonly struct ApiComposition : IApiComposition,  ITextual
    {
        public static IApiComposition Empty => Assemble();

        [MethodImpl(Inline)]
        public static ApiComposition Assemble(params IPart[] parts)
            => new ApiComposition(parts);

        [MethodImpl(Inline)]
        public static ApiComposition Assemble(IEnumerable<IPart> parts)
            => new ApiComposition(parts.ToArray());

        [MethodImpl(Inline)]
        internal ApiComposition(IPart[] resolved)
            => Resolved = resolved;

        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IPart[] Resolved {get;}   

        public bool IsEmpty
            => Resolved.Length == 0;

        public string Format()
        {
            var dst = text.factory.Builder();
            for(var i=0; i < Resolved.Length; i++)
            {
                dst.Append(Resolved[i].Format());
                if(i != Resolved.Length - 1)
                {
                    dst.Append(text.comma());
                    dst.Append(text.space());
                }
            }
            return dst.ToString();                
        }

        public override string ToString()
            => Format();
    }
}
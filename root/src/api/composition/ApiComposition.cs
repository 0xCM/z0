//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    /// <summary>
    /// Defines a collection of resolved assemblies
    /// </summary>
    public readonly struct ApiComposition : IApiComposition<ApiComposition>
    {
        public static IApiComposition Empty => Assemble();

        [MethodImpl(Inline)]
        public static ApiComposition Assemble(params IApiPart[] resolved)
            => new ApiComposition(resolved);

        [MethodImpl(Inline)]
        ApiComposition(IApiPart[] resolved)
            => Resolved = resolved;

        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IApiPart[] Resolved {get;}   

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
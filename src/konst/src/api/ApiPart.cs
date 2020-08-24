//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using A = PartIdAttribute;

    /// <summary>
    /// Defines a collection of resolved assemblies
    /// </summary>
    public readonly struct ApiPart : IResolvedApi,  ITextual
    {
        [MethodImpl(Inline)]
        public static IApiHost<H> host<H>()
            where H : IApiHost<H>, new()
                => new H();

        [MethodImpl(Inline)]
        public ApiPart(IPart[] resolved)
            => Resolved = resolved;

        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IPart[] Resolved {get;}

        public bool IsEmpty
            => Resolved.Length == 0;

        public string Format()
        {
            var dst = text.build();
            for(var i=0; i < Resolved.Length; i++)
            {
                dst.Append(Resolved[i].Format());
                if(i != Resolved.Length - 1)
                {
                    dst.Append(Chars.Comma);
                    dst.Append(Chars.Space);
                }
            }
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}
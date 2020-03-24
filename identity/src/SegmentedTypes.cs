//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    public static class SegmentedTypes
    {
        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool test(Type t)
            => t.IsBlocked() || t.IsVector();

        public static Option<TypeIndicator> indicator(Type t)
        {
            if(t.IsBlocked())
                return TypeIndicator.Define(IDI.Block);
            else if(t.IsVector())
                return TypeIndicator.Define(IDI.Vector);
            else 
                return none<TypeIndicator>();
        }

        public static Option<TypeIdentity> identify(Type t)
            =>  from i in indicator(t)
                let segwidth = Identity.width(t)
                where segwidth.IsSome()
                let segfmt = segwidth.Format()
                let arg = t.GetGenericArguments().Single()
                let argwidth = Identity.width(arg)
                where   argwidth.IsSome()
                let argfmt = argwidth.Format()
                let nk = arg.NumericKind()
                where  nk != 0
                let nki = nk.Indicator().Format()
                let identifer = text.concat(i, segfmt, IDI.SegSep,argfmt, nki)                
                select SegmentedIdentity.Define(i,segwidth,nk).AsTypeIdentity();
    }
}
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

    using static zfunc;

    public static partial class Identity
    {

        /// <summary>
        /// Produces an identifier of the form {width(nk)}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity identify(NumericKind nk)
            => TypeIdentity.Define(NumericType.signature(nk));

        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => TypeIdentities.identify(t);

        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(MethodInfo src)
        {            
            if(src.IsOpenGeneric())
                return Identity.generic(src);
            else if(src.IsConstructedGenericMethod)
                return Identity.constructed(src);
            else
                return Identity.nongeneric(src);
        }            

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(Delegate m)
            => identify(m.Method);

        public static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var pt = k.ToClrType();
            if(src.IsOpenGeneric() && pt.IsSome())
                return identify(src.MakeGenericMethod(pt.Value));
            else
                return identify(src);
        }

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string host(Type t)
        {
            var defaultName = t.Name.ToLower();
            var query = from a in t.CustomAttribute<OpHostAttribute>()
                        where a.Name.IsNotBlank()
                        select a.Name;
            return query.ValueOrDefault(defaultName);            
        }

        public static OpIdentity subject(string opname, NumericKind kind)
            => Identity.operation($"{opname}_subject",kind);

        public static OpIdentity subject<T>(string opname, T t = default)
            where T : unmanaged
                => subject(opname, NumericType.kind<T>());
         

    }
}
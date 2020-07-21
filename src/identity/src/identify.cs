//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;
    
    public static partial class Identity
    {
        /// <summary>
        /// Assigns host-independent identity to an api member
        /// </summary>
        /// <param name="src">The source method</param>
        public static OpIdentity identify(MethodInfo src)
        {            
            if(src.IsOpenGeneric())
                return GenericIdentity(src).Generialize();
            else if(src.IsConstructedGenericMethod)
                return ConstructedIdentity(src);
            else
                return NonGenericIdentity(src);
        }            

        /// <summary>
        /// Assigns identity to a delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static OpIdentity identify(Delegate src)
            => identify(src.Method);

        /// <summary>
        /// Assigns identity to a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static TypeIdentity identify(Type src)
            => TypeIdentityDiviner.IdentityProvider(src).Identify(src);

        static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var t = k.SystemType();
            if(src.IsOpenGeneric() && t.IsNonEmpty())
                return identify(src.MakeGenericMethod(t));
            else
                return identify(src);
        }
    }
}
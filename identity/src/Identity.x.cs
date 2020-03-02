//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    
    public static partial class IdentityExtensions
    {        
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Option<Type> ToClrType(this NumericKind k)
        {
            var nt = k.NumericType();
            return nt.IsSome() ? some(nt.Subject) : none<Type>();
        }

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string HostName(this Type t)
            => Identity.host(t);

        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this MethodInfo m)
            => Identity.identify(m);

        /// <summary>
        /// Defines a source type identifier, intended to be unique within a caller-determined scope
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        public static TypeIdentity Identify(this Type t)
            => Identity.identify(t);

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this Delegate m)
            => Identity.identify(m);

        /// <summary>
        /// Defines the identity of a generic method
        /// </summary>
        /// <param name="src">The source method</param>
        public static OpIdentity GenericIdentity(this MethodInfo src)
            => Identity.generic(src);

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized scalar part, if the source part is indeed a scalar identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<ScalarIdentity> Scalar(this IdentityPart part)
            => Identity.scalar(part);

        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<IdentityPart> Part(this OpIdentity src, int partidx)
            => Identity.part(src,partidx);

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<SegmentedIdentity> Segment(this IdentityPart part)
            => Identity.segmented(part);
    }
}
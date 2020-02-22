//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static zfunc;

    public static class IdentityX
    {
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
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string OpName(this MethodInfo m)
            => Identity.name(m);

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

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> Segment(this OpIdentity src, int partidx)
            => Identity.segment(src,partidx);

        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public static Option<byte> Imm8(this OpIdentity src)            
            => Identity.imm8(src);

        /// <summary>        
        /// Clears an attached immediate suffix from an identity, if any
        /// </summary>
        /// <param name="src">The source identity</param>
        public static OpIdentity WithoutImm8(this OpIdentity src)
            => Identity.imm8Remove(src);
    
        /// <summary>        
        /// Attaches an immediate suffix to an identity, removing an existing immediate suffix if necessary
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="immval">The immediate value to attach</param>
        public static OpIdentity WithImm8(this OpIdentity src, byte immval)
            => Identity.imm8Add(src,immval);

        public static string TestCaseName(this MethodInfo method)
            => Identity.testcase(method);

        public static string TestCaseName(this IExplicitTest unit)
        {
            var owner = Identity.owner(unit.GetType());
            var hostname = unit.GetType().Name;
            var opname = "explicit";
            return $"{owner}/{hostname}/{opname}";
        }

        public static string TestActionName(this IUnitTest unit)
        {
            var owner = Identity.owner(unit.GetType());
            var hostname = unit.GetType().Name;
            var opname = "action";
         
            return $"{owner}/{hostname}/{opname}";
        }
    }
}

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

    partial class FastOpX
    {     
        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this MethodInfo m)
            => Identity.identify(m);

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this Delegate m)
            => Identity.identify(m);

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string HostName(this Type t)
            => Identity.host(t);
        
        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string OpName(this MethodInfo m)
            => Identity.name(m);

        public static Option<ScalarIdentity> Scalar(this OpIdentityPart part)
            => Identity.scalar(part);

        public static Option<OpIdentityPart> Part(this OpIdentity src, int partidx)
            => Identity.part(src,partidx);

        public static Option<OpIdentitySegment> Segment(this OpIdentityPart part)
            => Identity.segment(part);

        public static Option<OpIdentitySegment> Segment(this OpIdentity src, int partidx)
            => Identity.segment(src,partidx);

        public static Option<byte> Imm8(this OpIdentity src)            
            => Identity.imm8(src);

        public static OpIdentity WithoutImm8(this OpIdentity src)
            => Identity.imm8Remove(src);
    
        public static OpIdentity WithImm8(this OpIdentity src, byte immval)
            => Identity.imm8Add(src,immval);
    }
}
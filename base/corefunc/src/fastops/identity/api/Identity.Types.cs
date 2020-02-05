//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class Identity
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
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Signature()}");
        
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Signature()}");   

        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => TypeIdentities.identify(t);

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity numericid<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(NumericType.signature(typeof(T)));

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized scalar part, if the source part is indeed a scalar identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<ScalarIdentity> scalar(IdentityPart part)
        {
            if(part.PartKind == IdentityPartKind.Scalar)
            {
                return from k in NumericType.parseKind(part.PartText)
                    let scalar = ScalarIdentity.Define((FixedWidth)k.Width(), k.Indicator())
                    select scalar;
            }
            else
                return none<ScalarIdentity>();                
        }

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<SegmentedIdentity> segment(IdentityPart part)
        {
            if(part.PartKind == IdentityPartKind.Segment)
            {
                if(SegmentedIdentity.TryParse(part.PartText, out var seg))
                    return seg;                
            }

            return none<SegmentedIdentity>();                
        }
    }
}
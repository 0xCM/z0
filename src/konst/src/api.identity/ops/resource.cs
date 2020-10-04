//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Defines a type resource identity
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline), Op]
        public static TypeIdentity resource(string basename, ITypeWidth w, NumericKind kind)
            => new TypeIdentity($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// Defines a type resource identity
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline), Op]
        public static TypeIdentity resource(string basename, ITypeWidth w1, ITypeWidth w2, NumericKind kind)
            => new TypeIdentity($"{basename}{w1}x{w2}x{kind.Format()}");

        /// <summary>
        /// Defines a type resource identity
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => new TypeIdentity($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// Defines a type resource identity
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline), Op]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => new TypeIdentity($"{basename}{w1}x{w2}x{kind.Format()}");
    }
}
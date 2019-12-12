//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    public readonly ref struct Perm16Spec
    {
        internal readonly Vector128<byte> data;

        static N128 w => n128;        

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        public static Perm16Spec identity()
            => new Perm16Spec(vbuild.increments<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        public static Perm16Spec reverse()
            => new Perm16Spec(vbuild.decrements<byte>(w));

        Perm16Spec(Vector128<byte> data)
            => this.data = data;

    }

    /// <summary>
    /// Defines a 32-symbol permutation
    /// </summary>
    public readonly ref struct Perm32Spec
    {            
        internal readonly Vector256<byte> data;


        static N256 w => n256;        

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        public static Perm32Spec identity()
            => new Perm32Spec(vbuild.increments<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        public static Perm32Spec reverse()
            => new Perm32Spec(vbuild.decrements<byte>(w));

        Perm32Spec(Vector256<byte> data)
            => this.data = data;
    }

}
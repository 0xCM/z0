//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static CpuVectorKinds;

    public static partial class Classified
    {
        public static V16x8u v16x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V16x8i v16x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V8x16u v8x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V8x16i v8x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V4x32u v4x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V4x32i v4x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V2x64u v2x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V2x64i v2x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V4x32f v4x32f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V2x64f v2x64f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V32x8u v32x8u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V32x8i v32x8i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V16x16u v16x16u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V16x16i v16x16i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V8x32u v8x32u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V8x32i v8x32i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V4x64u v4x64u
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V4x64i v4x64i
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V8x32f v8x32f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static V4x64f v4x64f
        {
            [MethodImpl(Inline)]
            get => default;
        }

        /// <summary>
        /// Determines the byte-size of a metadata-identified type if primal; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to check</param>
        [MethodImpl(Inline)]
        public static int size(Type t)
        {
            var pk = primalkind(t);
            if(pk != PrimalKind.None)
                return size(pk);
            else
                return size(vectorkind(t));
        }
            
            
        /// <summary>
        /// Determines the bit-size of a metadata-identified type if primal; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to check</param>
        [MethodImpl(Inline)]
        public static int width(Type t)
            => size(t) * 8;

        [MethodImpl(Inline)]
        static int width(uint k)
            => (ushort)k;

        [MethodImpl(Inline)]
        static bit signed(uint k)
            => (k & ((uint)PrimalKind.Signed)) != 0;

        [MethodImpl(Inline)]
        static bit floating(uint k)
            => (k & ((uint)PrimalKind.Fractional)) != 0;

        [MethodImpl(Inline)]
        static bit signedint(uint k)
            => signed(k) && !floating(k);

        [MethodImpl(Inline)]
        static bit unsignedint(uint k)
            => !signed(k) && !floating(k);

        [MethodImpl(Inline)]
        static bit integral(uint k)
            => !floating(k);

        [MethodImpl(Inline)]   
        static char sign(uint k)
            => floating(k) ? AsciLower.f 
            : signedint(k) ? AsciLower.i
            : unsignedint(k) ? AsciLower.u
            : AsciDigits.A0;
    }
}
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
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static partial class Classifiers{}

    public static partial class Classified
    {
        public static IEnumerable<PrimalKind> UnsignedKinds
            => items(PrimalKind.U8, PrimalKind.U16, PrimalKind.U32, PrimalKind.U64);

        public static IEnumerable<PrimalKind> SignedKinds
            => items(PrimalKind.I8, PrimalKind.I16, PrimalKind.I32, PrimalKind.I64);

        public static IEnumerable<PrimalKind> FloatingKinds
            => items(PrimalKind.F32, PrimalKind.F64);

        public static IEnumerable<PrimalKind> IntegralKinds
            => UnsignedKinds.Union(SignedKinds);

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static string keyword(PrimalKind k)
            => k switch {
                PrimalKind.U8 => "byte",
                PrimalKind.I8 => "sbyte",
                PrimalKind.U16 => "ushort",
                PrimalKind.I16 => "short",
                PrimalKind.U32 => "uint",
                PrimalKind.I32 => "int",
                PrimalKind.I64 => "long",
                PrimalKind.U64 => "ulong",
                PrimalKind.F32 => "float",
                PrimalKind.F64 => "double",
                _ => throw unsupported(k)
            };

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static PrimalKind kind(PrimalId k)
            => k switch {
                PrimalId.U8 => PrimalKind.U8,
                PrimalId.I8 => PrimalKind.I8,
                PrimalId.U16 => PrimalKind.U16,
                PrimalId.I16 => PrimalKind.I16,
                PrimalId.U32 => PrimalKind.U32,
                PrimalId.I32 => PrimalKind.I32,
                PrimalId.I64 => PrimalKind.I64,
                PrimalId.U64 => PrimalKind.U64,
                PrimalId.F32 => PrimalKind.F32,
                PrimalId.F64 => PrimalKind.F64,
                _ => throw unsupported(k)
            };

        /// <summary>
        /// Determines the number of bits covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int width(PrimalKind k)
            => (ushort)k;

        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(PrimalKind kind)
            => width(kind)/8;

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit floating(PrimalKind k)
            => (k & PrimalKind.Fractional) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit signed(PrimalKind k)
            => (k & PrimalKind.Signed) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit unsigned(PrimalKind k)
            => (k & PrimalKind.Unsigned) != 0;

        /// <summary>
        /// Determines whether a type is a primal integer
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit integral(PrimalKind k)
            => signed(k) || unsigned(k);

        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="k">The primal classifier</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static char indicator(PrimalKind k)
        {
            if(unsigned(k))
                return AsciLower.u;
            else if(signed(k))
                return AsciLower.i;
            else if(floating(k))
                return AsciLower.f;
            else
                return AsciLower.x;
        }

        /// <summary>
        /// Determines the kind identifier
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]   
        public static PrimalId id(PrimalKind k)
            => (PrimalId)((((uint)k << 8) >> 24) << 16);

        /// <summary>
        /// Produces an identifier {bitsize(k)}{u | i | f} for a primal kind k
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]   
        public static string primalsig(PrimalKind k)
            => $"{width(k)}{indicator(k)}";        

        /// <summary>
        /// Produces a canonical designator of the form {bitsize[T]}{u | i | f} for a primal type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string primalsig<T>(T t = default)
            => primalsig(typeof(T).Kind());

        /// <summary>
        /// Determines the number of bits covered by a k-kinded vector
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int width(VectorKind k)
            => (ushort)k;

        /// <summary>
        /// Determines the component width of a k-kinded vector
        /// </summary>
        /// <param name="k">The vector kind</param>
        [MethodImpl(Inline)]
        public static int segwidth(VectorKind k)
            => (byte)((uint)k >> 16);

        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(VectorKind kind)
            => width(kind)/8;

        /// <summary>
        /// Determines whether a classfied vector is defined over primal unsigned integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit unsigned(VectorKind k)
            => (k & VectorKind.Unsigned) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over primal signed integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit signed(VectorKind k)
            => (k & VectorKind.Signed) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over floating-point components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit floating(VectorKind k)
            => (k & VectorKind.Fractional) != 0;

        /// <summary>
        /// Determines whether a classfied vector is defined over primal integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit integral(VectorKind k)
            => signed(k) || unsigned(k);

        /// <summary>
        /// Determines whether the unsigned facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit unsigned(BlockKind k)
            => (k & BlockKind.Unsigned) != 0;

        /// <summary>
        /// Determines whether the signed facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit signed(BlockKind k)
            => (k & BlockKind.Signed) != 0;

        /// <summary>
        /// Determines whether the floating facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit floating(BlockKind k)
            => (k & BlockKind.Fractional) != 0;

        /// <summary>
        /// Determines whether the signed or unsigned facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit integral(BlockKind k)
            => signed(k) || unsigned(k);

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool segmented(Type t)
            => BlockedType.test(t) || VectorType.test(t);

        public static int width(Type t)
        {
            if(PrimalType.test(t))
                return (int)PrimalType.width(t);
            else if(VectorType.test(t))
                return (int)VectorType.width(t);
            else if(BlockedType.test(t))
                return (int)BlockedType.width(t);
            else
                return 0;
        }

        [MethodImpl(Inline)]
        public static int size(Type t)
            => width(t)/8;

        /// <summary>
        /// If type is intrinsic or blocked, returns the primal type over which the segmentation is defined; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<Type> segtype(Type t)
            => segmented(t) ? t.GenericTypeArguments[0] : default;        

        /// <summary>
        /// Classifies the source type
        /// </summary>
        /// <param name="t">The type to classify</param>
        public static ITypeKind kind(Type t)            
        {
            if(PrimalType.test(t))
                return new TypeKind<PrimalKind>(TypeKind.Primal, PrimalType.kind(t));
            else if(VectorType.test(t))
                return new TypeKind<VectorKind>(TypeKind.Vector, VectorType.kind(t));
            else if(BlockedType.test(t))
                return new TypeKind<BlockKind>(TypeKind.Block, BlockedType.kind(t));
            else 
                return TypeKind<TypeKind>.None;
        }

    }
}
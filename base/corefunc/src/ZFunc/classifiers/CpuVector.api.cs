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
    using System.Reflection;
    using System.Linq;

    using static zfunc;

    partial class Classified
    {
        [MethodImpl(Inline)]
        public static CpuVectorKind vectorkind<T>(T t = default)
            where T : struct
            =>  typeof(T).IsGenericType ?
                (
                     typeof(T).GetGenericTypeDefinition() == typeof(Vector128<>)  ? vkind128_u(t) 
                   : typeof(T).GetGenericTypeDefinition() == typeof(Vector256<>)  ? vkind256_u(t)
                   : CpuVectorKind.None
                )
              :  CpuVectorKind.None;


        [MethodImpl(Inline)]
        public static int vectorwidth(Type t)
        {
            if(t.IsVector())
            {
                var def = t.GetGenericTypeDefinition();

                if(def == typeof(Vector64<>))
                    return 64;
                else if(def == typeof(Vector128<>))
                    return 128;
                else if (def == typeof(Vector256<>))
                    return 256;
                else if (def == typeof(Vector512<>))
                    return 512;
                else if (def == typeof(Vector1024<>))
                    return 1024;
                else
                    return 0;
            }
            else 
                return 0;
        }


        [MethodImpl(Inline)]
        public static CpuVectorKind vectorkind(Type t)
        {
            if(t == typeof(Vector128<byte>))
                return CpuVectorKind.v16x8u;
            else if(t == typeof(Vector128<ushort>))
                return CpuVectorKind.v8x16u;
            else if(t == typeof(Vector128<uint>))
                return CpuVectorKind.v4x32u;
            else if(t == typeof(Vector128<ulong>))
                return CpuVectorKind.v2x64u;

            else if(t == typeof(Vector128<sbyte>))
                return CpuVectorKind.v16x8i;
            else if(t == typeof(Vector128<short>))
                return CpuVectorKind.v8x16i;
            else if(t == typeof(Vector128<int>))
                return CpuVectorKind.v4x32i;
            else if(t == typeof(Vector128<long>))            
                return CpuVectorKind.v2x64i;
                
            else if(t == typeof(Vector128<float>))
                return CpuVectorKind.v4x32f;
            else if(t == typeof(Vector128<double>))
                return CpuVectorKind.v2x64f;

            else if(t == typeof(Vector256<byte>))
                return CpuVectorKind.v32x8u;
            else if(t == typeof(Vector256<ushort>))
                return CpuVectorKind.v16x16u;
            else if(t == typeof(Vector256<uint>))
                return CpuVectorKind.v8x32u;
            else if(t == typeof(Vector256<ulong>))
                return CpuVectorKind.v4x64u;

            else if(t == typeof(Vector256<sbyte>))
                return CpuVectorKind.v32x8i;
            else if(t == typeof(Vector256<short>))
                return CpuVectorKind.v16x16i;
            else if(t == typeof(Vector256<int>))
                return CpuVectorKind.v8x32i;
            else if(t == typeof(Vector256<long>))
                return CpuVectorKind.v4x64i;

            else if(t == typeof(Vector256<float>))
                return CpuVectorKind.v8x32f;
            else if(t == typeof(Vector256<double>))
                return CpuVectorKind.v4x64f;
            else    
                return CpuVectorKind.None;
        }

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool vector(Type t, int? width)        
        {
            if(t.IsGenericType && width != null)
            {
                var def = t.GetGenericTypeDefinition();
                if(def == typeof(Vector64<>) && width == 64)
                    return true;
                else if(def == typeof(Vector128<>) && width == 128)
                    return true;
                else if (def == typeof(Vector256<>) && width == 256)
                    return true;
                else if (def == typeof(Vector512<>) && width == 512)
                    return true;
                else if (def == typeof(Vector1024<>) && width == 1024)
                    return true;
                else
                    return false;
            }
            else
                return t.IsVector();
        }

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool vector(Type t)
        {
            if(t.IsGenericType)
            {
                var def = t.GetGenericTypeDefinition();
                if(
                    def == typeof(Vector64<>)
                 || def == typeof(Vector128<>) 
                 || def == typeof(Vector256<>) 
                 || def == typeof(Vector1024<>) 
                 || def == typeof(Vector512<>)
                 )
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool unaryfunc(MethodInfo m)
            => m.IsFunction() && m.HasArity(1);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool binaryfunc(MethodInfo m)
            => m.IsFunction() && m.HasArity(2);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool ternaryfunc(MethodInfo m)
            => m.IsFunction() && m.HasArity(3);

        /// <summary>
        /// Determines whether a method is homogenous with respect to input/output values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static bool homogenous(MethodInfo m)
        {
            var inputs = m.ParameterTypes().ToSet();
            if(inputs.Count == 1)
                return inputs.Single() == m.ReturnType;
            else if(inputs.Count == 0)
                return m.ReturnType == typeof(void);
            else
                return false;
        }

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool unaryop(MethodInfo m)
            => homogenous(m) && unaryfunc(m);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool binaryop(MethodInfo m)
            => homogenous(m) && binaryfunc(m);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool ternaryop(MethodInfo m)
            => homogenous(m) && ternaryfunc(m);

        /// <summary>
        /// Determines whether a method defines a vectorized operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool isvectorop(MethodInfo m)        
            => isoperator(m) && vectorized(m,true);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool vectorized(MethodInfo m, bool total = false)        
            => total ? (vector(m.ReturnType) && m.ParameterTypes().All(vector)) 
                     : (vector(m.ReturnType) || m.ParameterTypes().Any(vector));

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool vectorized(MethodInfo m, int? width, bool total)        
            => total ? (vector(m.ReturnType,width) && m.ParameterTypes().All(t => vector(t,width))) 
                     : (vector(m.ReturnType,width) || m.ParameterTypes().Any(t => vector(t,width)));

        /// <summary>
        /// Determines the bit-width of each intrinsic or primal method parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int>[] inputwidths(MethodInfo m)
            => m.GetParameters().Select(p => paired(p, bitwidth(p.ParameterType))).ToArray();

        /// <summary>
        /// Determines the bit-width of an intrinsic or primal return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int> outputwidth(MethodInfo m)
            => paired(m.ReturnParameter, m.ReturnType.BitWidth());

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool segmented(Type t)
            => t.IsBlocked() || vector(t);

        /// <summary>
        /// If type is intrinsic or blocked, returns the primal type over which the segmentation is defined; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<Type> segtype(Type t)
            => segmented(t) ? t.GenericTypeArguments[0] : default;        

        /// <summary>
        /// Determines the number of bits covered by a k-kinded vector
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int width(CpuVectorKind k)
            => width((uint)k);

        /// <summary>
        /// Determines the component width of a k-kinded vector
        /// </summary>
        /// <param name="k">The vector kind</param>
        [MethodImpl(Inline)]
        public static int segwidth(CpuVectorKind k)
            => (byte)((uint)k >> 16);

        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(CpuVectorKind kind)
            => width(kind)/8;

        /// <summary>
        /// Produces a character {i | u | f} indicating whether a classified vector is defined over signed, unsigned or floating-point components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]   
        public static char sign(CpuVectorKind k)
            => sign((uint)k);

        /// <summary>
        /// Determines whether a classfied vector is defined over primal integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit integral(CpuVectorKind k)
            => integral((uint)k);

        /// <summary>
        /// Determines whether a classfied vector is defined over primal unsigned integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit unsignedint(CpuVectorKind k)
            => unsignedint((uint)k);

        /// <summary>
        /// Determines whether a classfied vector is defined over primal signed integer components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit signedint(CpuVectorKind k)
            => signedint((uint)k);

        /// <summary>
        /// Determines whether a classfied vector is defined over floating-point components
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit floating(CpuVectorKind k)
            => floating((uint)k);

        [MethodImpl(Inline)]
        static CpuVectorKind vkind128_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<byte>))
                return CpuVectorKind.v16x8u;
            else if(typeof(T) == typeof(Vector128<ushort>))
                return CpuVectorKind.v8x16u;
            else if(typeof(T) == typeof(Vector128<uint>))
                return CpuVectorKind.v4x32u;
            else if(typeof(T) == typeof(Vector128<ulong>))
                return CpuVectorKind.v2x64u;
            else
                return vkind128_i(t);
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind128_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<sbyte>))
                return CpuVectorKind.v16x8i;
            else if(typeof(T) == typeof(Vector128<short>))
                return CpuVectorKind.v8x16i;
            else if(typeof(T) == typeof(Vector128<int>))
                return CpuVectorKind.v4x32i;
            else if(typeof(T) == typeof(Vector128<long>))
                return CpuVectorKind.v2x64i;
            else
                return vkind128_f(t);
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind128_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector128<float>))
                return CpuVectorKind.v4x32f;
            else if(typeof(T) == typeof(Vector128<double>))
                return CpuVectorKind.v2x64f;
            else
                return CpuVectorKind.None;            
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind256_u<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<byte>))
                return CpuVectorKind.v32x8u;
            else if(typeof(T) == typeof(Vector256<ushort>))
                return CpuVectorKind.v16x16u;
            else if(typeof(T) == typeof(Vector256<uint>))
                return CpuVectorKind.v8x32u;
            else if(typeof(T) == typeof(Vector256<ulong>))
                return CpuVectorKind.v4x64u;
            else
                return vkind256_i(t);
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind256_i<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<sbyte>))
                return CpuVectorKind.v32x8i;
            else if(typeof(T) == typeof(Vector256<short>))
                return CpuVectorKind.v16x16i;
            else if(typeof(T) == typeof(Vector256<int>))
                return CpuVectorKind.v8x32i;
            else if(typeof(T) == typeof(Vector256<long>))
                return CpuVectorKind.v4x64i;
            else
                return vkind256_f(t);
        }

        [MethodImpl(Inline)]
        static CpuVectorKind vkind256_f<T>(T t = default)
            where T : struct
        {
            if(typeof(T) == typeof(Vector256<float>))
                return CpuVectorKind.v8x32f;
            else if(typeof(T) == typeof(Vector256<double>))
                return CpuVectorKind.v4x64f;
            else
                return CpuVectorKind.None;            
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    using static zfunc;
    using static As;
    
    
    public static partial class Vec128
    {

        /// <summary>
        /// Returns a readonly reference to the zero vector
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Zero<T>() 
            where T : unmanaged
                => default;

        /// <summary>
        /// Creates a new vector, initialing each component to a common value
        /// </summary>
        /// <param name="src">The fill value</param>
         [MethodImpl(Inline)]
         public static Vec128<T> Fill<T>(T value)
            where T : unmanaged
                => ginx.vbroadcast(n128, value);


        [MethodImpl(Inline)]
        public static Vec128<T> Load<T>(ref T src)
            where T : unmanaged  
                => ginx.vloadu(in src, out Vector128<T> _);


        [MethodImpl(Inline)]
        public static ref Vec128<T> Load<T>(ReadOnlySpan128<T> src, int block, out Vec128<T> dst)
            where T : unmanaged
        {            
            ginx.vloadu(in src.Block(block), out Vector128<T> _dst);
            dst = _dst;
            return ref dst;                
        }

        [MethodImpl(Inline)]
        public static ref Vec128<T> Load<T>(Span128<T> src, int block, out Vec128<T> dst)
            where T : unmanaged
        {            
            ginx.vloadu(in src.Block(block), out Vector128<T> _dst);
            dst = _dst;
            return ref dst;                
        }        

        /// <summary>
        /// Loads the source value into the first component of a new vector
        /// </summary>
        /// <param name="src">The source scalar</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> LoadScalar<T>(in T src)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return LoadScalaru(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return LoadScalari(in src);
            else 
                return LoadScalarf(in src);
        }        


        [MethodImpl(Inline)]
        static Vec128<T> LoadScalari<T>(in T src)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(sbyte))
                return generic<T>(LoadScalar(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(LoadScalar(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(LoadScalar(int32(src)));
            else 
                return generic<T>(LoadScalar(int64(src)));
        }        

        [MethodImpl(Inline)]
        static Vec128<T> LoadScalaru<T>(in T src)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(byte))
                return generic<T>(LoadScalar(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(LoadScalar(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(LoadScalar(uint32(src)));
            else 
                return generic<T>(LoadScalar(uint64(src)));
        }        

        [MethodImpl(Inline)]
        static Vec128<T> LoadScalarf<T>(in T src)
            where T : unmanaged
        {            
            if(typeof(T) == typeof(float))
                return generic<T>(LoadScalar(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(LoadScalar(float64(src)));
            else 
                throw unsupported<T>();
        }        


        [MethodImpl(Inline)]
        public static Vec128<T> Load<T>(Span128<T> src, int block = 0)
            where T : unmanaged  
                => Load(src, block, out Vec128<T> _);

        [MethodImpl(Inline)]
        public static Vec128<T> Load<T>(ReadOnlySpan128<T> src, int block = 0)
            where T : unmanaged  
                => Load(src, block, out Vec128<T> _);

        [MethodImpl(Inline)]
        public static ref Vec128<T> Load<T>(ReadOnlySpan<T> src, int offset, out Vec128<T> dst)
            where T : unmanaged  
        {
            dst = ginx.vloadu(in head(src), out Vector128<T> _);
            return ref dst;
        } 

        [MethodImpl(Inline)]
        public static Vec128<T> Load<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : unmanaged  
                =>  Load<T>(src, offset, out Vec128<T> _);    


        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        /// <param name="x4">The component at index 4</param>
        /// <param name="x5">The component at index 5</param>
        /// <param name="x6">The component at index 6</param>
        /// <param name="x7">The component at index 7</param>
        [MethodImpl(Inline)]
        public static Vec128<short> FromParts(short x0, short x1, short x2, short x3, short x4, short x5, short x6, short x7) 
                => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        [MethodImpl(Inline)]
        public static Vec128<int> FromParts(int x0, int x1, int x2, int x3)
            => Vector128.Create(x0,x1,x2,x3);
                            
        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> FromParts(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1,x2,x3);        

        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> FromParts(ulong x0, ulong x1)
            => Vector128.Create(x0,x1);
        

        [MethodImpl(Inline)]
        static Vec128<byte> LoadScalar(byte src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<sbyte> LoadScalar(sbyte src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<short> LoadScalar(short src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<ushort> LoadScalar(ushort src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<int> LoadScalar(int src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<uint> LoadScalar(uint src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<long> LoadScalar(long src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<ulong> LoadScalar(ulong src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<float> LoadScalar(float src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<double> LoadScalar(double src)
            => Vector128.CreateScalarUnsafe(src);


    }
}
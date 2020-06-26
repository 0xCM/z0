//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static VectorKonst;
    using static Root;
    using static Typed;
    using static As;
    using static V0;
     
    partial class VData
    {
        /// <summary>
        /// Creates a 128-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vunits<T>(N128 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return generic<T>(V0.vload(w, head(Units128x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return generic<T>(V0.vload(w, head(Units128x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return generic<T>(V0.vload(w,head(Units128x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return generic<T>(V0.vload(w,head(Units128x64u)));
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vunits<T>(N256 w, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                return generic<T>(V0.vload(w, head(Units256x8u)));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                return generic<T>(V0.vload(w, head(Units256x16u)));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                return generic<T>(V0.vload(w, head(Units256x32u)));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                return generic<T>(V0.vload(w, head(Units256x64u)));
            else
                throw Unsupported.define<T>();
        }        


        [MethodImpl(Inline)]
        public static Vector128<T> vunits<T>(Vec128Kind<T> kind)
            where T : unmanaged
                => vunits<T>(w128);

        [MethodImpl(Inline)]
        public static Vector256<T> vunits<T>(Vec256Kind<T> kind)
            where T : unmanaged
                => vunits<T>(w256);

        // public static ReadOnlySpan<byte> Units128x8u
        //     => new byte[16]{
        //         1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
        //         };

        // public static ReadOnlySpan<byte> Units128x16u
        //     => new byte[16]{
        //         1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0
        //         };

        // public static ReadOnlySpan<byte> Units128x32u
        //     => new byte[16]{
        //         1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0
        //         };

        // public static ReadOnlySpan<byte> Units128x64u
        //     => new byte[16]{
        //         1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0
        //         };

        // public static ReadOnlySpan<byte> Units256x8u
        //     => new byte[32]{
        //         1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
        //         1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
        //         };

        // public static ReadOnlySpan<byte> Units256x16u
        //     => new byte[32]{
        //         1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,
        //         1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0
        //         };

        // public static ReadOnlySpan<byte> Units256x32u
        //     => new byte[32]{
        //         1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,
        //         1,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0
        //         };

        // public static ReadOnlySpan<byte> Units256x64u
        //     => new byte[32]{
        //         1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,
        //         1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0
        //         }; 

        // [ResourceProvider]
        // static void RegisterUnits()
        // {
        //     const string basename = "Units";
        //     var w = default(ITypeWidth);
        //     var index = UnitsIndex;

        //     w = w128;
        //     Register(index++, Identify.resource(basename, w, NumericKind.U8), Units128x8u);
        //     Register(index++, Identify.resource(basename, w, NumericKind.U16), Units128x16u);
        //     Register(index++, Identify.resource(basename, w, NumericKind.U32), Units128x32u);
        //     Register(index++, Identify.resource(basename, w, NumericKind.U64), Units128x64u);
            
        //     w = w256;
        //     Register(index++, Identify.resource(basename, w, NumericKind.U8), Units256x8u);
        //     Register(index++, Identify.resource(basename, w, NumericKind.U16), Units256x16u);
        //     Register(index++, Identify.resource(basename, w, NumericKind.U32), Units256x32u);
        //     Register(index++, Identify.resource(basename, w, NumericKind.U64), Units256x64u);
        // }
    }
}
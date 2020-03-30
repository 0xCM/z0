//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Components;

    [ApiHost]
    public static class AsIn
    {
        /// <summary>
        /// Presents a readonly reference as reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        static ref T edit<T>(in T src)
            => ref Unsafe.AsRef(in src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref sbyte int8<T>(in T src)
            => ref Unsafe.As<T,sbyte>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte uint8<T>(in T src)
            => ref Unsafe.As<T,byte>(ref edit(in src));            

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref short int16<T>(in T src)
            => ref Unsafe.As<T,short>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ushort uint16<T>(in T src)
            => ref Unsafe.As<T,ushort>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref int int32<T>(in T src)
            => ref Unsafe.As<T,int>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref uint uint32<T>(in T src)
            => ref Unsafe.As<T,uint>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref long int64<T>(in T src)
            => ref Unsafe.As<T,long>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ulong uint64<T>(in T src)
            => ref Unsafe.As<T,ulong>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref float float32<T>(in T src)
            => ref Unsafe.As<T,float>(ref edit(in src));
        
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref double float64<T>(in T src)
            => ref Unsafe.As<T,double>(ref edit(in src));

        [MethodImpl(Inline)]
        public static ref char char16<T>(in T src)
            => ref Unsafe.As<T,char>(ref edit(in src));
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct NumericFormatters
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static INumericFormatter<T> create<T>(Func<T,string> f, Func<T,NumericBaseKind,string> g)
            where T : unmanaged
                => new NumericFormatterFx<T>(f,g);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static INumericFormatter<T> create<T>(Func<T,NumericBaseKind,string> g)
            where T : unmanaged
                => new NumericFormatterFx<T>(g);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NumericFormatter<T> create<T>()
            where T : unmanaged
                => numeric_u<T>();

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<string> create<T>(ReadOnlySpan<T> src, Base16 @base, Span<string> dst)
            where T : unmanaged
        {
            var formatter = create<T>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst, i) = formatter.Format(skip(src,i), NumericBaseKind.Base16);
            return dst;
        }

        [MethodImpl(Inline)]
        static NumericFormatter<T> numeric_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return create<U8Formatter,byte>().As<T>();
            else if(typeof(T) == typeof(ushort))
                return create<U16Formatter, ushort>().As<T>();
            else if(typeof(T) == typeof(uint))
                return create<U32Formatter, uint>().As<T>();
            else if(typeof(T) == typeof(ulong))
                return create<U64Formatter, ulong>().As<T>();
            else
                return numeric_i<T>();
        }

        [MethodImpl(Inline)]
        static NumericFormatter<T> numeric_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return create<I8Formatter,sbyte>().As<T>();
            else if(typeof(T) == typeof(short))
                return create<I16Formatter, short>().As<T>();
            else if(typeof(T) == typeof(int))
                return create<I32Formatter, int>().As<T>();
            else if(typeof(T) == typeof(long))
                return create<I64Formatter,long>().As<T>();
            else
                return numeric_f<T>();
        }

        [MethodImpl(Inline)]
        static NumericFormatter<T> numeric_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return create<F32Formatter, float>().As<T>();
            else if(typeof(T) == typeof(double))
                return create<F64Formatter, double>().As<T>();
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static F numeric_u<F,T>()
            where F : struct, INumericFormatter<F,T>
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<U8Formatter,F>(default(U8Formatter));
            else if(typeof(T) == typeof(ushort))
                return generic<U16Formatter,F>(default(U16Formatter));
            else if(typeof(T) == typeof(uint))
                return generic<U32Formatter,F>(default(U32Formatter));
            else if(typeof(T) == typeof(ulong))
                return generic<U64Formatter,F>(default(U64Formatter));
            else
                return numeric_i<F,T>();
        }

        [MethodImpl(Inline)]
        static F numeric_i<F,T>()
            where F : struct, INumericFormatter<F,T>
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<I8Formatter,F>(default(I8Formatter));
            else if(typeof(T) == typeof(short))
                return generic<I16Formatter,F>(default(I16Formatter));
            else if(typeof(T) == typeof(int))
                return generic<I32Formatter,F>(default(I32Formatter));
            else if(typeof(T) == typeof(long))
                return generic<I64Formatter,F>(default(I64Formatter));
            else
                return numeric_f<F,T>();
        }

        [MethodImpl(Inline)]
        static F numeric_f<F,T>()
            where F : struct, INumericFormatter<F,T>
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<F32Formatter,F>(default(F32Formatter));
            else if(typeof(T) == typeof(double))
                return generic<F64Formatter,F>(default(F64Formatter));
            else
                throw no<F>();
        }

        readonly struct U8Formatter : INumericFormatter<U8Formatter, byte>
        {
            [MethodImpl(Inline)]
            public string Format(byte src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => src.FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<U8Formatter, byte> Concretize()
                => generalize<U8Formatter,byte>(this);
        }

        readonly struct I8Formatter : INumericFormatter<I8Formatter, sbyte>
        {
            [MethodImpl(Inline)]
            public string Format(sbyte src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => src.FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<I8Formatter, sbyte> Concretize()
                => generalize<I8Formatter,sbyte>(this);
        }

        readonly struct U16Formatter : INumericFormatter<U16Formatter, ushort>
        {

            [MethodImpl(Inline)]
            public string Format(ushort src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => src.FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<U16Formatter, ushort> Concretize()
                => generalize<U16Formatter,ushort>(this);
        }

        readonly struct I16Formatter : INumericFormatter<I16Formatter, short>
        {
            [MethodImpl(Inline)]
            public string Format(short src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => src.FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<I16Formatter, short> Concretize()
                => generalize<I16Formatter,short>(this);
        }

        readonly struct I32Formatter : INumericFormatter<I32Formatter, int>
        {
            [MethodImpl(Inline)]
            public string Format(int src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => src.FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<I32Formatter, int> Concretize()
                => generalize<I32Formatter,int>(this);
        }

        readonly struct U32Formatter : INumericFormatter<U32Formatter, uint>
        {
            [MethodImpl(Inline)]
            public string Format(uint src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => src.FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<U32Formatter, uint> Concretize()
                => generalize<U32Formatter,uint>(this);
        }

        readonly struct U64Formatter : INumericFormatter<U64Formatter, ulong>
        {
            [MethodImpl(Inline)]
            public string Format(ulong src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => src.FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<U64Formatter, ulong> Concretize()
                => generalize<U64Formatter,ulong>(this);
        }

        readonly struct I64Formatter : INumericFormatter<I64Formatter, long>
        {
            [MethodImpl(Inline)]
            public string Format(long src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => src.FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<I64Formatter, long> Concretize()
                => generalize<I64Formatter,long>(this);
        }

        readonly struct F32Formatter : INumericFormatter<F32Formatter, float>
        {
            [MethodImpl(Inline)]
            public string Format(float src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => Numeric.force<uint>(src).FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(false),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<F32Formatter, float> Concretize()
                => generalize<F32Formatter,float>(this);
        }

        readonly struct F64Formatter : INumericFormatter<F64Formatter, double>
        {
            [MethodImpl(Inline)]
            public string Format(double src, NumericBaseKind @base)
                => @base switch{
                    NumericBaseKind.Base2 => Numeric.force<ulong>(src).FormatBits(),
                    NumericBaseKind.Base16 => src.FormatHex(false),
                    _ => src.ToString()
                };

            [MethodImpl(Inline)]
            public NumericFormatter<F64Formatter, double> Concretize()
                 => generalize<F64Formatter,double>(this);
       }

        [MethodImpl(Inline)]
        static NumericFormatter<F,T> generalize<F,T>(F formatter)
            where T : unmanaged
             where F : struct, INumericFormatter<F,T>
                => new NumericFormatter<F,T>(formatter);

        [MethodImpl(Inline)]
        static G generic<S,G>(in S specific)
            => Unsafe.As<S, G>(ref Unsafe.AsRef(in specific));

        [MethodImpl(Inline)]
        static NumericFormatter<F,T> create<F,T>()
            where F : struct, INumericFormatter<F,T>
            where T : unmanaged
                => new NumericFormatter<F,T>(default(F));
    }
}
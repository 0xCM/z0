//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Dataset
    {
        /// <summary>
        /// Defines a mask that, when applied, reveals the field position
        /// </summary>
        const ushort PosMask = 0xFFFF;

        [MethodImpl(Inline)]
        public static TFieldRender<F> render<F>()
            where F : unmanaged, Enum
                => FieldRender<F>.Service;

        [MethodImpl(Inline)]
        public static DatasetHeader<F> header<F>()
            where F : unmanaged, Enum
                => default;

        [MethodImpl(Inline)]
        public static IDatasetFormatter<F> formatter<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), delimiter);

        [MethodImpl(Inline)]
        public static IDatasetFormatter<F> formatter<F>(StringBuilder state, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(state,delimiter);

        /// <summary>
        /// Computes the field width from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int width<F>(F field)
            where F : unmanaged, Enum
                => text.width(field);

        /// <summary>
        /// Computes the field index from a field specifier
        /// </summary>
        /// <param name="field">The field specifier</param>
        /// <typeparam name="F">The field specifier type</typeparam>
        [MethodImpl(Inline)]
        public static int index<F>(F field)
            where F : unmanaged, Enum
                => (int)(Tabular.PosMask & Enums.e32u(field));

        [MethodImpl(Inline)]
        public static string[] labels<F>()
            where F : unmanaged, Enum
                => DataFields.labels<F>();    

        internal static string Render(ITextual src)
            => src?.Format() ?? string.Empty;

        internal static string render(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                return Null.Value.Format();
            else if(content is ITextual t)
                return Render(t);
            else
                return content.ToString();
        }    
    }

    public readonly struct Dataset<F>
        where F : unmanaged, Enum
    {

    }

    public readonly struct Dataset<F,C> : IIndex<Dataset<F,C>,C>
        where F : unmanaged, Enum
    {
        readonly C[] Data;

        public Dataset(C[] src)
        {
            Data = src;
        }
        public ref C this[int index] 
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length 
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public C[] Content
        {
            get => Data;
        }

        public ref C Head 
            => ref Data[0];

        public ref C Tail 
            => ref Data[Length - 1];

        public Dataset<F, C> Reverse()
        {
            Array.Reverse(Data);
            return this;
        }
    }
}
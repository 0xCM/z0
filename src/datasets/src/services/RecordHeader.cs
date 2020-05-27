//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;   
    using static Memories;

    public readonly struct RecordHeader
    {
        [MethodImpl(Inline)]
        public static RecordHeader<F> Create<F>()
            where F : unmanaged, Enum
                => default;
    }

    /// <summary>
    /// Defines enum-predicated header content
    /// </summary>
    public readonly struct RecordHeader<F>
        where F : unmanaged, Enum
    {
        public F[] Fields
        {
            [MethodImpl(Inline)]
            get => Enums.valarray<F>();
        }

        public string[] Labels
        {
            [MethodImpl(Inline)]
            get => Fields.Map(f => f.ToString());
        }

        public string Render(char delimiter)
        {
            var service = Records.Formatter<F>();
            var cols = Fields;
            var labels = Labels;
            for(var i=0; i<cols.Length; i++)
                service.DelimitField(cols[i], labels[i], delimiter);
            return service.Render();
        }

        /// <summary>
        /// Formates a header row using a caller-supplied label producer
        /// </summary>
        /// <param name="label">The label factory</param>
        /// <param name="delimiter">The delimiter</param>
        /// <typeparam name="F">The field type</typeparam>
        public string Render(Func<int,F,string> label, char delimiter)
        {
            var service = Records.Formatter<F>();
            var cols = Fields;
            var labels = Labels;
            for(var i=0; i<cols.Length; i++)
                service.DelimitField(cols[i], label(i, cols[i]), delimiter);
            return service.Render();
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   

    using static Dataset;

    /// <summary>
    /// Defines enum-predicated header content
    /// </summary>
    public readonly struct DatasetHeader<F>
        where F : unmanaged, Enum
    {
        public F[] Fields
        {
            [MethodImpl(Inline)]
            get => Enums.literals<F>();
        }

        public string[] Labels
        {
            [MethodImpl(Inline)]
            get => Fields.Map(f => f.ToString());
        }

        public string Render(char delimiter = FieldDelimiter)
        {
            var service = formatter<F>(delimiter);
            var cols = Fields;
            var labels = Labels;
            for(var i=0; i<cols.Length; i++)
                service.Delimit(cols[i], labels[i]);
            return service.Render();
        }

        /// <summary>
        /// Formates a header row using a caller-supplied label producer
        /// </summary>
        /// <param name="label">The label factory</param>
        /// <param name="delimiter">The delimiter</param>
        /// <typeparam name="F">The field type</typeparam>
        public string Render(Func<int,F,string> label, char delimiter = FieldDelimiter)
        {
            var service = formatter<F>(delimiter);
            var cols = Fields;
            var labels = Labels;
            for(var i=0; i<cols.Length; i++)
                service.Delimit(cols[i], label(i, cols[i]));
            return service.Render();
        }
    }
}
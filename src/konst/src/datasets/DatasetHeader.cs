//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines enum-predicated header content
    /// </summary>
    public readonly struct DatasetHeader<F>
        where F : unmanaged, Enum
    {
        public F[] Fields
        {
            [MethodImpl(Inline)]
            get => ClrEnums.literals<F>();
        }

        public string[] Labels
        {
            [MethodImpl(Inline)]
            get => Fields.Map(f => f.ToString());
        }

        public string Render(char delimiter = FieldDelimiter)
        {
            var service = Datasets.formatter<F>(delimiter);
            var cols = Fields;
            var labels = Labels;
            for(var i=0; i<cols.Length; i++)
            {
                if(i==0)
                    service.Append(cols[i], labels[i]);
                else
                    service.Delimit(cols[i], labels[i]);
            }
            return service.Render();
        }
    }
}
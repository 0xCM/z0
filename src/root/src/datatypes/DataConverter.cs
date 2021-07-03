//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines an adapter for an exising converter
    /// </summary>
    public readonly struct DataConverter : IDataConverter
    {
        readonly IDataConverter Adapted;

        [MethodImpl(Inline)]
        public DataConverter(IDataConverter adapted)
        {
            Adapted = adapted;
        }

        public PairedTypes ConversionTypes
            => Adapted.ConversionTypes;

        public Outcome Convert(object src, out object dst)
            => Adapted.Convert(src,out dst);
    }
}
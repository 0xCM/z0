//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using static Root;

    /// <summary>
    /// Defines an adapter for an exising configuration-parametric converter
    /// </summary>
    public readonly struct DataConverter<C> : IDataConverter<C>
    {
        readonly IDataConverter<C> Adapted;

        [MethodImpl(Inline)]
        public DataConverter(IDataConverter<C> adapted)
        {
            Adapted = adapted;
        }

        public PairedTypes ConversionTypes
            => Adapted.ConversionTypes;

        public Outcome Convert(object src, out object dst)
            => Adapted.Convert(src,out dst);

        public Outcome Convert(C config, object src, out object dst)
            => Adapted.Convert(config, src, out dst);
    }
}
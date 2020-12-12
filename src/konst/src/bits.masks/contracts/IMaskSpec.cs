//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMaskSpec : ITextual
    {
        BitMaskKind M {get;}

        NumericKind K {get;}
    }

    public interface IMaskSpec<T> : IMaskSpec
        where T : unmanaged
    {
        NumericKind IMaskSpec.K
            => NumericKinds.kind<T>();

        T t => default;
    }

    public interface IMaskSpec<F,D,T> : IMaskSpec<T>, IBitDensity<D>, IBitFrequency<F>
        where F : unmanaged, ITypeNat
        where D : unmanaged, ITypeNat
        where T : unmanaged
    {
        MaskSpec Untyped
            => MaskSpec.define<F,D,T>(M);

        uint IBitFrequency.F
            => z.nat32u<F>();

        uint IBitDensity.D
            => z.nat32u<D>();

        string ITextual.Format()
            => $"lsb(f:{z.nat32u<F>()}, d:{z.nat32u<D>()}, t:{typeof(T).NumericKind().Format()})";
    }
}
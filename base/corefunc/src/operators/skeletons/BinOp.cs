//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;
    
    using static zfunc;

    public abstract class BinOp<A> : IBinaryOp<A>
    {
        protected abstract string GetOpName();

        public virtual string Moniker => moniker<A>(GetOpName());

        public abstract A Invoke(A x, A y);

    }

    public abstract class VBinOp<W,V,T> : BinOp<V>,  IVBinOp<W,V,T>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        protected static W w => default;

        protected static T t => default;

        public override string Moniker => moniker<W,T>(GetOpName());

    }

    public abstract class VBinOpD<W,V,T> : VBinOp<W,V,T>, IVBinOpD<T>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        public abstract T InvokeScalar(T a, T b);
    }

    public abstract class VBinOp128<T> : VBinOp<N128, Vector128<T>, T>
        where T : unmanaged
    {

    }

    public abstract class VBinOp128D<T> : VBinOpD<N128, Vector128<T>, T>, IVBinOp128D<T>
        where T : unmanaged
    {

    }

    public abstract class VBinOp256<T> : VBinOp<N256, Vector256<T>, T>
        where T : unmanaged
    {

    }

    public abstract class VBinOp256D<T> : VBinOpD<N256, Vector256<T>, T>, IVBinOp256D<T>
        where T : unmanaged
    {

    }


}
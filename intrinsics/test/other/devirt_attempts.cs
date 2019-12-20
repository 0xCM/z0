//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;


    /// <summary>
    /// Represents an intrinsic unary operator
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="V">The vector</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    public abstract class VUnaryOp<W,V,T>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        public abstract V Invoke(V src);
    }

    /// <summary>
    /// Represents an intrinsic function that accepts a vector and an immediate and returns a vector
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="V">The vector</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="Im">The immediate type</typeparam>
    public abstract class VUnaryFunc<W,V,T,Im>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
        where Im : unmanaged
    {
        public abstract V Invoke(V src, Im a);
    }

    /// <summary>
    /// Represents an intrinsic function that accepts a vector and and two immediates and returns a vector
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="V">The vector</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="ImA">The first immediate type</typeparam>
    /// <typeparam name="ImB">The second immediate type</typeparam>
    public abstract class VUnaryFunc<W,V,T,ImA,ImB>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
        where ImA : unmanaged
        where ImB : unmanaged
    {
        public abstract V Invoke(V src, ImA a, ImB b);
    }

    public interface IVBinaryOp<V,T> : IBinaryOp<V>
        where V : struct
        where T : unmanaged
    {
        
        
    }

    public interface IVBinaryOp<N,V,T> : IVBinaryOp<V,T>
        where N : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }

    public interface IBinaryOp128<T> : IVBinaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
        
    }

    public interface IBinaryOp256<T> : IVBinaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {

    }

    public interface IBinaryOp512<T> : IVBinaryOp<N512,Vector512<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Represents an intrinsic binary operator
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="V">The vector</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    public abstract class VBinaryOp<N,V,T> : IVBinaryOp<V,T>
        where N : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        public abstract V Invoke(V x, V y);
    }

    public abstract class VBinaryOp128<T> : VBinaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
        
    }

    public abstract class VBinaryOp256<T> : VBinaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    public abstract class VBinaryOp512<T> : VBinaryOp<N512,Vector512<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Represents an intrinsic function that accepts two vectors and an immediate and returns a vector
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="V">The vector</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    /// <typeparam name="Im">The immediate type</typeparam>
    public abstract class VBinaryFunc<W,V,T,Im>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        public abstract V Invoke(V x, V y, Im a);
    }

    /// <summary>
    /// Represents an intrinsic ternary operator
    /// </summary>
    /// <typeparam name="W">The vector width</typeparam>
    /// <typeparam name="V">The vector</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    public abstract class VTernaryOp<W,V,T>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        public abstract V Invoke(V x, V y, V z);
    }
 
    public static partial class VOps
    {
        public readonly struct VPerm2x128
        {
            [MethodImpl(Inline)]
            public static Vector512<T> Invoke<T>(Vector512<T> src, Perm2x4 a, Perm2x4 b)                
                where T : unmanaged
                    => VPerm2x128x512<T>.Instance.Invoke(src,a,b);
        }

        public readonly struct And
        {
            [MethodImpl(Inline)]
            public static Vector256<T> Invoke<T>(Vector256<T> x, Vector256<T> y)
                where T : unmanaged
                => VAnd<T>.Ops.Invoke(x,y);
        
        }

        public readonly struct VAnd<T> : IBinaryOp256<T>, IBinaryOp128<T>
            where T : unmanaged
        {
            public static IBinaryOp256<T> Ops => default;

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y)
                => ginx.vand(x,y);

            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y)
                => ginx.vand(x,y);
        }


        sealed class VPerm2x128x512<T> : VUnaryFunc<N512, Vector512<T>, T, Perm2x4, Perm2x4>
            where T : unmanaged
        {
            public static VUnaryFunc<N512, Vector512<T>, T, Perm2x4, Perm2x4> Instance => new VPerm2x128x512<T>();
            
            [MethodImpl(Inline)]
            public override Vector512<T> Invoke(Vector512<T> src, Perm2x4 a, Perm2x4 b)
                => ginx.vperm2x128(src,a,b);
        }


    }
}
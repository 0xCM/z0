//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {


    }

    /// <summary>
    /// Characterizes a structural transformation function
    /// </summary>
    /// <typeparam name="A">The source domain type</typeparam>
    /// <typeparam name="B">The target domain type</typeparam>
    [Free, SFx]
    public interface IProjector<A,B> : IFunc<A,B>
    {

    }

    /// <summary>
    /// Characterizes an operator that materializes a primal value from a string
    /// </summary>
    /// <typeparam name="T">The primal value type</typeparam>
    [Free, SFx]
    public interface ISFParser<T> : IFunc<string,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized transformation parameterized by operand source/target bit widths and source/target component types
    /// </summary>
    /// <typeparam name="W1">The bit-width type of the source operand</typeparam>
    /// <typeparam name="W2">The bit-width type of the target operand</typeparam>
    /// <typeparam name="V1">The source operand type</typeparam>
    /// <typeparam name="V2">The target operand type</typeparam>
    /// <typeparam name="T1">The source component type</typeparam>
    /// <typeparam name="T2">The target component type</typeparam>
    [Free, SFx]
    public interface IMap<W1,W2,V1,V2,T1,T2> : IProjector<V1,V2>
        where W1 : unmanaged, ITypeWidth
        where W2 : unmanaged, ITypeWidth
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a 128-bit vectorized transformation parameterized by source/target component types
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [Free, SFx]
    public interface IMap128<S,T> : IMap<W128,W128,Vector128<S>,Vector128<T>,S,T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a 256-bit vectorized transformation parameterized by source/target component types
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [Free, SFx]
    public interface IMap256<S,T> : IMap<W256,W256,Vector256<S>,Vector256<T>,S,T>
        where S : unmanaged
        where T : unmanaged
    {

    }
}
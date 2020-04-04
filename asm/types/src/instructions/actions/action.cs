//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
    public interface action : op
    {

    }

   /// <summary>
    /// An action suupported in 32-bit mode
    /// </summary>    
    public interface action32 : action, op32
    {

    }

    /// <summary>
    /// An action suupported in 64-bit mode
    /// </summary>    
    public interface action64 : action, op64
    {

    }

    /// <summary>
    /// An action suupported in 32 and 64-bit modes
    /// </summary>    
    public interface action32x64 : action32, action64, op32x64
    {

    }

    public interface action<F> : action
        where F : struct, action<F>
    {

    }

    public interface action32<F> : action<F>, action32
        where F : struct, action32<F>
    {

    }

    public interface action64<F> : action<F>, action64
        where F : struct, action64<F>
    {

    }

    public interface action32x64<F> : action<F>, action32x64
        where F : struct, action32x64<F>
    {

    }
}
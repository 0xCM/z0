//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRotator<T>
    {
        /// <summary>
        /// Rotates bits leftwards, from LSB -> MSB
        /// </summary>
        /// <param name="count">The rotation magnitude</param>
        T Rotl(T src, uint count);

        /// <summary>
        /// Rotates bits rightwards, from MSB -> LSB
        /// </summary>
        /// <param name="count">The rotation magnitude</param>
        T Rotr(T src, uint rhs);
    }

    public interface IRotatable<F,T> : IReified<F>
        where F : IRotatable<F,T>, new()
    {
        /// <summary>
        /// Rotates bits leftwards, from LSB -> MSB
        /// </summary>
        /// <param name="count">The rotation magnitude</param>
        F Rotl(uint count);
        
        /// <summary>
        /// Rotates bits rightwards, from MSB -> LSB
        /// </summary>
        /// <param name="count">The rotation magnitude</param>
        F Rotr(uint count);
    }
}
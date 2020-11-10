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
}
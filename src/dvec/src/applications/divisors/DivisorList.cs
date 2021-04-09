//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Encapsulates a divisor along with its dividends
    /// </summary>
    public readonly struct DivisorList<T>
        where T : unmanaged
    {
        /// <summary>
        /// The dividend
        /// </summary>
        public T Dividend {get;}

        /// <summary>
        /// The values that divide the dividend
        /// </summary>
        public Index<T> Divisors {get;}

        public DivisorList(T dividend, Index<T> divisors)
        {
            Dividend = dividend;
            Divisors = divisors;
        }


        public bool IsPrime
            => Divisors.Count == 0;

        public override string ToString()
        {
            return IsPrime ? $"{Dividend}"
            : $"{Dividend}, " + string.Join(", ",Divisors);
        }
    }
}
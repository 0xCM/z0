//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    unsafe partial struct Utf8
    {
        /// <summary>
        /// Get number of bytes from offset to given terminator, null terminator, or end-of-block (whichever comes first).
        /// Returned length does not include the terminator, but numberOfBytesRead out parameter does.
        /// </summary>
        /// <param name="offset">Offset in to the block where the UTF8 bytes start.</param>
        /// <param name="terminator">A character in the ASCII range that marks the end of the string.
        /// If a value other than '\0' is passed we still stop at the null terminator if encountered first.</param>
        /// <param name="consumed">The number of bytes read, which includes the terminator if we did not hit the end of the block.</param>
        /// <returns>Length (byte count) not including terminator.</returns>
        [Op]
        public static unsafe uint length(byte* pSrc, uint maxlen, uint offset, out uint consumed)
        {
            byte* start = pSrc + offset;
            byte* end = pSrc + maxlen;
            byte* current = start;

            while (current < end)
            {
                var b = *current;
                if (b == 0 || b == Chars.Null)
                    break;

                current++;
            }

            var length = (uint)(current - start);
            consumed = length;
            if (current < end)
                consumed++; // null terminator

            return length;
        }
    }
}
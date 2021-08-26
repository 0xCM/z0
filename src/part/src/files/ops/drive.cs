//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static Drive drive(DriveLetter letter)
            => new Drive(letter);

        /// <summary>
        /// Attempts to parse a drive letter from a path
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [Op]
        public static bool drive(string src, out DriveLetter dst)
        {
            var i = text.index(src ,Chars.Colon);
            dst = default;
            if(i>=0)
            {
                var spec = text.left(src,i);
                if(spec.Length == 1)
                {
                    dst = (DriveLetter)spec[0];
                    return true;
                }
            }
            return false;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CmdArgValidity;
    using static ArgValidityState;

    [ApiHost]
    public readonly struct Args
    {
        [Op]
        public static string trim(string value, int startIndex, int length)
        {
            var checks = require(value != null, NonNull);
            checks |= require(startIndex >= 0, NonNeg);
            checks |= require(length >= 0, NonNeg);
            checks |= require(startIndex <= value.Length - length, ArgValidityState.LtEq);

            if(!checks)
                return checks;

            int endIndex = startIndex + length - 1;

            while (startIndex <= endIndex && char.IsWhiteSpace(value[startIndex]))
                startIndex++;

            while (endIndex >= startIndex && char.IsWhiteSpace(value[endIndex]))
                endIndex--;

            int newLength = endIndex - startIndex + 1;
            return
                newLength == 0 ? string.Empty :
                newLength == value.Length ? value :
                value.Substring(startIndex, newLength);
        }
    }
}
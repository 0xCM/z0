//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ArgValidity;
    using static ArgValidityState;

    public static class StringExtensions
    {
        public static string SubstringTrim(this string value, int startIndex, int length)
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
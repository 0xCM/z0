//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static AsciCode;
    using static core;

    using Facets = AsciCodeFacets;

    partial struct AsciCharData
    {
        public static ReadOnlySpan<AsciCode> LowerLetterCodes => new AsciCode[Facets.LowerCount]{
            a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z
            };

        public static ReadOnlySpan<AsciCode> UpperLetterCodes => new AsciCode[Facets.UpperCount]{
            A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
            };

        public static ReadOnlySpan<char> UpperLetterChars => span("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

        public static ReadOnlySpan<char> LowerLetterChars => span("abcdefghijklmnopqrstuvwxyz");
    }
}
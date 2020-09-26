//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.CCI
{
    using System;
    using System.Text;
    using Derivatives.SRM;

    using static Part;

    partial struct ClrStorageReaders
    {
        /// <summary>
        /// Caching 10 StringBuilders per thread (for nested usage)
        /// </summary>
        internal static class StringBuilderCache
        {
            [ThreadStatic]
            private static StringBuilder[] ts_CachedInstances;

            private static int             s_Capacity = 64;

            /// <summary>
            /// Get StringBuilder array
            /// </summary>
            private static StringBuilder[] GetList()
            {
                StringBuilder[] list = ts_CachedInstances;

                if (list == null)
                {
                    list = new StringBuilder[10];

                    ts_CachedInstances = list;
                }

                return list;
            }

            /// <summary>
            /// Acquire a StringBuilder
            /// </summary>
            public static StringBuilder Acquire()
            {
                StringBuilder[] list = GetList();

                // Grab from cache
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] != null)
                    {
                        StringBuilder sb = list[i];

                        list[i] = null;
                        sb.Clear();

                        return sb;
                    }
                }

                // Create new one
                return new StringBuilder(s_Capacity);
            }

            /// <summary>
            /// Release StringBuilder to cache
            /// </summary>
            public static void Release(StringBuilder sb)
            {
                // If the StringBuilder's capacity is larger than our capacity, then it could be multi-chunk StringBuilder
                // Which is inefficient to use. Reject it, but enlarge our capacity, so that new StringBuilder created here will be larger.
                if (sb.Capacity > s_Capacity)
                {
                    s_Capacity = sb.Capacity;
                }
                else // return to cache
                {
                    StringBuilder[] list = GetList();

                    for (int i = 0; i < list.Length; i++)
                    {
                        if (list[i] == null)
                        {
                            list[i] = sb;
                            break;
                        }
                    }
                }
            }

            /// <summary>
            /// Release StringBuilder to cache, after getting string from it
            /// </summary>
            public static string GetStringAndRelease(StringBuilder sb)
            {
                string result = sb.ToString();

                Release(sb);

                return result;
            }
        }
    }
}
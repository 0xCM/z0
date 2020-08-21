//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FS;

    partial struct FS
    {
        public interface ITool : IExecutable
        {

        }

        public interface ITool<T> : ITool, IExecutable<T>
            where T : struct, ITool<T>
        {

        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        public static void Emitting(this EmissionDataType type, IAppContext dst)
            => dst.Deposit(new StepExecuting(type.ToString()));

        public static void Emitting(this EmissionDataType type, FilePath path, IAppContext dst)
            => dst.Deposit(new StepExecuting(type.ToString(), path.Name));

        public static void Emitting(this PartRecordKind dt,  FilePath path, IAppContext dst)
            => PartDataEmitters.emitting(dt, path, dst);
    }
}
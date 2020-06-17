//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    readonly struct VmlMode
    {
        public static VmlMode Define(VmlAccuracy accuracy, VmlErrorMode? errors = null)
            => new VmlMode(accuracy, errors);

        public static implicit operator VmlModeFlags(VmlMode src)
            => (VmlModeFlags)src.Accuracy | (VmlModeFlags)src.ErrorMode;
        
        public VmlMode(VmlAccuracy accuracy, VmlErrorMode? errors = null)
        {
            this.Accuracy = accuracy;
            this.ErrorMode = errors ?? VmlErrorMode.DefaultErrorMode;
        }

        public readonly VmlAccuracy Accuracy;

        public readonly VmlErrorMode ErrorMode;                        

        public VmlModeFlags Flags
            => (VmlModeFlags)Accuracy | (VmlModeFlags)ErrorMode;
    }
}